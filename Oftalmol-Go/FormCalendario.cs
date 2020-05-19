using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Oftalmol_Go
{
    public partial class FormCalendario : Form
    {
        #region VARIABLES
        int seleccionado = 0;
        Dictionary<string, Cita> citas = new Dictionary<string, Cita>();
        List<string> pacientes = new List<string>();
        List<string> encontrados = new List<string>();
        #endregion
        public FormCalendario()
        {
            InitializeComponent();
        }

        #region INICIALIZACIÓN DE BASE DE PARÁMETROS DE BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            pacientes.Clear();
            encontrados.Clear();
            
            string fecha = dtpFecha.Value.ToShortDateString();
            string[] aux = fecha.Split('/');

            for (int i=0; i < aux.Length; i++)
            {
                MessageBox.Show(aux[i]);
            }

            client = new FireSharp.FirebaseClient(config);
            var data = await client.GetTaskAsync("PACIENTES");
            try
            {
                citas = data.ResultAs<Dictionary<string, Cita>>();

                foreach (var Cita in citas)
                {
                    pacientes.Add(Cita.Value.citaId.ToString());
                }

                for (int i = 0; i < pacientes.Count; i++)
                {
                    FirebaseResponse recuperacion = await client.GetTaskAsync("PACIENTES/" + pacientes[i]);
                    Cita obj = recuperacion.ResultAs<Cita>();
                    if (aux[0] == obj.day && aux[1] == obj.mounth && aux[2] == obj.year)
                    {
                        encontrados.Add(obj.citaId.ToString());

                        txtbNombre.Text = obj.nombrePaciente;
                        txtbHora.Text = "Hora: " + obj.hora + ":" + obj.minuto;
                        txtbID.Text = obj.citaId.ToString();
                        txtbEdad.Text = obj.edad + "años";
                        txtbCorreo.Text = obj.correoPaciente;
                        txtbTel.Text = "tel. " + obj.telefonoPciente;
                    }
                }
                if (encontrados.Count != 0)
                {
                    MessageBox.Show("Se encontraron " + encontrados.Count.ToString() + " pacientes.");
                }
                else
                {
                    MessageBox.Show("No se encontraron pacientes.");
                }
            }

            catch
            {
                MessageBox.Show("No hay registros en la base de datos.");
            }
        }

        private async void btnSig_Click(object sender, EventArgs e)
        {
            if (seleccionado < encontrados.Count - 1)
            {
                seleccionado++;
                FirebaseResponse recuperacion = await client.GetTaskAsync("PACIENTES/" + encontrados[seleccionado]);
                Cita obj = recuperacion.ResultAs<Cita>();
                txtbNombre.Text = obj.nombrePaciente;
                txtbHora.Text = "Hora: " + obj.hora + ":" + obj.minuto;
                txtbID.Text = obj.citaId.ToString();
                txtbEdad.Text = obj.edad + "años";
                txtbCorreo.Text = obj.correoPaciente;
                txtbTel.Text = "tel. " + obj.telefonoPciente;
            }
        }

        private async void btnAnt_Click(object sender, EventArgs e)
        {
            if (seleccionado > 0)
            {
                seleccionado++;
                FirebaseResponse recuperacion = await client.GetTaskAsync("PACIENTES/" + encontrados[seleccionado]);
                Cita obj = recuperacion.ResultAs<Cita>();
                txtbNombre.Text = obj.nombrePaciente;
                txtbHora.Text = "Hora: " + obj.hora + ":" + obj.minuto;
                txtbID.Text = obj.citaId.ToString();
                txtbEdad.Text = obj.edad + "años";
                txtbCorreo.Text = obj.correoPaciente;
                txtbTel.Text = "tel. " + obj.telefonoPciente;
            }
        }
    }
}
