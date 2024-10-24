namespace Clase1_Controles
{
    partial class Termometro
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.temperatura = new System.Windows.Forms.TrackBar();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.temperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // temperatura
            // 
            this.temperatura.LargeChange = 1;
            this.temperatura.Location = new System.Drawing.Point(0, 0);
            this.temperatura.Margin = new System.Windows.Forms.Padding(0);
            this.temperatura.Maximum = 5;
            this.temperatura.Minimum = 1;
            this.temperatura.Name = "temperatura";
            this.temperatura.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.temperatura.Size = new System.Drawing.Size(56, 100);
            this.temperatura.TabIndex = 0;
            this.temperatura.Value = 1;
            this.temperatura.ValueChanged += new System.EventHandler(this.temperatura_ValueChanged);
            // 
            // imagen
            // 
            this.imagen.Image = global::Clase1_Controles.Properties.Resources.hielo;
            this.imagen.Location = new System.Drawing.Point(50, 0);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(100, 100);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 1;
            this.imagen.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Termometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.temperatura);
            this.Name = "Termometro";
            this.Size = new System.Drawing.Size(153, 103);
            ((System.ComponentModel.ISupportInitialize)(this.temperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar temperatura;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
