
#region BIBLIOTECAS
using System;
using System.Drawing;
using System.Windows.Forms;
//BIBLIOTECAS PARA BD
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
#endregion
namespace Oftalmol_Go
{
    public partial class FormLogin : Form
    {
        #region VARIABLES 
        bool rootMode = false;
        bool acceso = false;
        int limiteusuario;
        int numerousuario;
        #endregion

        #region INSTANCIAS DE BD
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "608vd6SDwtR7uGhPNhd9j7bbgL0E2mR0xbhyOwSk",
            BasePath = "https://oftalmol-godb.firebaseio.com/"

        };
        IFirebaseClient client;
        #endregion

        #region INICIALIZACIÓN DE VENTANA
        public FormLogin()
        {
            InitializeComponent();
            btnUser.Enabled = false;
            var HELP = new ToolTip();
            var Rootfalse = new ToolTip();
            var Roottrue = new ToolTip();
            HELP.SetToolTip(btnHelp, "Apoyo técnico");
            Rootfalse.SetToolTip(btnUser, "Modo usuario");
            Roottrue.SetToolTip(btnRoot, "Modo administrador");
        }
        #endregion

        #region BOTONES

        private void btnClose_Click(object sender, EventArgs e)
        {            
            this.Close();
            Application.Exit();
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para asistencia técnica envianos un correo a oftalmolgo@program.com", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lbCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void lbLimpiar_Click(object sender, EventArgs e)
        {
            txtbPassword.Text = "CONTRASEÑA";
            txtbPassword.PasswordChar = '\0';
            txtbUser.Text = "USUARIO";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            iniciarSesion();

        }
        #endregion

        #region COMPORTAMIENTO DE LOS TEXBOX
        private void txtbUser_Enter(object sender, EventArgs e)
        {
            if(txtbUser.Text=="USUARIO")
            {
                txtbUser.Text = "";
            }                   
        }
        private void txtbUser_Leave(object sender, EventArgs e)
        {
            if (txtbUser.Text == "")
            {
                txtbUser.Text = "USUARIO";
            }
        }
        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            if(txtbPassword.Text=="CONTRASEÑA")
            {
                txtbPassword.Text = "";
                this.txtbPassword.PasswordChar = '*';
            }
        }
        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            if(txtbPassword.Text=="")
            {
                this.txtbPassword.PasswordChar = '\0';
                txtbPassword.Text = "CONTRASEÑA";
            }
          
        }
        private void txtbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                iniciarSesion();
            }
        }

        private void txtbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (txtbUser.Text != "")
                {
                    txtbPassword.Focus();
                }

            }
        }

        #endregion

        #region METODO INICIAR SESION
        private async void iniciarSesion()
        {
            this.Enabled = false;
            client = new FireSharp.FirebaseClient(config);

            if (rootMode == false)
            {

                for (int i = 0; i < limiteusuario; i++)
                {
                    var data = await client.GetTaskAsync("USUARIOS/" + (i + 1));
                    if (data.Body != "null")
                    {
                        FirebaseResponse recuperacion = await client.GetTaskAsync("USUARIOS/" + (i + 1));
                        Usuario obj = recuperacion.ResultAs<Usuario>();
                        if(txtbUser.Text==obj.user)
                        {
                            if(txtbPassword.Text==obj.password)
                            {                                
                                Form VentanaMenu = new FormMenu(obj.username,rootMode);
                                VentanaMenu.Show();
                                this.Close();
                                acceso = true;

                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {

                    }

                }
                if(acceso!=true)
                {
                    MessageBox.Show("Acceso denegado, usuario o contraseña inválidos", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    txtbPassword.Clear();
                }
                
            }
            else
            {
                /*
                client = new FireSharp.FirebaseClient(config);
                var usuarioRoot = new UsuarioRoot
                {
                    userID = "1",
                    rootUser = txtbUser.Text,
                    password = txtbPassword.Text,
                    nombre = "Dr. MakiHero Martinez"
                };
                FirebaseResponse recuperacion = await client.SetTaskAsync("USUARIOSROOT/1",usuarioRoot);
                Usuario obj = recuperacion.ResultAs<Usuario>();
                */
                client = new FireSharp.FirebaseClient(config);
                var usuarioRoot = new UsuarioRoot
                {
                    userID = "1",
                    rootUser = txtbUser.Text,
                    password = txtbPassword.Text
                };
                FirebaseResponse recuperacion = await client.GetTaskAsync("USUARIOSROOT/1");
                UsuarioRoot obj = recuperacion.ResultAs<UsuarioRoot>();
                if (obj.rootUser == txtbUser.Text && obj.password == txtbPassword.Text)
                {
                    this.Close();
                    Form VentanaAdminMenu = new FormAdminMenu(obj.nombre, rootMode);
                    VentanaAdminMenu.Show();

                }
                else
                {
                    MessageBox.Show("Acceso denegado, usuario o contraseña inválidos", "ACCESO DENEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Enabled = true;
                    txtbPassword.Clear();
                }


            }
        }


        #endregion

        #region MODO
        private void btnRoot_Click(object sender, EventArgs e)
        {
            
            btnRow.Visible = false;
            btnRoot.Enabled = false;
            btnUser.Enabled = true;
            txtbUser.Enabled = true;
            txtbPassword.Enabled = true;
            Bitmap imgRoot = new Bitmap(Application.StartupPath + @"\..\..\IMG\Fondo\LoginRoot.jpg" );
            this.BackgroundImage = imgRoot;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            rootMode = true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnUser.Enabled = false;
            btnRoot.Enabled = true;
            Bitmap imgRoot = new Bitmap(Application.StartupPath + @"\..\..\IMG\Fondo\Login.jpg");
            this.BackgroundImage = imgRoot;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            rootMode = false;

        }
        #endregion

        private async void FormLogin_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            client = new FireSharp.FirebaseClient(config);

            var data = await client.GetTaskAsync("CONTADOR/usuarios");
            if (data.Body != "null")
            {
               
                this.Enabled = true;                
                FirebaseResponse recuperacion = await client.GetTaskAsync("CONTADOR/usuarios");
                Contador obj = recuperacion.ResultAs<Contador>();
                numerousuario = obj.cantidad;
                limiteusuario = obj.userlimite;                

            }
            else
            {
                this.Enabled = true;
                Form VentanaMensaje2 = new FormMensaje("A continuación tendrá que dar click en el botón indicado por la flecha (modo administrador) e inicie con su cuenta de administrador proporcionada", "OFTALMOL-GO", "OK", false, 2);
                Form VentanaMensaje = new FormMensaje("BIENVENIDO, Gracias por su preferencia","OFTALMOL-GO", "EMPEZAR",false,2);
                VentanaMensaje2.Show();
                VentanaMensaje.Show();
                txtbPassword.Enabled = false;
                txtbUser.Enabled = false;                
                btnRow.Visible = true;
                          
                
            }
        }
    }
}
