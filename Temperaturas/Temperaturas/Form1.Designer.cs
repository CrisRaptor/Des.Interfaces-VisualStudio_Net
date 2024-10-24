namespace Temperaturas
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
            this.termometro1 = new Clase1_Controles.Termometro();
            this.SuspendLayout();
            // 
            // termometro1
            // 
            this.termometro1.AutoSize = true;
            this.termometro1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.termometro1.Cachopo = 1;
            this.termometro1.Location = new System.Drawing.Point(514, 131);
            this.termometro1.Name = "termometro1";
            this.termometro1.Size = new System.Drawing.Size(153, 103);
            this.termometro1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.termometro1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase1_Controles.Termometro termometro1;
    }
}

