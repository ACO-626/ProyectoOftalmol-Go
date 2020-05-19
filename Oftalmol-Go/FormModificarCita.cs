#region BIBLIOTECAS
using System;
using System.Windows.Forms;
#endregion

namespace Oftalmol_Go
{
    public partial class FormModificarCita : Form
    {
        #region VARIABLES
        int indicador=0;
        #endregion

        #region INICIALIZACION DE VENTANA
        public FormModificarCita()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModFecha_Click(object sender, EventArgs e)
        {
            indicador = 1;
            Form VentanaModificacion = new FormModifica(indicador);
            VentanaModificacion.Show();
        }

        private void btnModNombre_Click(object sender, EventArgs e)
        {
            indicador = 2;
            Form VentanaModificacion = new FormModifica(indicador);
            VentanaModificacion.Show();
        }

        private void btnModTel_Click(object sender, EventArgs e)
        {
            indicador = 3;
            Form VentanaModificacion = new FormModifica(indicador);
            VentanaModificacion.Show();
        }

        private void btnModCorreo_Click(object sender, EventArgs e)
        {
            indicador = 4;
            Form VentanaModificacion = new FormModifica(indicador);
            VentanaModificacion.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form VentanaEliminar = new FormEliminar();
            VentanaEliminar.Show();
        }
        #endregion
    }
}
