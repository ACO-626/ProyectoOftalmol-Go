# region BIBLIOTECAS
//Bibliotecas Básicas
using System;
using System.Windows.Forms;
using System.Collections.Generic;
//Bibliotecas de BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion

namespace Oftalmol_Go
{
    public partial class FormAgenda : Form
    {
        #region INICIALIZACIÓN DE VENTANA
        public FormAgenda()
        {
            InitializeComponent();
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

        #region CARGA DE TABLA
        private async void FormAgenda_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            
            /*var cita = await client.GetTaskAsync("PACIENTES/");
            List<long> citas = cita.ResultAs<List<long>>();
            foreach (long citaid in citas)
            {
                MessageBox.Show("Hay" + citas[0] + "Elementos", "PUTO");
            }*/

            
            var data = await client.GetTaskAsync("PACIENTES");
            try
            {
                Dictionary<string, Cita> citas = data.ResultAs<Dictionary<string, Cita>>();
                foreach (var Cita in citas)
                {
                    GridAgenda.Rows.Add(Cita.Value.day + "/" + Cita.Value.mounth + "/" + Cita.Value.year, Cita.Value.hora + ":" + Cita.Value.minuto, Cita.Value.nombrePaciente, Cita.Value.telefonoPciente);
                }
            }
            catch
            {
                MessageBox.Show("No hay registros en la base de datos.");
            }
        }

        #endregion

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Form Calendario = new FormCalendario();
            Calendario.Show();
        }
    }
}
