#region BIBLIOTECAS
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
//Firebase
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion

namespace Oftalmol_Go
{
    public partial class FormHiUser : Form
    {
        #region VARIABLES
        string rootName;
        bool rootMode;
        int numerousuario;
        int userLimite;
        
        List<long> userList = new List<long>();
        Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
        #endregion

        #region INSTANCIAS DE LA BASE DE DATOS
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"
        };
        IFirebaseClient client;
        #endregion

        #region INICIALIZAR VENTANA
        public FormHiUser(string rootname, bool rootmode)
        {
            InitializeComponent();
            rootName = rootname;
            rootMode = rootmode;
        }

        private async void FormHiUser_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            var data = await client.GetTaskAsync("CONTADOR/usuarios");
            if (data.Body != "null")
            {
                FirebaseResponse recuperacion = await client.GetTaskAsync("CONTADOR/usuarios");
                Contador obj = recuperacion.ResultAs<Contador>();
                numerousuario = obj.cantidad;
                userLimite = obj.userlimite;

                
            }
            else
            {
                var contador = new Contador
                {
                    cantidad = 0,
                    userlimite = 1
                    
                };
                SetResponse response = await client.SetTaskAsync("CONTADOR/usuarios", contador);
                numerousuario = 0;
            }

            /*
           client = new FireSharp.FirebaseClient(config);

           var datos = await client.GetTaskAsync("USUARIOS");
           if (datos.Body != "null")
           {
               usuarios = datos.ResultAs<Dictionary<string,Usuario>>();

               foreach (var Usuario in usuarios)
               {
                   userList.Add(Usuario.Value.userID);
               }
               numerousuario = userList.Count;
               MessageBox.Show(numerousuario.ToString());
           }

           client = new FireSharp.FirebaseClient(config);
           var data = await client.GetTaskAsync("USUARIOS/");
           //Dictionary<string, Usuario> usuarios = data.ResultAs<Dictionary<string, Usuario>>();           
           Dictionary<string, Usuario> usuarios = data.ResultAs<Dictionary<string, Usuario>>();
           foreach (var usuario in usuarios)
           {
               userList.Add(usuario.Value.username);
           }

           numerousuario = userList.Count;
           */
        }
        #endregion
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VentanaUsereMenu = new FormUserAdmin(rootName,rootMode);
            VentanaUsereMenu.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Registrar();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtbContra1_Enter(object sender, EventArgs e)
        {
            if (txtbContra1.Text == "Confirmación")
            {
                txtbContra1.PasswordChar = '*';
                txtbContra1.Text = "";
            }
        }

        private void txtbContra1_Leave(object sender, EventArgs e)
        {
            if(txtbContra1.Text=="")
            {
                txtbContra1.PasswordChar = '\0';
                txtbContra1.Text = "Confirmación";
            }
        }

        private void txtbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {

                this.Registrar();
            }
        }

        #region METODO REGISTRAR
        public async void Registrar()
        {
            if(txtbName.Text=="")
            {
                MessageBox.Show("Debe ingresar el nombre del usuario", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txtbUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txtbContra.Text==""&&txtbContra.Text!="Confirmación")
            {
                MessageBox.Show("Debe ingresar una contraseña válida", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(txtbContra.Text==txtbContra1.Text)
            {
                if(txtbContra1.Text!=""||txtbContra1.Text!="Confirmacion")
                {
                    this.Enabled = false;
                    client = new FireSharp.FirebaseClient(config);
                    var usuario = new Usuario
                    {
                        //userID = (numerousuario + 1).ToString(),
                        userID = userLimite+1,
                        username = txtbName.Text,
                        user = txtbUsuario.Text,
                        password = txtbContra1.Text
                    };
                    SetResponse response = await client.SetTaskAsync("USUARIOS/" + usuario.userID, usuario);
                    Usuario resultados = response.ResultAs<Usuario>();
                    numerousuario++;
                    var contador = new Contador
                    {
                        cantidad = numerousuario,
                        userlimite = userLimite+1,
                        
                    };
                    SetResponse respuesta = await client.SetTaskAsync("CONTADOR/usuarios", contador);                   
                    MessageBox.Show("Registro exitoso en la base de datos", "BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Form ventanaAdminMenu = new FormAdminMenu(rootName,rootMode);
                    ventanaAdminMenu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseñas inválidas", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtbContra.Text = "";
                    txtbContra1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbContra1.Text = "";
            }




        }
        #endregion

    }
}
