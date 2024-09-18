using FL_FARMACIAS.Presentacion;
using FL_FARMACIAS.Presentacion.Admin;
using FL_FARMACIAS.Presentacion.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_FARMACIAS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new TEST());
            //Application.Run(new productoSubMenu());
            //Application.Run(new EmpleadoSubMenu());
            Application.Run(new LoginForm());
        }
    }
}
