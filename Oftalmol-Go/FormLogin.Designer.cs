namespace Oftalmol_Go
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbLimpiar = new System.Windows.Forms.Label();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(737, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(308, 361);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(161, 56);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelar.ForeColor = System.Drawing.Color.IndianRed;
            this.lbCancelar.Location = new System.Drawing.Point(400, 420);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(48, 13);
            this.lbCancelar.TabIndex = 2;
            this.lbCancelar.Text = "Cancelar";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbLimpiar
            // 
            this.lbLimpiar.AutoSize = true;
            this.lbLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimpiar.ForeColor = System.Drawing.Color.Green;
            this.lbLimpiar.Location = new System.Drawing.Point(335, 420);
            this.lbLimpiar.Name = "lbLimpiar";
            this.lbLimpiar.Size = new System.Drawing.Size(40, 13);
            this.lbLimpiar.TabIndex = 3;
            this.lbLimpiar.Text = "Limpiar";
            this.lbLimpiar.Click += new System.EventHandler(this.lbLimpiar_Click);
            // 
            // txtbUser
            // 
            this.txtbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbUser.Font = new System.Drawing.Font("Simplex_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUser.Location = new System.Drawing.Point(261, 259);
            this.txtbUser.MaxLength = 40;
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(246, 23);
            this.txtbUser.TabIndex = 4;
            this.txtbUser.Text = "USUARIO";
            this.txtbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbUser.WordWrap = false;
            this.txtbUser.Enter += new System.EventHandler(this.txtbUser_Enter);
            this.txtbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbUser_KeyPress);
            this.txtbUser.Leave += new System.EventHandler(this.txtbUser_Leave);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPassword.Font = new System.Drawing.Font("Simplex_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPassword.Location = new System.Drawing.Point(261, 305);
            this.txtbPassword.MaxLength = 40;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(246, 23);
            this.txtbPassword.TabIndex = 5;
            this.txtbPassword.Text = "CONTRASEÑA";
            this.txtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPassword.WordWrap = false;
            this.txtbPassword.Enter += new System.EventHandler(this.txtbPassword_Enter);
            this.txtbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPassword_KeyPress);
            this.txtbPassword.Leave += new System.EventHandler(this.txtbPassword_Leave);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(720, 437);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(36, 32);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.Transparent;
            this.btnRoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoot.BackgroundImage")));
            this.btnRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoot.FlatAppearance.BorderSize = 0;
            this.btnRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Location = new System.Drawing.Point(721, 284);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(35, 32);
            this.btnRoot.TabIndex = 7;
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(720, 221);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(36, 32);
            this.btnUser.TabIndex = 8;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnRow
            // 
            this.btnRow.BackColor = System.Drawing.Color.Transparent;
            this.btnRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRow.BackgroundImage")));
            this.btnRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRow.Enabled = false;
            this.btnRow.FlatAppearance.BorderSize = 0;
            this.btnRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRow.Location = new System.Drawing.Point(482, 204);
            this.btnRow.Name = "btnRow";
            this.btnRow.Size = new System.Drawing.Size(233, 173);
            this.btnRow.TabIndex = 9;
            this.btnRow.UseVisualStyleBackColor = false;
            this.btnRow.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 481);
            this.Controls.Add(this.btnRow);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.lbLimpiar);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Label lbLimpiar;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnRow;
    }
}