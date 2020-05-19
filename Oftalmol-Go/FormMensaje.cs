using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oftalmol_Go
{
    public partial class FormMensaje : Form
    {
        string Mensaje;
        string Titulo;
        byte tipo;

        public FormMensaje(string mensaje, string titulo, string boton, bool cancelar,byte Tipo)
        {
            InitializeComponent();
            Mensaje = mensaje;
            Titulo = titulo;
            lbMensaje.Text = mensaje;
            lbTitle.Text = titulo;
            if(cancelar==false)
            {
                lbCancelar.Visible = false;
                lbCancelar.Enabled = false;
                
            }
            btnbtn.Text = boton;
            tipo = Tipo;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbtn_Click(object sender, EventArgs e)
        {
            if(tipo==1)
            {
                var frm = Application.OpenForms.OfType<FormMenu>().FirstOrDefault();
                if (frm != null) frm.Close();
                this.Close();
                Form VentanLogin = new FormLogin();
                VentanLogin.Show();
            }
            else
            {
                this.Close();
            }
            
        }

        private void lbCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

  
    }
}
