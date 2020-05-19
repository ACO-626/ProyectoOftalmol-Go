namespace Oftalmol_Go
{
    partial class FormMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensaje));
            this.btnbtn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbCancelar = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbtn
            // 
            this.btnbtn.BackColor = System.Drawing.Color.Transparent;
            this.btnbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbtn.BackgroundImage")));
            this.btnbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbtn.FlatAppearance.BorderSize = 0;
            this.btnbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbtn.Location = new System.Drawing.Point(122, 170);
            this.btnbtn.Name = "btnbtn";
            this.btnbtn.Size = new System.Drawing.Size(237, 56);
            this.btnbtn.TabIndex = 35;
            this.btnbtn.UseVisualStyleBackColor = false;
            this.btnbtn.Click += new System.EventHandler(this.btnbtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(443, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 39);
            this.btnClose.TabIndex = 36;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCancelar
            // 
            this.lbCancelar.AllowDrop = true;
            this.lbCancelar.AutoSize = true;
            this.lbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCancelar.Location = new System.Drawing.Point(202, 229);
            this.lbCancelar.Name = "lbCancelar";
            this.lbCancelar.Size = new System.Drawing.Size(89, 17);
            this.lbCancelar.TabIndex = 39;
            this.lbCancelar.Text = "CANCELAR";
            this.lbCancelar.Click += new System.EventHandler(this.lbCancelar_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTitle.FlatAppearance.BorderSize = 0;
            this.lbTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTitle.Location = new System.Drawing.Point(57, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(380, 56);
            this.lbTitle.TabIndex = 41;
            this.lbTitle.Text = "MENSAJE";
            this.lbTitle.UseVisualStyleBackColor = false;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AllowDrop = true;
            this.lbMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lbMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMensaje.ForeColor = System.Drawing.Color.Black;
            this.lbMensaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMensaje.Location = new System.Drawing.Point(12, 76);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(458, 67);
            this.lbMensaje.TabIndex = 42;
            this.lbMensaje.Text = "Mensaje";
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMensaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(482, 260);
            this.ControlBox = false;
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbCancelar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMensaje";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbtn;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbCancelar;
        private System.Windows.Forms.Button lbTitle;
        private System.Windows.Forms.Label lbMensaje;
    }
}