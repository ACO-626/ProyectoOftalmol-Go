namespace Oftalmol_Go
{
    partial class FormAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTabla = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.GridAgenda = new System.Windows.Forms.DataGridView();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTabla
            // 
            this.btnTabla.BackColor = System.Drawing.Color.White;
            this.btnTabla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTabla.BackgroundImage")));
            this.btnTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabla.Location = new System.Drawing.Point(0, 0);
            this.btnTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(729, 48);
            this.btnTabla.TabIndex = 0;
            this.btnTabla.UseVisualStyleBackColor = false;
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.White;
            this.btnCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendario.BackgroundImage")));
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.Location = new System.Drawing.Point(705, 0);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(732, 48);
            this.btnCalendario.TabIndex = 1;
            this.btnCalendario.UseVisualStyleBackColor = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // GridAgenda
            // 
            this.GridAgenda.AllowUserToAddRows = false;
            this.GridAgenda.AllowUserToDeleteRows = false;
            this.GridAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAgenda.BackgroundColor = System.Drawing.Color.White;
            this.GridAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFecha,
            this.ColumnHora,
            this.columnPaciente,
            this.ColumnTel});
            this.GridAgenda.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GridAgenda.Location = new System.Drawing.Point(28, 79);
            this.GridAgenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridAgenda.Name = "GridAgenda";
            this.GridAgenda.ReadOnly = true;
            this.GridAgenda.RowHeadersWidth = 15;
            this.GridAgenda.Size = new System.Drawing.Size(1363, 593);
            this.GridAgenda.TabIndex = 2;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnFecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnFecha.FillWeight = 203.0457F;
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.MinimumWidth = 6;
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFecha.Width = 150;
            // 
            // ColumnHora
            // 
            this.ColumnHora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHora.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnHora.FillWeight = 155.0491F;
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            this.ColumnHora.Width = 140;
            // 
            // columnPaciente
            // 
            this.columnPaciente.FillWeight = 20.95259F;
            this.columnPaciente.HeaderText = "Nombre";
            this.columnPaciente.MinimumWidth = 6;
            this.columnPaciente.Name = "columnPaciente";
            this.columnPaciente.ReadOnly = true;
            // 
            // ColumnTel
            // 
            this.ColumnTel.FillWeight = 20.95259F;
            this.ColumnTel.HeaderText = "Teléfono";
            this.ColumnTel.MinimumWidth = 6;
            this.ColumnTel.Name = "ColumnTel";
            this.ColumnTel.ReadOnly = true;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 743);
            this.Controls.Add(this.GridAgenda);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormAgenda";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.DataGridView GridAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTel;
    }
}