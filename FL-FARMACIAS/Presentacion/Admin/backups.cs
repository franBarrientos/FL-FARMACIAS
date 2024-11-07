using FL_FARMACIAS.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
                    // Ruta del archivo seleccionado
                    string backupFilePath = openFileDialog.FileName;

                    using (var context = new DBConnect())
                    {
                        try
                        {
                            // Poner la base de datos en modo de recuperación (offline)
                            string setOfflineCommand = $@"
                        ALTER DATABASE [{context.Database.Connection.Database}] 
                        SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, setOfflineCommand);

                            // Comando SQL para restaurar la base de datos
                            string restoreCommand = $@"
                        RESTORE DATABASE [{context.Database.Connection.Database}]
                        FROM DISK = '{backupFilePath}'
                        WITH REPLACE, RECOVERY, STATS = 10";
                            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, restoreCommand);

                            // Poner la base de datos de nuevo en modo multiusuario
                            string setOnlineCommand = $@"
                        ALTER DATABASE [{context.Database.Connection.Database}] 
                        SET MULTI_USER";
                            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, setOnlineCommand);

                            MessageBox.Show($"Restauración de la base de datos completada con éxito desde: {backupFilePath}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}");
                        }
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
