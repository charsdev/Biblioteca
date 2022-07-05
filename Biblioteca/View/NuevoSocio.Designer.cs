
namespace Biblioteca.View
{
    partial class NuevoSocio
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
            this.components = new System.ComponentModel.Container();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelNumeroDeIdentificacion = new System.Windows.Forms.Label();
            this.LabelTipo = new System.Windows.Forms.Label();
            this.NumeroIdentificacionTextBox = new System.Windows.Forms.TextBox();
            this.VIP = new System.Windows.Forms.RadioButton();
            this.Comun = new System.Windows.Forms.RadioButton();
            this.BotonAñadir = new System.Windows.Forms.Button();
            this.BotonVolverAOperaciones = new System.Windows.Forms.Button();
            this.CuotaMensualLabel = new System.Windows.Forms.Label();
            this.CuotaMensualTextBox = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CuotaMensualTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(180, 25);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(122, 20);
            this.NombreTextBox.TabIndex = 0;
            this.NumeroIdentificacionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(180, 52);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(122, 20);
            this.ApellidoTextBox.TabIndex = 1;
            this.NumeroIdentificacionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(19, 25);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(44, 13);
            this.LabelNombre.TabIndex = 2;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Location = new System.Drawing.Point(19, 52);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(44, 13);
            this.LabelApellido.TabIndex = 3;
            this.LabelApellido.Text = "Apellido";
            // 
            // LabelNumeroDeIdentificacion
            // 
            this.LabelNumeroDeIdentificacion.AutoSize = true;
            this.LabelNumeroDeIdentificacion.Location = new System.Drawing.Point(19, 81);
            this.LabelNumeroDeIdentificacion.Name = "LabelNumeroDeIdentificacion";
            this.LabelNumeroDeIdentificacion.Size = new System.Drawing.Size(125, 13);
            this.LabelNumeroDeIdentificacion.TabIndex = 4;
            this.LabelNumeroDeIdentificacion.Text = "Número de Identificación";
            // 
            // LabelTipo
            // 
            this.LabelTipo.AutoSize = true;
            this.LabelTipo.Location = new System.Drawing.Point(21, 115);
            this.LabelTipo.Name = "LabelTipo";
            this.LabelTipo.Size = new System.Drawing.Size(28, 13);
            this.LabelTipo.TabIndex = 5;
            this.LabelTipo.Text = "Tipo";
            // 
            // NumeroIdentificacionTextBox
            // 
            this.NumeroIdentificacionTextBox.Location = new System.Drawing.Point(180, 78);
            this.NumeroIdentificacionTextBox.Name = "NumeroIdentificacionTextBox";
            this.NumeroIdentificacionTextBox.Size = new System.Drawing.Size(122, 20);
            this.NumeroIdentificacionTextBox.TabIndex = 6;
            this.NumeroIdentificacionTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // VIP
            // 
            this.VIP.AutoSize = true;
            this.VIP.Location = new System.Drawing.Point(244, 111);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(42, 17);
            this.VIP.TabIndex = 7;
            this.VIP.Text = "VIP";
            this.VIP.UseVisualStyleBackColor = true;
            this.VIP.CheckedChanged += new System.EventHandler(this.VipRadioButton_CheckedChanged);
            // 
            // Comun
            // 
            this.Comun.AutoSize = true;
            this.Comun.Checked = true;
            this.Comun.Location = new System.Drawing.Point(180, 111);
            this.Comun.Name = "Comun";
            this.Comun.Size = new System.Drawing.Size(58, 17);
            this.Comun.TabIndex = 8;
            this.Comun.TabStop = true;
            this.Comun.Text = "Común";
            this.Comun.UseVisualStyleBackColor = true;
            this.Comun.CheckedChanged += new System.EventHandler(this.ComunRadioButton_CheckedChanged);
            // 
            // BotonAñadir
            // 
            this.BotonAñadir.Enabled = false;
            this.BotonAñadir.Location = new System.Drawing.Point(233, 188);
            this.BotonAñadir.Name = "BotonAñadir";
            this.BotonAñadir.Size = new System.Drawing.Size(75, 23);
            this.BotonAñadir.TabIndex = 9;
            this.BotonAñadir.Text = "Añadir";
            this.BotonAñadir.UseVisualStyleBackColor = true;
            this.BotonAñadir.Click += new System.EventHandler(this.AñadirSocio);
            // 
            // BotonVolverAOperaciones
            // 
            this.BotonVolverAOperaciones.Location = new System.Drawing.Point(90, 188);
            this.BotonVolverAOperaciones.Name = "BotonVolverAOperaciones";
            this.BotonVolverAOperaciones.Size = new System.Drawing.Size(128, 23);
            this.BotonVolverAOperaciones.TabIndex = 10;
            this.BotonVolverAOperaciones.Text = "Volver a Operaciones";
            this.BotonVolverAOperaciones.UseVisualStyleBackColor = true;
            this.BotonVolverAOperaciones.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // CuotaMensualLabel
            // 
            this.CuotaMensualLabel.AutoSize = true;
            this.CuotaMensualLabel.Location = new System.Drawing.Point(21, 147);
            this.CuotaMensualLabel.Name = "CuotaMensualLabel";
            this.CuotaMensualLabel.Size = new System.Drawing.Size(77, 13);
            this.CuotaMensualLabel.TabIndex = 11;
            this.CuotaMensualLabel.Text = "Cuota mensual";
            // 
            // CuotaMensualTextBox
            // 
            this.CuotaMensualTextBox.Enabled = false;
            this.CuotaMensualTextBox.Location = new System.Drawing.Point(180, 145);
            this.CuotaMensualTextBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CuotaMensualTextBox.Name = "CuotaMensualTextBox";
            this.CuotaMensualTextBox.Size = new System.Drawing.Size(120, 20);
            this.CuotaMensualTextBox.TabIndex = 12;
            this.CuotaMensualTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);

            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NuevoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.CuotaMensualTextBox);
            this.Controls.Add(this.CuotaMensualLabel);
            this.Controls.Add(this.BotonVolverAOperaciones);
            this.Controls.Add(this.BotonAñadir);
            this.Controls.Add(this.Comun);
            this.Controls.Add(this.VIP);
            this.Controls.Add(this.NumeroIdentificacionTextBox);
            this.Controls.Add(this.LabelTipo);
            this.Controls.Add(this.LabelNumeroDeIdentificacion);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelNombre);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "NuevoSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Expres: Nuevo Socio";
            ((System.ComponentModel.ISupportInitialize)(this.CuotaMensualTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelNumeroDeIdentificacion;
        private System.Windows.Forms.Label LabelTipo;
        private System.Windows.Forms.TextBox NumeroIdentificacionTextBox;
        private System.Windows.Forms.RadioButton VIP;
        private System.Windows.Forms.RadioButton Comun;
        private System.Windows.Forms.Button BotonAñadir;
        private System.Windows.Forms.Button BotonVolverAOperaciones;
        private System.Windows.Forms.Label CuotaMensualLabel;
        private System.Windows.Forms.NumericUpDown CuotaMensualTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}