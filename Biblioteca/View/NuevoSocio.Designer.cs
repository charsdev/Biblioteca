
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
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeroIdentificacionTextBox = new System.Windows.Forms.TextBox();
            this.VIP = new System.Windows.Forms.RadioButton();
            this.Comun = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CuotaMensualTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(180, 25);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(122, 20);
            this.NombreTextBox.TabIndex = 0;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(180, 52);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(122, 20);
            this.ApellidoTextBox.TabIndex = 1;
            this.ApellidoTextBox.TextChanged += new System.EventHandler(this.ApellidoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de Identificación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo";
            // 
            // NumeroIdentificacionTextBox
            // 
            this.NumeroIdentificacionTextBox.Location = new System.Drawing.Point(180, 78);
            this.NumeroIdentificacionTextBox.Name = "NumeroIdentificacionTextBox";
            this.NumeroIdentificacionTextBox.Size = new System.Drawing.Size(122, 20);
            this.NumeroIdentificacionTextBox.TabIndex = 6;
            this.NumeroIdentificacionTextBox.TextChanged += new System.EventHandler(this.NumeroIdentificacionTextBox_TextChanged);
            // 
            // VIP
            // 
            this.VIP.AutoSize = true;
            this.VIP.Location = new System.Drawing.Point(198, 111);
            this.VIP.Name = "VIP";
            this.VIP.Size = new System.Drawing.Size(42, 17);
            this.VIP.TabIndex = 7;
            this.VIP.TabStop = true;
            this.VIP.Text = "VIP";
            this.VIP.UseVisualStyleBackColor = true;
            this.VIP.CheckedChanged += new System.EventHandler(this.VipRadioButton_CheckedChanged);
            // 
            // Comun
            // 
            this.Comun.AutoSize = true;
            this.Comun.Location = new System.Drawing.Point(244, 111);
            this.Comun.Name = "Comun";
            this.Comun.Size = new System.Drawing.Size(58, 17);
            this.Comun.TabIndex = 8;
            this.Comun.TabStop = true;
            this.Comun.Text = "Común";
            this.Comun.UseVisualStyleBackColor = true;
            this.Comun.CheckedChanged += new System.EventHandler(this.ComunRadioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(233, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AñadirSocio);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Volver a Operaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // CuotaMensualTextBox
            // 
            this.CuotaMensualTextBox.Enabled = false;
            this.CuotaMensualTextBox.Location = new System.Drawing.Point(182, 144);
            this.CuotaMensualTextBox.Name = "CuotaMensualTextBox";
            this.CuotaMensualTextBox.Size = new System.Drawing.Size(122, 20);
            this.CuotaMensualTextBox.TabIndex = 12;
            this.CuotaMensualTextBox.TextChanged += new System.EventHandler(this.CuotaMensualTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cuota mensual";
            // 
            // NuevoSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.CuotaMensualTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Comun);
            this.Controls.Add(this.VIP);
            this.Controls.Add(this.NumeroIdentificacionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "NuevoSocio";
            this.Text = "Biblioteca Expres: Nuevo Socio";
            this.Load += new System.EventHandler(this.NuevoSocio_Load);
            this.Deactivate += new System.EventHandler(this.NuevoSocio_Unload);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumeroIdentificacionTextBox;
        private System.Windows.Forms.RadioButton VIP;
        private System.Windows.Forms.RadioButton Comun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CuotaMensualTextBox;
        private System.Windows.Forms.Label label5;
    }
}