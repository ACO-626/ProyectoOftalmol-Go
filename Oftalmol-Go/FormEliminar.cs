#region BIBLIOTECAS
//BIBLIOTECAS BÁSICAS
using System;
using System.Windows.Forms;
using System.Collections.Generic;

//BIBLIOTECAS DE BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion

namespace Oftalmol_Go
{
    public partial class FormEliminar : Form
    {
        #region INICIALIZACION DE CONEXIÓN A LA BASE DATOS
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        #endregion

        #region VARIABLES
        int seleccionado;
        Cita aux = new Cita();
        Dictionary<string, Cita> citas = new Dictionary<string, Cita>();
        List<string> pacientes = new List<string>();
        List<string> encontrados = new List<string>();
        #endregion

        #region INICIALIZACIÓN DE VENTANA

        public FormEliminar()
        {
            InitializeComponent();
        }
        #endregion

        #region BOTONES
        private void btnCancelarEliminar_Click(object sender, EventArgs e)
        {
            encontrados.Clear();
            pacientes.Clear();
            this.Close();
        }
        #endregion  

        #region ELIMINAR
        private async void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if(encontrados.Count != 0)
            {
                this.Enabled = false;
                client = new FireSharp.FirebaseClient(config);
                var cita = new Cita
                {
                    citaId = long.Parse(encontrados[seleccionado])
                };
                FirebaseResponse response = await client.DeleteTaskAsync("PACIENTES/" + cita.citaId);
                MessageBox.Show("Se ha borrado la cita exitosamente de " + cita.citaId, "Base de datos");
                encontrados.Clear();
                pacientes.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay algún paciente seleccionado.");
            }
        }

        #endregion

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            encontrados.Clear();
            pacientes.Clear();
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
                    if (txtbNombreBusq.Text.ToUpper() == obj.nombrePaciente.ToUpper())
                    {
                        encontrados.Add(obj.citaId.ToString());

                        lbPaciente.Text = obj.nombrePaciente;
                        lbDia.Text = obj.day;
                        lbMes.Text = obj.mounth;
                        lbAño.Text = obj.year;
                        lbHora.Text = obj.hora;
                        lbMin.Text = obj.minuto;
                        lbCorreo.Text = obj.correoPaciente;
                        lbTel.Text = "tel. " + obj.telefonoPciente;
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
                lbPaciente.Text = obj.nombrePaciente;
                lbDia.Text = obj.day;
                lbMes.Text = obj.mounth;
                lbAño.Text = obj.year;
                lbHora.Text = obj.hora;
                lbMin.Text = obj.minuto;
                lbCorreo.Text = obj.correoPaciente;
                lbTel.Text = "tel. " + obj.telefonoPciente;
            }
        }

        private async void btnAnt_Click(object sender, EventArgs e)
        {
            if (seleccionado > 0)
            {
                seleccionado--;
                FirebaseResponse recuperacion = await client.GetTaskAsync("PACIENTES/" + encontrados[seleccionado]);
                Cita obj = recuperacion.ResultAs<Cita>();
                lbPaciente.Text = obj.nombrePaciente;
                lbDia.Text = obj.day;
                lbMes.Text = obj.mounth;
                lbAño.Text = obj.year;
                lbHora.Text = obj.hora;
                lbMin.Text = obj.minuto;
                lbCorreo.Text = obj.correoPaciente;
                lbTel.Text = "tel. " + obj.telefonoPciente;
            }
        }
    }
}
