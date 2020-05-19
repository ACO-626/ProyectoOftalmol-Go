#region BIBLIOTECAS
//Bibliotecas básicas

using System;
using System.Windows.Forms;
using System.Collections.Generic;

//Bibliotecas de BD

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
#endregion

namespace Oftalmol_Go
{
    public partial class FormCrearCita : Form
    {

        #region VARIABLES
        int mesSelect = 0;
        int dias = 0;
        int añoSelect = 0;
        int seleccionado = 0;
        bool repetido = false;
        Dictionary<string, Cita> citas = new Dictionary<string, Cita>();
        List<string> pacientes = new List<string>();
        List<string> horarios = new List<string>();
        #endregion

        #region INSTANCIAS PRINCIPALES PARA LA BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        #endregion
        
        #region INICIALIZACIÓN BÁSICA DE VENTANA
        public FormCrearCita()
        {
            InitializeComponent();
            fechaAgendarLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Actualizar();
        }
        #endregion
        
        #region COMPORTAMIENTO DE TEXTBOX
        //Comportamiento de Nombre paciente
        private void txtbPaciente_Enter(object sender, EventArgs e)
        {
            if (txtbPaciente.Text == "Nombre")
            {
                txtbPaciente.Text = "";
            }

        }
        private void txtbPaciente_Leave(object sender, EventArgs e)
        {
            if(txtbPaciente.Text=="")
            {
                txtbPaciente.Text = "Nombre";
            }
            
        }

        //Fin de sección de Paciente nombre
        //
        //
        //Comportamiento de caja teléfono
        private void txtbTel_Enter(object sender, EventArgs e)
        {
            if (txtbTel.Text == "Tel.")
            {
                txtbTel.Text = "";

            }
        }

        private void txtbTel_Leave(object sender, EventArgs e)
        {
            if (txtbTel.Text == "")
            {
                txtbTel.Text = "Tel.";
            }
        }
        //Fin de comportamiento de caja teléfono
        //
        //Comportamiento caja de texto correo
        private void txtbmail_Enter(object sender, EventArgs e)
        {
            if (txtbmail.Text == "Correo")
            {
                txtbmail.Text = "";
            }
        }

        private void txtbmail_Leave(object sender, EventArgs e)
        {
            if (txtbmail.Text == "")
            {
                txtbmail.Text = "Correo";
            }
        }
        #endregion

        #region COMPORTAMIENTO DE COMBOBOX
        private void comboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboHora.Enabled = false;
            comboMin.Enabled = false;
            comboDia.Text = "Día";
            comboMes.Enabled = true;
            if(mesSelect==2)
            {
                comboMes.SelectedIndex = 2;
                comboMes.SelectedIndex = 1;                  
            }
        }
        private void FormCrearCita_Load(object sender, EventArgs e)
        {
            for(int i=2020;i<2026; i++)
            {
                comboAño.Items.Add(i);
            }

            for (int i=0; i<12;i++)
            {
                comboMes.Items.Add((i + 1).ToString("00"));
            }
            for(int i = 0;i<24 ; i++)
            {
                comboHora.Items.Add((i + 1).ToString("00"));
            }
            for(int i=0;i<1 ;i++)
            {
                comboMin.Items.Add(0.ToString("00"));
                comboMin.Items.Add(30);
            }
            
          
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDia.Items.Clear();
            comboHora.Enabled = false;
            comboMin.Enabled = false;
            comboDia.Text = "Día";
            mesSelect = int.Parse(comboMes.Text);
            añoSelect = int.Parse(comboAño.Text);
            
            switch(mesSelect)
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
                    if(añoSelect%4==0)
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
                
                comboDia.Items.Add((i+1).ToString("00"));
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

        #region BOTONES
        private void lbSimpleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region MANEJO DE EXCEPCIONES AL INGRESAR DATOS DE CITA
        private async void btnAgendarCita_Click(object sender, EventArgs e)
        {

           
            if (txtbPaciente.Text=="Nombre" || txtbTel.Text=="Tel." || comboMin.Text=="Min")
            {
                MessageBox.Show("FALTAN DATOS POR LLENAR", "ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                this.Enabled = false;
                client = new FireSharp.FirebaseClient(config);
                try
                {


                    var cita = new Cita
                    {
                        citaId = long.Parse(comboAño.Text + comboMes.Text + comboDia.Text + comboHora.Text + comboMin.Text),
                        day = comboDia.Text,
                        mounth = comboMes.Text,
                        year = comboAño.Text,
                        hora = comboHora.Text,
                        minuto = comboMin.Text,
                        edad = txtbEdad.Text,
                        nombrePaciente = txtbPaciente.Text,
                        telefonoPciente = txtbTel.Text,
                        correoPaciente = txtbmail.Text
                    };
               

                
                for(int i=0; i<pacientes.Count; i++)
                {
                    if (cita.citaId.ToString() == pacientes[i])
                    {
                        repetido = true;
                    }
                }
               if(repetido != true)
                {
                    SetResponse response = await client.SetTaskAsync("PACIENTES/" + cita.citaId, cita);
                    Cita resultados = response.ResultAs<Cita>();

                    MessageBox.Show("Registro exitoso en la base de datos", "BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La fecha no está disponible, no se agregó a la base de datos.", "BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    repetido = false;
                    this.Close();
                }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Favor de ingresar datos válidos","Datos equivocados",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    this.Enabled = true;

                }
            }
         
        }
        #endregion

        public async void Actualizar()
        {
            horarios.Clear();
            pacientes.Clear();
            client = new FireSharp.FirebaseClient(config);
            var data = await client.GetTaskAsync("PACIENTES");
            for (int i = 0; i < 24; i++)
            {
                if (i < 9)
                {
                    horarios.Add("0" + (i+1).ToString());
                    horarios.Add("0" + (i+1).ToString());
                }
                else
                {
                    horarios.Add((i+1).ToString());
                    horarios.Add((i+1).ToString());
                }
            }
            for (int i=0; i< horarios.Count; i++)
            {
                if (i % 2 == 0)
                {
                    horarios[i] += ":00";
                }
                else
                {
                    horarios[i] += ":30";
                }
            }
            try
            {
                if (data.Body != "null")
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
                        if (DateTime.Now.ToString("yyyy") == obj.year && DateTime.Now.ToString("MM") == obj.mounth && DateTime.Now.ToString("dd") == obj.day)
                        {

                            for (int j = 0; j < horarios.Count; j++)
                            {
                                string horaAux = obj.hora + ":" + obj.minuto;
                                if (horarios[j] == horaAux)
                                {
                                    horarios.RemoveAt(j);
                                }
                            }
                        }
                    }
                    if (horarios.Count != 0)
                    {
                        MessageBox.Show("Hay " + horarios.Count.ToString() + " horarios disponibles el día de hoy.");
                        horaLabel.Text = horarios[seleccionado];
                    }
                    else
                    {
                        MessageBox.Show("No hay horarios diponibles el día de hoy.");
                        horaLabel.Text = "--:--";
                    }
                }
            }
            catch
            {
                MessageBox.Show("No hay registros en la base de datos.");
                horaLabel.Text = horarios[seleccionado];
            }
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            if (seleccionado < horarios.Count - 1)
            {
                seleccionado++;
                horaLabel.Text = horarios[seleccionado];
            }
            else
            {
                MessageBox.Show("No hay más horarios.");
            }
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if (seleccionado > 0)
            {
                seleccionado--;
                horaLabel.Text = horarios[seleccionado];
            }
            else
            {
                MessageBox.Show("No hay más horarios.");
            }
        }
    }
}
