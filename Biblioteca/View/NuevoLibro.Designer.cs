
namespace Biblioteca.View
{
    partial class NuevoLibro
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
            this.button2 = new System.Windows.Forms.Button();
            this.BotonNuevoLibro = new System.Windows.Forms.Button();
            this.CodigoISBNTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AutorTextBox = new System.Windows.Forms.TextBox();
            this.TituloTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Volver a Operaciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.VolverAOperaciones);
            // 
            // button1
            // 
            this.BotonNuevoLibro.Enabled = false;
            this.BotonNuevoLibro.Location = new System.Drawing.Point(246, 150);
            this.BotonNuevoLibro.Name = "button1";
            this.BotonNuevoLibro.Size = new System.Drawing.Size(75, 23);
            this.BotonNuevoLibro.TabIndex = 17;
            this.BotonNuevoLibro.Text = "Añadir";
            this.BotonNuevoLibro.UseVisualStyleBackColor = true;
            this.BotonNuevoLibro.Click += new System.EventHandler(this.AñadirLibro);
            // 
            // CodigoISBNTextBox
            // 
            this.CodigoISBNTextBox.Location = new System.Drawing.Point(191, 83);
            this.CodigoISBNTextBox.Name = "CodigoISBNTextBox";
            this.CodigoISBNTextBox.Size = new System.Drawing.Size(122, 20);
            this.CodigoISBNTextBox.TabIndex = 16;
            this.CodigoISBNTextBox.TextChanged += new System.EventHandler(this.CodigoISBNTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Título";
            // 
            // AutorTextBox
            // 
            this.AutorTextBox.Location = new System.Drawing.Point(191, 57);
            this.AutorTextBox.Name = "AutorTextBox";
            this.AutorTextBox.Size = new System.Drawing.Size(122, 20);
            this.AutorTextBox.TabIndex = 12;
            this.AutorTextBox.TextChanged += new System.EventHandler(this.AutorTextBox_TextChanged);
            // 
            // TituloTextBox
            // 
            this.TituloTextBox.Location = new System.Drawing.Point(191, 30);
            this.TituloTextBox.Name = "TituloTextBox";
            this.TituloTextBox.Size = new System.Drawing.Size(122, 20);
            this.TituloTextBox.TabIndex = 11;
            this.TituloTextBox.TextChanged += new System.EventHandler(this.TituloTextBox_TextChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NuevoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 188);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BotonNuevoLibro);
            this.Controls.Add(this.CodigoISBNTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutorTextBox);
            this.Controls.Add(this.TituloTextBox);
            this.Name = "NuevoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Express: Nuevo Libro";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BotonNuevoLibro;
        private System.Windows.Forms.TextBox CodigoISBNTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AutorTextBox;
        private System.Windows.Forms.TextBox TituloTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}