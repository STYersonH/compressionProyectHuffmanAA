namespace FileCompressionTool
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvArchivos = new System.Windows.Forms.DataGridView();
            this.cnArchivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnEnviarArchivo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvArchivos);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnEnviarArchivo);
            this.panel2.Location = new System.Drawing.Point(124, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 352);
            this.panel2.TabIndex = 10;
            // 
            // dgvArchivos
            // 
            this.dgvArchivos.AllowUserToAddRows = false;
            this.dgvArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArchivos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnArchivos});
            this.dgvArchivos.Location = new System.Drawing.Point(20, 83);
            this.dgvArchivos.Name = "dgvArchivos";
            this.dgvArchivos.RowTemplate.Height = 25;
            this.dgvArchivos.Size = new System.Drawing.Size(499, 150);
            this.dgvArchivos.TabIndex = 7;
            // 
            // cnArchivos
            // 
            this.cnArchivos.HeaderText = "Archivos";
            this.cnArchivos.Name = "cnArchivos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.LightBlue;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(331, 284);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(188, 39);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnEnviarArchivo
            // 
            this.btnEnviarArchivo.BackColor = System.Drawing.Color.LightBlue;
            this.btnEnviarArchivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnviarArchivo.Location = new System.Drawing.Point(31, 40);
            this.btnEnviarArchivo.Name = "btnEnviarArchivo";
            this.btnEnviarArchivo.Size = new System.Drawing.Size(114, 28);
            this.btnEnviarArchivo.TabIndex = 4;
            this.btnEnviarArchivo.Text = "Elegir archivo";
            this.btnEnviarArchivo.UseVisualStyleBackColor = false;
            this.btnEnviarArchivo.Click += new System.EventHandler(this.btnEnviarArchivo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(76, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 304);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 298);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(786, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnArchivos;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnEnviarArchivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}