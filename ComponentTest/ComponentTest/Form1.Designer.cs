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
            this.chrono2 = new Chronometer.chrono();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chrono2
            // 
            this.chrono2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chrono2.BackColor = System.Drawing.Color.Transparent;
            this.chrono2.colorOff = System.Drawing.Color.Transparent;
            this.chrono2.colorOn = System.Drawing.Color.Red;
            this.chrono2.dotTicksRatio = 6;
            this.chrono2.Location = new System.Drawing.Point(9, 9);
            this.chrono2.Margin = new System.Windows.Forms.Padding(0);
            this.chrono2.MinimumSize = new System.Drawing.Size(540, 250);
            this.chrono2.Name = "chrono2";
            this.chrono2.Size = new System.Drawing.Size(540, 250);
            this.chrono2.TabIndex = 0;
            this.chrono2.TimeChange += new Chronometer.chrono.GetValuesEventHandler(this.chrono1_TimeChange);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(32, 271);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(899, 546);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chrono2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private textField.textField textField1;
        private Clase1_Controles.Termometro termometro2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox pictureBox;
        private pictureText.pictureText pictureText1;
        private System.Windows.Forms.DataGridView dataGridRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraRegistrada;
        private Chronometer.chrono chrono1;
        private Chronometer.chrono chrono2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

