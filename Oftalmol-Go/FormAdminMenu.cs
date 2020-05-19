using System;
using System.Media;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormAdminMenu : Form
    {
        #region VARIABLES
        string rootname = "";
        bool rootmode = true;
        #endregion


        public FormAdminMenu(string nombre, bool rootMode)
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            try
            {
                player.SoundLocation = @"..\..\SOUND\Bienvenido.wav";
                player.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Archivos de sonido, error: 1001");
            }
            rootname = nombre;
            rootmode = rootMode;
            var CerrarSesion = new ToolTip();
            var Cerrar = new ToolTip();

            CerrarSesion.SetToolTip(btnSalir,"Cerrar sesión");
            Cerrar.SetToolTip(btnCerrar,"CERRAR");

        }

        #region BOTONES
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaLogin = new FormLogin();
            VentanaLogin.Show();
        }

        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaMenu = new FormMenu(rootname,rootmode);
            VentanaMenu.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaAdminUser = new FormUserAdmin(rootname,rootmode);
            VentanaAdminUser.Show();
        }
    }
}
