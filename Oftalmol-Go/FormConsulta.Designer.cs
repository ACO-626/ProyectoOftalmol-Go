namespace Oftalmol_Go
{
    partial class FormConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.btnConsultaListo = new System.Windows.Forms.Button();
            this.comboAño = new System.Windows.Forms.ComboBox();
            this.comboMes = new System.Windows.Forms.ComboBox();
            this.comboDia = new System.Windows.Forms.ComboBox();
            this.comboHora = new System.Windows.Forms.ComboBox();
            this.comboMin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConsultaListo
            // 
            this.btnConsultaListo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnConsultaListo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultaListo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaListo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultaListo.FlatAppearance.BorderSize = 3;
            this.btnConsultaListo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultaListo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultaListo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaListo.ForeColor = System.Drawing.Color.White;
            this.btnConsultaListo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultaListo.Location = new System.Drawing.Point(236, 273);
            this.btnConsultaListo.Name = "btnConsultaListo";
            this.btnConsultaListo.Size = new System.Drawing.Size(145, 60);
            this.btnConsultaListo.TabIndex = 37;
            this.btnConsultaListo.Text = "LISTO";
            this.btnConsultaListo.UseVisualStyleBackColor = false;
            this.btnConsultaListo.Click += new System.EventHandler(this.btnConsultaListo_Click);
            // 
            // comboAño
            // 
            this.comboAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAño.FormattingEnabled = true;
            this.comboAño.Location = new System.Drawing.Point(77, 105);
            this.comboAño.Name = "comboAño";
            this.comboAño.Size = new System.Drawing.Size(124, 33);
            this.comboAño.TabIndex = 38;
            this.comboAño.SelectedIndexChanged += new System.EventHandler(this.comboAño_SelectedIndexChanged);
            // 
            // comboMes
            // 
            this.comboMes.Enabled = false;
            this.comboMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMes.FormattingEnabled = true;
            this.comboMes.Location = new System.Drawing.Point(247, 105);
            this.comboMes.Name = "comboMes";
            this.comboMes.Size = new System.Drawing.Size(124, 33);
            this.comboMes.TabIndex = 39;
            this.comboMes.SelectedIndexChanged += new System.EventHandler(this.comboMes_SelectedIndexChanged);
            // 
            // comboDia
            // 
            this.comboDia.Enabled = false;
            this.comboDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDia.FormattingEnabled = true;
            this.comboDia.Location = new System.Drawing.Point(421, 105);
            this.comboDia.Name = "comboDia";
            this.comboDia.Size = new System.Drawing.Size(124, 33);
            this.comboDia.TabIndex = 40;
            this.comboDia.SelectedIndexChanged += new System.EventHandler(this.comboDia_SelectedIndexChanged);
            // 
            // comboHora
            // 
            this.comboHora.Enabled = false;
            this.comboHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHora.FormattingEnabled = true;
            this.comboHora.Location = new System.Drawing.Point(147, 205);
            this.comboHora.Name = "comboHora";
            this.comboHora.Size = new System.Drawing.Size(124, 33);
            this.comboHora.TabIndex = 41;
            this.comboHora.SelectedIndexChanged += new System.EventHandler(this.comboHora_SelectedIndexChanged);
            // 
            // comboMin
            // 
            this.comboMin.Enabled = false;
            this.comboMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMin.FormattingEnabled = true;
            this.comboMin.Location = new System.Drawing.Point(342, 205);
            this.comboMin.Name = "comboMin";
            this.comboMin.Size = new System.Drawing.Size(124, 33);
            this.comboMin.TabIndex = 42;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(613, 345);
            this.ControlBox = false;
            this.Controls.Add(this.comboMin);
            this.Controls.Add(this.comboHora);
            this.Controls.Add(this.comboDia);
            this.Controls.Add(this.comboMes);
            this.Controls.Add(this.comboAño);
            this.Controls.Add(this.btnConsultaListo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA RÁPIDA";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaListo;
        private System.Windows.Forms.ComboBox comboAño;
        private System.Windows.Forms.ComboBox comboMes;
        private System.Windows.Forms.ComboBox comboDia;
        private System.Windows.Forms.ComboBox comboHora;
        private System.Windows.Forms.ComboBox comboMin;
    }
}