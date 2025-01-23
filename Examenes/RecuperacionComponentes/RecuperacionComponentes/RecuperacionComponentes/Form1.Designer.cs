namespace RecuperacionComponentes
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
            this.button_cargar = new System.Windows.Forms.Button();
            this.textBox_longest_word = new System.Windows.Forms.TextBox();
            this.label_longest_word = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer_parpadeo = new System.Windows.Forms.Timer(this.components);
            this.timer_stop = new System.Windows.Forms.Timer(this.components);
            this.listaPalabras1 = new RecuperacionComponentes.ListaPalabras();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cargar
            // 
            this.button_cargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cargar.Location = new System.Drawing.Point(436, 9);
            this.button_cargar.Name = "button_cargar";
            this.button_cargar.Size = new System.Drawing.Size(75, 42);
            this.button_cargar.TabIndex = 2;
            this.button_cargar.Text = "Cargar";
            this.button_cargar.UseVisualStyleBackColor = true;
            this.button_cargar.Click += new System.EventHandler(this.button_cargar_Click);
            // 
            // textBox_longest_word
            // 
            this.textBox_longest_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_longest_word.Location = new System.Drawing.Point(223, 29);
            this.textBox_longest_word.Name = "textBox_longest_word";
            this.textBox_longest_word.Size = new System.Drawing.Size(207, 22);
            this.textBox_longest_word.TabIndex = 3;
            // 
            // label_longest_word
            // 
            this.label_longest_word.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_longest_word.AutoSize = true;
            this.label_longest_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_longest_word.Location = new System.Drawing.Point(220, 9);
            this.label_longest_word.Name = "label_longest_word";
            this.label_longest_word.Size = new System.Drawing.Size(210, 16);
            this.label_longest_word.TabIndex = 4;
            this.label_longest_word.Text = "Palabra más larga registrada";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::RecuperacionComponentes.Properties.Resources.palabra_registrada;
            this.pictureBox.Location = new System.Drawing.Point(223, 129);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(137, 83);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // timer_parpadeo
            // 
            this.timer_parpadeo.Interval = 350;
            this.timer_parpadeo.Tick += new System.EventHandler(this.timer_parpadeo_Tick);
            // 
            // timer_stop
            // 
            this.timer_stop.Interval = 2000;
            this.timer_stop.Tick += new System.EventHandler(this.timer_stop_Tick);
            // 
            // listaPalabras1
            // 
            this.listaPalabras1.Location = new System.Drawing.Point(12, 9);
            this.listaPalabras1.Max_Items = 10;
            this.listaPalabras1.Max_Length = 20;
            this.listaPalabras1.Name = "listaPalabras1";
            this.listaPalabras1.Size = new System.Drawing.Size(169, 203);
            this.listaPalabras1.Slider_Background = System.Drawing.SystemColors.Control;
            this.listaPalabras1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(523, 243);
            this.Controls.Add(this.listaPalabras1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label_longest_word);
            this.Controls.Add(this.textBox_longest_word);
            this.Controls.Add(this.button_cargar);
            this.Name = "Form1";
            this.Text = "Lista de Palabras";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_cargar;
        private System.Windows.Forms.TextBox textBox_longest_word;
        private System.Windows.Forms.Label label_longest_word;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer_parpadeo;
        private System.Windows.Forms.Timer timer_stop;
        private ListaPalabras listaPalabras1;
    }
}

