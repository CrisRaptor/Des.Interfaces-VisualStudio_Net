namespace Chronometer
{
    partial class chronometer
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
            this.components = new System.ComponentModel.Container();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.PictureBox();
            this.digit2 = new System.Windows.Forms.PictureBox();
            this.dots = new System.Windows.Forms.PictureBox();
            this.digit3 = new System.Windows.Forms.PictureBox();
            this.digit4 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(295, 0);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReset.MinimumSize = new System.Drawing.Size(80, 30);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 30);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(165, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.MinimumSize = new System.Drawing.Size(80, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 30);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // digit1
            // 
            this.digit1.Image = global::Chronometer.Properties.Resources.number_off;
            this.digit1.Location = new System.Drawing.Point(0, 30);
            this.digit1.Margin = new System.Windows.Forms.Padding(0);
            this.digit1.MinimumSize = new System.Drawing.Size(120, 220);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(120, 220);
            this.digit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit1.TabIndex = 3;
            this.digit1.TabStop = false;
            // 
            // digit2
            // 
            this.digit2.Image = global::Chronometer.Properties.Resources.number_off;
            this.digit2.Location = new System.Drawing.Point(125, 30);
            this.digit2.Margin = new System.Windows.Forms.Padding(0);
            this.digit2.MinimumSize = new System.Drawing.Size(120, 220);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(120, 220);
            this.digit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit2.TabIndex = 4;
            this.digit2.TabStop = false;
            // 
            // dots
            // 
            this.dots.Image = global::Chronometer.Properties.Resources.dots_on2;
            this.dots.Location = new System.Drawing.Point(250, 30);
            this.dots.Margin = new System.Windows.Forms.Padding(0);
            this.dots.MinimumSize = new System.Drawing.Size(40, 220);
            this.dots.Name = "dots";
            this.dots.Size = new System.Drawing.Size(40, 220);
            this.dots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dots.TabIndex = 5;
            this.dots.TabStop = false;
            // 
            // digit3
            // 
            this.digit3.Image = global::Chronometer.Properties.Resources.number_off;
            this.digit3.Location = new System.Drawing.Point(295, 30);
            this.digit3.Margin = new System.Windows.Forms.Padding(0);
            this.digit3.MinimumSize = new System.Drawing.Size(120, 220);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(120, 220);
            this.digit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit3.TabIndex = 6;
            this.digit3.TabStop = false;
            // 
            // digit4
            // 
            this.digit4.Image = global::Chronometer.Properties.Resources.number_off;
            this.digit4.Location = new System.Drawing.Point(420, 30);
            this.digit4.Margin = new System.Windows.Forms.Padding(0);
            this.digit4.MinimumSize = new System.Drawing.Size(120, 220);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(120, 220);
            this.digit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit4.TabIndex = 7;
            this.digit4.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chronometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.dots);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReset);
            this.Name = "chronometer";
            this.Size = new System.Drawing.Size(540, 250);
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox digit1;
        private System.Windows.Forms.PictureBox digit2;
        private System.Windows.Forms.PictureBox dots;
        private System.Windows.Forms.PictureBox digit3;
        private System.Windows.Forms.PictureBox digit4;
        private System.Windows.Forms.Timer timer;
    }
}
