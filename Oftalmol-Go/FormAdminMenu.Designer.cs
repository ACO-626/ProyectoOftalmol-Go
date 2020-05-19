namespace Oftalmol_Go
{
    partial class FormAdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            this.btnUsuarios = new System.Windows.Forms.PictureBox();
            this.btnCitas = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbSimpleCitas = new System.Windows.Forms.Label();
            this.lbSimpleUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Location = new System.Drawing.Point(92, 137);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(319, 472);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.TabStop = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCitas.BackgroundImage")));
            this.btnCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCitas.Location = new System.Drawing.Point(451, 137);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(322, 472);
            this.btnCitas.TabIndex = 1;
            this.btnCitas.TabStop = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(1194, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 76);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(21, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(52, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbSimpleCitas
            // 
            this.lbSimpleCitas.AutoSize = true;
            this.lbSimpleCitas.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleCitas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbSimpleCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSimpleCitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleCitas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSimpleCitas.Location = new System.Drawing.Point(571, 629);
            this.lbSimpleCitas.Name = "lbSimpleCitas";
            this.lbSimpleCitas.Size = new System.Drawing.Size(83, 29);
            this.lbSimpleCitas.TabIndex = 5;
            this.lbSimpleCitas.Text = "CITAS";
            // 
            // lbSimpleUsuarios
            // 
            this.lbSimpleUsuarios.AutoSize = true;
            this.lbSimpleUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lbSimpleUsuarios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbSimpleUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSimpleUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSimpleUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSimpleUsuarios.Location = new System.Drawing.Point(184, 629);
            this.lbSimpleUsuarios.Name = "lbSimpleUsuarios";
            this.lbSimpleUsuarios.Size = new System.Drawing.Size(136, 29);
            this.lbSimpleUsuarios.TabIndex = 6;
            this.lbSimpleUsuarios.Text = "USUARIOS";
            // 
            // FormAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.lbSimpleUsuarios);
            this.Controls.Add(this.lbSimpleCitas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.btnUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÚ ADMINISTRADOR";
            ((System.ComponentModel.ISupportInitialize)(this.btnUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnUsuarios;
        private System.Windows.Forms.PictureBox btnCitas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lbSimpleCitas;
        private System.Windows.Forms.Label lbSimpleUsuarios;
    }
}