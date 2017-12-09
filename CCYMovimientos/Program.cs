using CCYMovimientos.Modelos;
using CCYMovimientos.Vistas.Menu;
using CCYMovimientos.Vistas.Sesiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCYMovimientos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login frmLogin = new Login();
            
            frmLogin.ShowDialog();

            if (frmLogin.getStatus())
            {
                MenuPrincipal mPrincipal = new MenuPrincipal(frmLogin.getSesion());
                mPrincipal.FormBorderStyle = FormBorderStyle.Sizable;
                Application.Run(mPrincipal);
            }
            
            Application.Exit();

        }
    }
}
