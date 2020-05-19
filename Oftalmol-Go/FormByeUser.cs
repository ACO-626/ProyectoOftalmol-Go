#region BIBLIOTECAS
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//BIBLIOTECAS DE BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion
namespace Oftalmol_Go
{
    public partial class FormByeUser : Form
    {
        #region VARIABLES
        string rootName;
        bool rootMode;
        int numerousuarios;
        int limiteusuario;
        int indiceActual = 0;
        List<int> candidatos = new List<int>();
        #endregion

        #region INSTANCIAS DE BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion

        #region INICIALIZA VENTANA
        public FormByeUser(string rootname,bool rootmode)
        {
            InitializeComponent();
            rootName = rootname;
            rootMode = rootmode;
            btnAdelante.Enabled = false;
            btnAtras.Enabled = false;
            
            
        }
        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaUserAdmin = new FormUserAdmin(rootName,rootMode);
            VentanaUserAdmin.Show();
        }

        private async void FormByeUser_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            var data = await client.GetTaskAsync("CONTADOR/usuarios");
            if (data.Body != "null")
            {
                FirebaseResponse recuperacion = await client.GetTaskAsync("CONTADOR/usuarios");
                Contador obj = recuperacion.ResultAs<Contador>();
                numerousuarios = obj.cantidad;
                limiteusuario = obj.userlimite;
               
                if(numerousuarios!=0)
                {

                    this.ListaUsuarios();                    
                    
                    

                }                
                else
                {
                    btnAtras.Enabled = false;
                    btnAdelante.Enabled = false;
                }


            }
            else
            {
                btnCaja.Text = "No hay usuarios registrados, dirigase a la sección de agredar usuario";
                btnAtras.Enabled = false;
                btnAdelante.Enabled = false;
            }
        }

        public async void ListaUsuarios()
        {
            
           
            

            for(int i =0; i<limiteusuario;i++)
            {
                var data = await client.GetTaskAsync("USUARIOS/"+(i+1));
                if (data.Body != "null")
                {
                    FirebaseResponse recuperacion = await client.GetTaskAsync("USUARIOS/"+(i+1));
                    Usuario obj = recuperacion.ResultAs<Usuario>();
                    candidatos.Add(obj.userID);
                }
                else
                {

                }
               
            }
            
            this.presentaUsuario();




        }
        public async void presentaUsuario()
        {          
            int indice = candidatos[indiceActual];
            var data = await client.GetTaskAsync("USUARIOS/" + indice);
            FirebaseResponse recuperacion = await client.GetTaskAsync("USUARIOS/" + indice);
            Usuario obj = recuperacion.ResultAs<Usuario>();
            btnCaja.Text = obj.username;

            btnAtras.Enabled = true;
            btnAdelante.Enabled = true;
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            indiceActual++;
            if(indiceActual>=numerousuarios)
            {
                indiceActual = 0;
                presentaUsuario();
            }
            else
            {
                presentaUsuario();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indiceActual--;
            if(indiceActual<0)
            {
                indiceActual = numerousuarios-1;
                presentaUsuario();
            }
            else
            {
                presentaUsuario();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);            
            FirebaseResponse response = await client.DeleteTaskAsync("USUARIOS/" + candidatos[indiceActual]);
            MessageBox.Show("Eliminación exitosa de la base de datos","BASE DE DATOS");            
            this.Close();
            Form VentanaAdminMenu = new FormAdminMenu(rootName, rootMode);
            VentanaAdminMenu.Show();

            var data = await client.GetTaskAsync("CONTADOR/usuarios");
            if (data.Body != "null")
            {

                var contador = new Contador
                {
                    cantidad = numerousuarios - 1,
                    userlimite = limiteusuario
                };
                SetResponse respuesta= await client.SetTaskAsync("CONTADOR/usuarios", contador);


            }
            else
            {
                MessageBox.Show("Error 1002, el programa se cerrará por cuestiones de seguridad","");
                Application.Exit();
            }

        }
    }
}
