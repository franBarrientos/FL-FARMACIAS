using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS.Presentacion.Admin
{
    public partial class backups : Form
    {
        public backups()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Crear y mostrar el diálogo de selección de carpeta
                using (var folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Selecciona una carpeta para guardar el respaldo";

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Ruta seleccionada por el usuario
                        string selectedPath = folderDialog.SelectedPath;

                        // Formato de la fecha para el nombre del archivo (e.g., "20241106")
                        string fecha = DateTime.Now.ToString("yyyyMMdd");
                        string backupFileName = $"FL-FARMACIAS-Backup_{fecha}.bak";
                        string backupPath = System.IO.Path.Combine(selectedPath, backupFileName);

                        using (var context = new DBConnect())
                        {
                            // Comando SQL para el backup
                            string sqlCommand = $@"
                    BACKUP DATABASE [{context.Database.Connection.Database}]
                    TO DISK = '{backupPath}'
                    WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                            // Ejecuta el comando SQL
                            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);

                            MessageBox.Show($"Backup realizado con éxito en: {backupPath}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se seleccionó ninguna carpeta. Operación cancelada.");
                    }
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Respaldo (*.bak)|*.bak";
                openFileDialog.Title = "Selecciona un archivo de respaldo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = openFileDialog.FileName;
                    string databaseName = "FarmaciaDB"; // Especifica el nombre de tu base de datos

                    try
                    {
                        using (var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True"))
                        {
                            connection.Open();

                            var getSessionsCommand = new SqlCommand($@"
                            SELECT request_session_id 
                            FROM sys.dm_tran_locks 
                            WHERE resource_database_id = DB_ID('{databaseName}')", connection);

                            var sessionIds = new List<int>();
                            using (var reader = getSessionsCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    sessionIds.Add(reader.GetInt32(0));
                                }
                            } // El DataReader se cierra aquí

                            // Ejecutar comando KILL para cada sesión
                            foreach (int sessionId in sessionIds)
                            {
                                var killCommand = new SqlCommand($"KILL {sessionId}", connection);
                                killCommand.ExecuteNonQuery();
                            }

                            // 1. Poner la base de datos en modo de usuario único y cerrar conexiones activas
                            var setSingleUserCommand = new SqlCommand($@"
                    ALTER DATABASE [{databaseName}]
                    SET SINGLE_USER WITH ROLLBACK IMMEDIATE", connection);
                            setSingleUserCommand.ExecuteNonQuery();

                            // 2. Restaurar la base de datos desde el archivo .bak
                            var restoreCommand = new SqlCommand($@"
                    RESTORE DATABASE [{databaseName}]
                    FROM DISK = '{backupFilePath}'
                    WITH REPLACE, RECOVERY, STATS = 10", connection);
                            restoreCommand.ExecuteNonQuery();

                            // 3. Poner la base de datos de nuevo en modo multiusuario
                            var setMultiUserCommand = new SqlCommand($@"
                    ALTER DATABASE [{databaseName}]
                    SET MULTI_USER", connection);
                            setMultiUserCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Restauración de la base de datos completada con éxito desde: {backupFilePath}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("No se seleccionó ningún archivo. Operación cancelada.");
                }
            }
        }

    }
}
