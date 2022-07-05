namespace Biblioteca.View
{
    partial class PrestamosYDevoluciones
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
            this.NumeroDeSocioLabel = new System.Windows.Forms.Label();
            this.socioTexbox = new System.Windows.Forms.TextBox();
            this.PrestamoBoton = new System.Windows.Forms.Button();
            this.LibroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DevolucionBoton = new System.Windows.Forms.Button();
            this.GrillaPrestamos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreyApellidoDelSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDelPrestamoDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroDeSocioLabel
            // 
            this.NumeroDeSocioLabel.AutoSize = true;
            this.NumeroDeSocioLabel.Location = new System.Drawing.Point(35, 30);
            this.NumeroDeSocioLabel.Name = "NumeroDeSocioLabel";
            this.NumeroDeSocioLabel.Size = new System.Drawing.Size(87, 13);
            this.NumeroDeSocioLabel.TabIndex = 0;
            this.NumeroDeSocioLabel.Text = "Número de socio";
            // 
            // socioTexbox
            // 
            this.socioTexbox.Location = new System.Drawing.Point(177, 27);
            this.socioTexbox.Name = "socioTexbox";
            this.socioTexbox.Size = new System.Drawing.Size(112, 20);
            this.socioTexbox.TabIndex = 1;
            this.socioTexbox.TextChanged += new System.EventHandler(this.SocioTextBox_TextChanged);
            // 
            // PrestamoBoton
            // 
            this.PrestamoBoton.Enabled = false;
            this.PrestamoBoton.Location = new System.Drawing.Point(175, 126);
            this.PrestamoBoton.Name = "PrestamoBoton";
            this.PrestamoBoton.Size = new System.Drawing.Size(112, 23);
            this.PrestamoBoton.TabIndex = 2;
            this.PrestamoBoton.Text = "Realizar Prestamo";
            this.PrestamoBoton.UseVisualStyleBackColor = true;
            this.PrestamoBoton.Click += new System.EventHandler(this.Prestar);
            // 
            // LibroTextBox
            // 
            this.LibroTextBox.Location = new System.Drawing.Point(177, 56);
            this.LibroTextBox.Name = "LibroTextBox";
            this.LibroTextBox.Size = new System.Drawing.Size(112, 20);
            this.LibroTextBox.TabIndex = 4;
            this.LibroTextBox.TextChanged += new System.EventHandler(this.LibroTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código del libro";
            // 
            // DevolucionBoton
            // 
            this.DevolucionBoton.Enabled = false;
            this.DevolucionBoton.Location = new System.Drawing.Point(175, 97);
            this.DevolucionBoton.Name = "DevolucionBoton";
            this.DevolucionBoton.Size = new System.Drawing.Size(114, 23);
            this.DevolucionBoton.TabIndex = 5;
            this.DevolucionBoton.Text = "Recibir Devolución";
            this.DevolucionBoton.UseVisualStyleBackColor = true;
            this.DevolucionBoton.Click += new System.EventHandler(this.Devolver);
            // 
            // GrillaPrestamos
            // 
            this.GrillaPrestamos.AllowUserToAddRows = false;
            this.GrillaPrestamos.AllowUserToDeleteRows = false;
            this.GrillaPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Tipo,
            this.CodigoISBN,
            this.NombreLibro,
            this.NumeroSocio,
            this.NombreyApellidoDelSocio,
            this.FechaDelPrestamoDevolucion});
            this.GrillaPrestamos.Location = new System.Drawing.Point(335, 27);
            this.GrillaPrestamos.Name = "GrillaPrestamos";
            this.GrillaPrestamos.ReadOnly = true;
            this.GrillaPrestamos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrillaPrestamos.Size = new System.Drawing.Size(911, 140);
            this.GrillaPrestamos.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Volver a Operaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "N°";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // CodigoISBN
            // 
            this.CodigoISBN.HeaderText = "Código ISBN";
            this.CodigoISBN.Name = "CodigoISBN";
            this.CodigoISBN.ReadOnly = true;
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "Nombre del Libro";
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.ReadOnly = true;
            // 
            // NumeroSocio
            // 
            this.NumeroSocio.HeaderText = "Nro° Socio";
            this.NumeroSocio.Name = "NumeroSocio";
            this.NumeroSocio.ReadOnly = true;
            // 
            // NombreyApellidoDelSocio
            // 
            this.NombreyApellidoDelSocio.HeaderText = "Nombre y Apellido del Socio";
            this.NombreyApellidoDelSocio.Name = "NombreyApellidoDelSocio";
            this.NombreyApellidoDelSocio.ReadOnly = true;
            // 
            // FechaDelPrestamoDevolucion
            // 
            this.FechaDelPrestamoDevolucion.HeaderText = "Fecha del Prestamo / Devolución";
            this.FechaDelPrestamoDevolucion.Name = "FechaDelPrestamoDevolucion";
            this.FechaDelPrestamoDevolucion.ReadOnly = true;
            // 
            // PrestamosYDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrillaPrestamos);
            this.Controls.Add(this.DevolucionBoton);
            this.Controls.Add(this.LibroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrestamoBoton);
            this.Controls.Add(this.socioTexbox);
            this.Controls.Add(this.NumeroDeSocioLabel);
            this.Name = "PrestamosYDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Express: Prestamos & Devoluciones";
            this.Load += new System.EventHandler(this.PrestamosYDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroDeSocioLabel;
        private System.Windows.Forms.TextBox socioTexbox;
        private System.Windows.Forms.Button PrestamoBoton;
        private System.Windows.Forms.TextBox LibroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DevolucionBoton;
        private System.Windows.Forms.DataGridView GrillaPrestamos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreyApellidoDelSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDelPrestamoDevolucion;
    }
}

