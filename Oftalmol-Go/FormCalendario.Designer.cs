namespace Oftalmol_Go
{
    partial class FormCalendario
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbHora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(351, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(163, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(382, 264);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 45);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(80, 18);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(166, 22);
            this.txtbID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(80, 54);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(166, 22);
            this.txtbNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // txtbCorreo
            // 
            this.txtbCorreo.Location = new System.Drawing.Point(80, 93);
            this.txtbCorreo.Name = "txtbCorreo";
            this.txtbCorreo.Size = new System.Drawing.Size(166, 22);
            this.txtbCorreo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo:";
            // 
            // txtbHora
            // 
            this.txtbHora.Location = new System.Drawing.Point(80, 134);
            this.txtbHora.Name = "txtbHora";
            this.txtbHora.Size = new System.Drawing.Size(166, 22);
            this.txtbHora.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hora:";
            // 
            // txtbTel
            // 
            this.txtbTel.Location = new System.Drawing.Point(80, 176);
            this.txtbTel.Name = "txtbTel";
            this.txtbTel.Size = new System.Drawing.Size(166, 22);
            this.txtbTel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tel.";
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(22, 264);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(92, 45);
            this.btnAnt.TabIndex = 12;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(154, 264);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(92, 45);
            this.btnSig.TabIndex = 13;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(80, 216);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(166, 22);
            this.txtbEdad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edad:";
            // 
            // FormCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecha);
            this.Name = "FormCalendario";
            this.Text = "Calendario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label label6;
    }
}