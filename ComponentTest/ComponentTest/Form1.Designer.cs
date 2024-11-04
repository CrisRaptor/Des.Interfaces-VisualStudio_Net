namespace ComponentTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textField1 = new textField.textField();
            this.termometro2 = new Clase1_Controles.Termometro();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureText1 = new pictureText.pictureText();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textField1
            // 
            this.textField1.AutoSize = true;
            this.textField1.CharacterLimit = 50;
            this.textField1.Location = new System.Drawing.Point(22, 174);
            this.textField1.Name = "textField1";
            this.textField1.Position = textField.positions.Top;
            this.textField1.Size = new System.Drawing.Size(337, 41);
            this.textField1.TabIndex = 1;
            this.textField1.TextLeft = "Name";
            // 
            // termometro2
            // 
            this.termometro2.AutoSize = true;
            this.termometro2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.termometro2.Location = new System.Drawing.Point(12, 12);
            this.termometro2.Maximum = 5;
            this.termometro2.Name = "termometro2";
            this.termometro2.Size = new System.Drawing.Size(153, 103);
            this.termometro2.TabIndex = 2;
            this.termometro2.Value = 1;
            this.termometro2.ValueChange += new System.EventHandler(this.termometro2_ValueChange);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ComponentTest.Properties.Resources.house_simple;
            this.pictureBox.Location = new System.Drawing.Point(195, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 103);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // pictureText1
            // 
            this.pictureText1.AutoSize = true;
            this.pictureText1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pictureText1.Color = System.Drawing.SystemColors.ControlText;
            this.pictureText1.Fuente = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureText1.Imagen = ((System.Drawing.Image)(resources.GetObject("pictureText1.Imagen")));
            this.pictureText1.Leyenda = "Description";
            this.pictureText1.Location = new System.Drawing.Point(22, 282);
            this.pictureText1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureText1.Name = "pictureText1";
            this.pictureText1.Size = new System.Drawing.Size(166, 116);
            this.pictureText1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureText1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.termometro2);
            this.Controls.Add(this.textField1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private textField.textField textField1;
        private Clase1_Controles.Termometro termometro2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox;
        private pictureText.pictureText pictureText1;
    }
}

