#region BIBLIOTECAS
//BIBLIOTECAS BÁSICAS
using System;
using System.Windows.Forms;
using System.Collections.Generic;

//BIBLIOTECAS PARA FIRESHARP
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
#endregion

namespace Oftalmol_Go
{
    public partial class FormConsulta : Form
    {
        #region VARIABLES
        int mesSelect = 0;
        int dias = 0;
        int añoSelect = 0;
        bool disponible = true;
        Dictionary<string, Cita> citas = new Dictionary<string, Cita>();
        List<string> pacientes = new List<string>();
        #endregion

        #region INICIALIZACION DE LA VENTANA
        public FormConsulta()
        {
            InitializeComponent();
        }
        #endregion

        #region INICIALIZACIÓN DE BASE DE PARÁMETROS DE BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion

        #region CONSULTA
        private async void btnConsultaListo_Click(object sender, EventArgs e)
        {
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
                    string id = comboAño.Text + comboMes.Text + comboDia.Text + comboHora.Text + comboMin.Text;
                    if (id == obj.citaId.ToString())
                    {
                        MessageBox.Show("Paciente :" + obj.nombrePaciente + "\nFecha : " + obj.day + "/" + obj.mounth + "/" + obj.year + "\nHora" + obj.hora + ":" + obj.minuto, "BASE DE DATOS", MessageBoxButtons.OK);
                        disponible = false;
                    }
                }
                if(disponible == true)
                {
                    MessageBox.Show("El horario está disponible");
                    
                }
                disponible = true;

            }
            catch(SystemException error)
            {
                MessageBox.Show(error.Message);
            }

            this.Close();
        }
        #endregion

        #region COMPORTAMIENTO DE COMBOBOX

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i < 2026; i++)
            {
                comboAño.Items.Add(i);
            }

            for (int i = 0; i < 12; i++)
            {
                comboMes.Items.Add((i + 1).ToString("00"));
            }
            for (int i = 0; i < 24; i++)
            {
                comboHora.Items.Add((i + 1).ToString("00"));
            }
            for (int i = 0; i < 1; i++)
            {
                comboMin.Items.Add(0.ToString("00"));
                comboMin.Items.Add(30);
            }
        }

       

        private void comboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboHora.Enabled = false;
            comboMin.Enabled = false;
            comboDia.Text = "";
            comboMes.Enabled = true;
            if (mesSelect == 2)
            {
                comboMes.SelectedIndex = 2;
                comboMes.SelectedIndex = 1;
            }
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDia.Items.Clear();
            comboHora.Enabled = false;
            comboMin.Enabled = false;
            comboDia.Text = "";
            mesSelect = int.Parse(comboMes.Text);
            añoSelect = int.Parse(comboAño.Text);

            switch (mesSelect)
            {
                case 1:
                    dias = 31;
                    break;
                case 3:
                    dias = 31;
                    break;
                case 7:
                    dias = 31;
                    break;
                case 8:
                    dias = 31;
                    break;
                case 10:
                    dias = 31;
                    break;
                case 12:
                    dias = 31;
                    break;
                case 2:
                    if (añoSelect % 4 == 0)
                    {
                        dias = 29;
                    }
                    else
                    {
                        dias = 28;
                    }
                    break;
                default:
                    dias = 30;
                    break;
            }

            for (int i = 0; i < dias; i++)
            {

                comboDia.Items.Add((i + 1).ToString("00"));
            }
            comboDia.Enabled = true;
        }

        private void comboDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboHora.Enabled = true;
        }

        private void comboHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMin.Enabled = true;
        }
        #endregion

    }
}
