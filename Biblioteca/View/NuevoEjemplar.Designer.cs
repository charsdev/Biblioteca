
namespace Biblioteca.View
{
    partial class NuevoEjemplar
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoISBNTextBox = new System.Windows.Forms.TextBox();
            this.UbicacionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TexboxEdicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Volver a Operaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(237, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AñadirEjemplar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código ISBN";
            // 
            // CodigoISBNTextBox
            // 
            this.CodigoISBNTextBox.Location = new System.Drawing.Point(189, 29);
            this.CodigoISBNTextBox.Name = "CodigoISBNTextBox";
            this.CodigoISBNTextBox.Size = new System.Drawing.Size(122, 20);
            this.CodigoISBNTextBox.TabIndex = 19;
            this.CodigoISBNTextBox.TextChanged += new System.EventHandler(this.CodigoISBNTextBox_TextChanged);
            // 
            // UbicacionTextBox
            // 
            this.UbicacionTextBox.Location = new System.Drawing.Point(189, 56);
            this.UbicacionTextBox.Name = "UbicacionTextBox";
            this.UbicacionTextBox.Size = new System.Drawing.Size(122, 20);
            this.UbicacionTextBox.TabIndex = 20;
            this.UbicacionTextBox.TextChanged += new System.EventHandler(this.UbicacionTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ubicación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Edición";
            // 
            // TexboxEdicion
            // 
            this.TexboxEdicion.Location = new System.Drawing.Point(190, 85);
            this.TexboxEdicion.Name = "TexboxEdicion";
            this.TexboxEdicion.Size = new System.Drawing.Size(122, 20);
            this.TexboxEdicion.TabIndex = 27;
            this.TexboxEdicion.TextChanged += new System.EventHandler(this.TexboxEdicion_TextChanged);
            // 
            // NuevoEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TexboxEdicion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UbicacionTextBox);
            this.Controls.Add(this.CodigoISBNTextBox);
            this.Name = "NuevoEjemplar";
            this.Text = "Biblioteca Express : Nuevo Ejemplar";
            this.Load += new System.EventHandler(this.NuevoEjemplar_Load);
            this.Deactivate += new System.EventHandler(this.NuevoEjemplar_Unload);

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoISBNTextBox;
        private System.Windows.Forms.TextBox UbicacionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TexboxEdicion;
    }
}