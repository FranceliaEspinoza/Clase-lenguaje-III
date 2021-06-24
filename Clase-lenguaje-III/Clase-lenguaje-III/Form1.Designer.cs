
namespace Clase_lenguaje_III
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DatoscomboBox = new System.Windows.Forms.ComboBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.edadTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ascbutton = new System.Windows.Forms.Button();
            this.descbutton = new System.Windows.Forms.Button();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatoscomboBox
            // 
            this.DatoscomboBox.FormattingEnabled = true;
            this.DatoscomboBox.Location = new System.Drawing.Point(429, 47);
            this.DatoscomboBox.Name = "DatoscomboBox";
            this.DatoscomboBox.Size = new System.Drawing.Size(170, 21);
            this.DatoscomboBox.TabIndex = 0;
            // 
            // IngresarButton
            // 
            this.IngresarButton.Location = new System.Drawing.Point(86, 265);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(101, 39);
            this.IngresarButton.TabIndex = 1;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(159, 35);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(172, 20);
            this.NombretextBox.TabIndex = 2;
            // 
            // edadTexBox
            // 
            this.edadTexBox.Location = new System.Drawing.Point(159, 85);
            this.edadTexBox.Name = "edadTexBox";
            this.edadTexBox.Size = new System.Drawing.Size(172, 20);
            this.edadTexBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el nombre del Alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edadTexBox);
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Location = new System.Drawing.Point(24, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.DatoscomboBox);
            this.groupBox2.Location = new System.Drawing.Point(30, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 194);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // Ascbutton
            // 
            this.Ascbutton.Location = new System.Drawing.Point(235, 265);
            this.Ascbutton.Name = "Ascbutton";
            this.Ascbutton.Size = new System.Drawing.Size(100, 39);
            this.Ascbutton.TabIndex = 8;
            this.Ascbutton.Text = "Ordenar ascendentes";
            this.Ascbutton.UseVisualStyleBackColor = true;
            this.Ascbutton.Click += new System.EventHandler(this.Ascbutton_Click);
            // 
            // descbutton
            // 
            this.descbutton.Location = new System.Drawing.Point(382, 265);
            this.descbutton.Name = "descbutton";
            this.descbutton.Size = new System.Drawing.Size(100, 39);
            this.descbutton.TabIndex = 9;
            this.descbutton.Text = "Ordenar descendente";
            this.descbutton.UseVisualStyleBackColor = true;
            this.descbutton.Click += new System.EventHandler(this.descbutton_Click);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Location = new System.Drawing.Point(529, 265);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(100, 39);
            this.limpiarbutton.TabIndex = 10;
            this.limpiarbutton.Text = "Limpiar";
            this.limpiarbutton.UseVisualStyleBackColor = true;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 370);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.descbutton);
            this.Controls.Add(this.Ascbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IngresarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DatoscomboBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox edadTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Ascbutton;
        private System.Windows.Forms.Button descbutton;
        private System.Windows.Forms.Button limpiarbutton;
    }
}

