#region BIBLIOTECAS
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Media;

//BIBLIOTECAS PARA BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

#endregion

namespace Oftalmol_Go
{
    public partial class FormMenu : Form
    {

        #region VARIABLES Y COLECCIONES
        string nnombre;
        string año;
        string mes;
        string dia;
        string min;
        string hora;
        int seleccionado;
        Dictionary<string, Cita> citas = new Dictionary<string, Cita>();
        List<string> pacientes = new List<string>();

        bool rootMode;

        #endregion

        #region INICIALIZACIÓN DE VENTANA
        public FormMenu(string nombre, bool rootmode)
        {
            InitializeComponent();
            pacientes.Clear();
            SoundPlayer player = new SoundPlayer();
            try
            {
                player.SoundLocation = @"..\..\SOUND\1.wav";
                player.Play();
            }
            catch(Exception)
            {
                MessageBox.Show("Faltan Archivos de sonido, error: 1001");
            }            
            nnombre = nombre;
            rootMode = rootmode;
            if(rootmode==true)
            {
                btnMenu.Visible = true;
            }
            //Nuestra lista de pacientes

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            lbSimpleNombre.Text = nnombre; 
            this.ActualizarAll();
            
        }
        #endregion

        #region INSTANCIAS PARA BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        #endregion

        #region BOTONES
        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            Form ventanaAgendar = new FormCrearCita();
            ventanaAgendar.Show();
        }

        public void btnReagendarCita_Click(object sender, EventArgs e)
        {
            Form VentanaModificarCita = new FormModificarCita();
            VentanaModificarCita.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Form VentanaConsulta = new FormConsulta();
            VentanaConsulta.Show();
        }
        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Form VentanaAgenda = new FormAgenda();
            VentanaAgenda.Show();
        }
        private async void btnAfter_Click(object sender, EventArgs e)
        {
            if (seleccionado == pacientes.Count - 1)
            {
                MessageBox.Show("No hay más pacientes.");
            }
            else
            {
                seleccionado++;
                try
                {
                    FirebaseResponse response = await client.GetTaskAsync("PACIENTES/" + pacientes[seleccionado]);
                    if(response.Body!=null)
                    {
                        Cita obj = response.ResultAs<Cita>();
                        lbPaciente.Text = obj.nombrePaciente;
                        lbTel.Text = obj.telefonoPciente;
                        lbCorreo.Text = obj.correoPaciente;
                        lbDia.Text = obj.day;
                        lbAño.Text = obj.year;
                        lbMes.Text = obj.mounth;
                        lbHora.Text = obj.hora;
                        lbMin.Text = obj.minuto;
                        lbEdad.Text = "Edad: " + obj.edad;
                    }
                    else
                    {
                        ActualizarAll();
                    }
                }
                catch
                {
                    ActualizarAll();
                }
            }
            
        }

        private async void btnBefore_Click(object sender, EventArgs e)
        {
            if (seleccionado<=0)
            {
                MessageBox.Show("No hay más pacientes.");
            }
            else
            {
                seleccionado--;
                try
                {
                    FirebaseResponse response = await client.GetTaskAsync("PACIENTES/" + pacientes[seleccionado]);
                    if (response.Body != null)
                    {
                        Cita obj = response.ResultAs<Cita>();
                        lbPaciente.Text = obj.nombrePaciente;
                        //lbSimpleEstado.Text = ("Lugar " + aux.ToString());
                        lbTel.Text = obj.telefonoPciente;
                        lbCorreo.Text = obj.correoPaciente;
                        lbDia.Text = obj.day;
                        lbAño.Text = obj.year;
                        lbMes.Text = obj.mounth;
                        lbHora.Text = obj.hora;
                        lbMin.Text = obj.minuto;
                        lbEdad.Text = "Edad: " + obj.edad;
                    }
                    else
                    {
                        ActualizarAll();
                    }
                }
                catch(Exception)
                {
                    ActualizarAll();
                };
                
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ActualizarAll();
        }
        #endregion

        #region TIEMPO
        private void TmHoraR_Tick(object sender, EventArgs e)
        {
            lbRealHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFechaReal.Text = DateTime.Now.ToString("d/M/yyyy");
        }
        #endregion

        #region MÉTODO ACTUALIZAR TODO
        public async void ActualizarAll()
        {
            lbSimpleEstado.Text = "";
            client = new FireSharp.FirebaseClient(config);
            año = DateTime.Now.ToString("yyyy");
            mes = DateTime.Now.ToString("MM");
            dia = DateTime.Now.ToString("dd");
            hora = DateTime.Now.ToString("HH");
            min = DateTime.Now.ToString("mm");
            pacientes.Clear();
            client = new FireSharp.FirebaseClient(config);
            var data = await client.GetTaskAsync("PACIENTES");
            if (data.Body != "null")
            {




                citas = data.ResultAs<Dictionary<string, Cita>>();
                foreach (var Cita in citas)
                {
                    pacientes.Add(Cita.Value.citaId.ToString());
                }

                for (int i = 0; i < pacientes.Count; i++)
                {
                    if (long.Parse(pacientes[i]) < long.Parse(año + mes + dia + hora + min))
                    {

                        if (pacientes.Count == 1 || i == (pacientes.Count - 1))
                        {
                            seleccionado = i;
                        }
                        else
                        {
                            seleccionado = i + 1;
                        }
                    }
                }

                FirebaseResponse response = await client.GetTaskAsync("PACIENTES/" + pacientes[seleccionado]);
                Cita obj = response.ResultAs<Cita>();
                lbPaciente.Text = obj.nombrePaciente;
                lbTel.Text = obj.telefonoPciente;
                lbCorreo.Text = obj.correoPaciente;
                lbDia.Text = obj.day;
                lbAño.Text = obj.year;
                lbMes.Text = obj.mounth;
                lbHora.Text = obj.hora;
                lbMin.Text = obj.minuto;
                lbEdad.Text = "Edad: " + obj.edad;
            }
            else
            {
                lbSimpleEstado.Text = "TODAVÍA NO HAY REGISTROS ";
                lbPaciente.Text = "Hola, todo listo para su primer registro";
                lbTel.Text = "tel. ------------";
                lbCorreo.Text = "mail: ----------";
                lbDia.Text = "--";
                lbAño.Text = "--";
                lbMes.Text = "--";
                lbHora.Text = "--";
                lbMin.Text = "--";
                lbEdad.Text = "Edad: --";
            }
        }

        #endregion

        #region CERRADO DE VENTANA
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }



        #endregion

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {         
            Form VentanaMensaje = new FormMensaje("Confirmación para cerrar sesión","MENSAJE","Confirmar",true,1);
            VentanaMensaje.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puedes encontrar el manual de usuario aquí: https://www.youtube.com/watch?v=CUdRuml6efA o contactarnos nuestro correro oftalmolgo@oftal.com para soporte técnico", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form ventanaAdminMenu = new FormAdminMenu(nnombre,rootMode);
            ventanaAdminMenu.Show();
        }
    }

}
