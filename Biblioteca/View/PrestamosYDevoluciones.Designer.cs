
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PrestamoBoton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DevolucionBoton = new System.Windows.Forms.Button();
            this.GrillaPrestamos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.GrillaPrestamos.Location = new System.Drawing.Point(335, 27);
            this.GrillaPrestamos.Name = "GrillaPrestamos";
            this.GrillaPrestamos.ReadOnly = true;
            this.GrillaPrestamos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrillaPrestamos.Size = new System.Drawing.Size(291, 140);
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
            // PrestamosYDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrillaPrestamos);
            this.Controls.Add(this.DevolucionBoton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrestamoBoton);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PrestamoBoton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DevolucionBoton;
        private System.Windows.Forms.DataGridView GrillaPrestamos;
        private System.Windows.Forms.Button button1;
    }
}

