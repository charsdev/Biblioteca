namespace Biblioteca.View
{
    partial class EjemplaresDisponibles
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
            this.CodigoISBNTextbox = new System.Windows.Forms.TextBox();
            this.ObtenerEjemplaresDisponiblesBoton = new System.Windows.Forms.Button();
            this.GrillaDeEjemplares = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.volverAOperacionesBoton = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeEdicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroDeSocioLabel
            // 
            this.NumeroDeSocioLabel.AutoSize = true;
            this.NumeroDeSocioLabel.Location = new System.Drawing.Point(35, 30);
            this.NumeroDeSocioLabel.Name = "NumeroDeSocioLabel";
            this.NumeroDeSocioLabel.Size = new System.Drawing.Size(79, 13);
            this.NumeroDeSocioLabel.TabIndex = 0;
            this.NumeroDeSocioLabel.Text = "Código del libro";
            // 
            // CodigoISBNTextbox
            // 
            this.CodigoISBNTextbox.Location = new System.Drawing.Point(177, 27);
            this.CodigoISBNTextbox.Name = "CodigoISBNTextbox";
            this.CodigoISBNTextbox.Size = new System.Drawing.Size(112, 20);
            this.CodigoISBNTextbox.TabIndex = 1;
            this.CodigoISBNTextbox.TextChanged += new System.EventHandler(this.SocioTextBox_TextChanged);
            // 
            // ObtenerEjemplaresDisponiblesBoton
            // 
            this.ObtenerEjemplaresDisponiblesBoton.Enabled = false;
            this.ObtenerEjemplaresDisponiblesBoton.Location = new System.Drawing.Point(175, 70);
            this.ObtenerEjemplaresDisponiblesBoton.Name = "ObtenerEjemplaresDisponiblesBoton";
            this.ObtenerEjemplaresDisponiblesBoton.Size = new System.Drawing.Size(114, 52);
            this.ObtenerEjemplaresDisponiblesBoton.TabIndex = 5;
            this.ObtenerEjemplaresDisponiblesBoton.Text = "Obtener Ejemplares Disponibles";
            this.ObtenerEjemplaresDisponiblesBoton.UseVisualStyleBackColor = true;
            this.ObtenerEjemplaresDisponiblesBoton.Click += new System.EventHandler(this.ObtenerEjemplaresDisponiblesBoton_Click);
            // 
            // GrillaDeEjemplares
            // 
            this.GrillaDeEjemplares.AllowUserToAddRows = false;
            this.GrillaDeEjemplares.AllowUserToDeleteRows = false;
            this.GrillaDeEjemplares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaDeEjemplares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaDeEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Titulo,
            this.Ubicacion,
            this.NumeroDeEdicion});
            this.GrillaDeEjemplares.Location = new System.Drawing.Point(335, 12);
            this.GrillaDeEjemplares.Name = "GrillaDeEjemplares";
            this.GrillaDeEjemplares.ReadOnly = true;
            this.GrillaDeEjemplares.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrillaDeEjemplares.Size = new System.Drawing.Size(291, 140);
            this.GrillaDeEjemplares.TabIndex = 6;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(636, 187);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 8;
            // 
            // volverAOperacionesBoton
            // 
            this.volverAOperacionesBoton.Location = new System.Drawing.Point(38, 70);
            this.volverAOperacionesBoton.Name = "volverAOperacionesBoton";
            this.volverAOperacionesBoton.Size = new System.Drawing.Size(112, 52);
            this.volverAOperacionesBoton.TabIndex = 7;
            this.volverAOperacionesBoton.Text = "Volver a Operaciones";
            this.volverAOperacionesBoton.UseVisualStyleBackColor = true;
            this.volverAOperacionesBoton.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "N°";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // NumeroDeEdicion
            // 
            this.NumeroDeEdicion.HeaderText = "N° Edicion";
            this.NumeroDeEdicion.Name = "NumeroDeEdicion";
            this.NumeroDeEdicion.ReadOnly = true;
            // 
            // EjemplaresDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 168);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.volverAOperacionesBoton);
            this.Controls.Add(this.GrillaDeEjemplares);
            this.Controls.Add(this.ObtenerEjemplaresDisponiblesBoton);
            this.Controls.Add(this.CodigoISBNTextbox);
            this.Controls.Add(this.NumeroDeSocioLabel);
            this.Name = "EjemplaresDisponibles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Express: Ejemplares";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDeEjemplares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroDeSocioLabel;
        private System.Windows.Forms.TextBox CodigoISBNTextbox;
        private System.Windows.Forms.Button ObtenerEjemplaresDisponiblesBoton;
        private System.Windows.Forms.DataGridView GrillaDeEjemplares;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button volverAOperacionesBoton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeEdicion;
    }
}

