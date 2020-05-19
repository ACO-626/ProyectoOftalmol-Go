using System;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormUserAdmin : Form
    {
        #region VARIABLES
        string rootName;
        bool rootMode;

        #endregion

        public FormUserAdmin(string rootname, bool rootmode)
        {
            InitializeComponent();
            rootMode = rootmode;
            rootName = rootname;
            var tipCerrar = new ToolTip();
            var tipAtras = new ToolTip();
            tipCerrar.SetToolTip(btnCerrar, "CERRAR");
            tipAtras.SetToolTip(btnAtras, "Regresar");

        }

  

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaByeUser = new FormByeUser(rootName,rootMode);
            VentanaByeUser.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ventanaAdminMenu = new FormAdminMenu(rootName, rootMode);
            ventanaAdminMenu.Show();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaHiUser = new FormHiUser(rootName, rootMode);
            VentanaHiUser.Show();
        }
    }
}
