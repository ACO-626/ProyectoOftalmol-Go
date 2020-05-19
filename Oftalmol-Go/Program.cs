#region BIBLIOTECAS
using System;
using System.Windows.Forms;
#endregion

namespace Oftalmol_Go
{
    public class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form VentanaLogin = new FormLogin();
            VentanaLogin.Show();
            Application.Run();
        }
    }
}
