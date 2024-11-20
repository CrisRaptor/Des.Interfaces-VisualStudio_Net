namespace Partido
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
            this.score1 = new System.Windows.Forms.TrackBar();
            this.score2 = new System.Windows.Forms.TrackBar();
            this.botonMasSegundo = new System.Windows.Forms.Button();
            this.botonMenosSegundo = new System.Windows.Forms.Button();
            this.parte = new System.Windows.Forms.ComboBox();
            this.labelCambiarParte = new System.Windows.Forms.Label();
            this.labelBotones = new System.Windows.Forms.Label();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.botonMenosMinuto = new System.Windows.Forms.Button();
            this.botonMasMinuto = new System.Windows.Forms.Button();
            this.partido = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.silbato = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marcador1 = new MarcadorFutbol.Marcador();
            ((System.ComponentModel.ISupportInitialize)(this.score1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silbato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // score1
            // 
            this.score1.AutoSize = false;
            this.score1.LargeChange = 1;
            this.score1.Location = new System.Drawing.Point(13, 52);
            this.score1.Margin = new System.Windows.Forms.Padding(0);
            this.score1.Maximum = 9;
            this.score1.Name = "score1";
            this.score1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.score1.Size = new System.Drawing.Size(151, 39);
            this.score1.TabIndex = 1;
            this.score1.ValueChanged += new System.EventHandler(this.score1_ValueChanged);
            // 
            // score2
            // 
            this.score2.AutoSize = false;
            this.score2.LargeChange = 1;
            this.score2.Location = new System.Drawing.Point(218, 52);
            this.score2.Margin = new System.Windows.Forms.Padding(0);
            this.score2.Maximum = 9;
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(151, 39);
            this.score2.TabIndex = 2;
            this.score2.ValueChanged += new System.EventHandler(this.score2_ValueChanged);
            // 
            // botonMasSegundo
            // 
            this.botonMasSegundo.Location = new System.Drawing.Point(634, 26);
            this.botonMasSegundo.Name = "botonMasSegundo";
            this.botonMasSegundo.Size = new System.Drawing.Size(30, 23);
            this.botonMasSegundo.TabIndex = 4;
            this.botonMasSegundo.Text = "+";
            this.botonMasSegundo.UseVisualStyleBackColor = true;
            this.botonMasSegundo.Click += new System.EventHandler(this.botonMasSegundo_Click);
            // 
            // botonMenosSegundo
            // 
            this.botonMenosSegundo.Location = new System.Drawing.Point(596, 26);
            this.botonMenosSegundo.Name = "botonMenosSegundo";
            this.botonMenosSegundo.Size = new System.Drawing.Size(32, 23);
            this.botonMenosSegundo.TabIndex = 5;
            this.botonMenosSegundo.Text = "-";
            this.botonMenosSegundo.UseVisualStyleBackColor = true;
            this.botonMenosSegundo.Click += new System.EventHandler(this.botonMenosSegundo_Click);
            // 
            // parte
            // 
            this.parte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parte.FormattingEnabled = true;
            this.parte.Items.AddRange(new object[] {
            "1ª Parte",
            "2ª Parte"});
            this.parte.Location = new System.Drawing.Point(674, 21);
            this.parte.Margin = new System.Windows.Forms.Padding(0);
            this.parte.Name = "parte";
            this.parte.Size = new System.Drawing.Size(126, 28);
            this.parte.TabIndex = 10;
            this.parte.SelectedIndexChanged += new System.EventHandler(this.parte_SelectedIndexChanged);
            // 
            // labelCambiarParte
            // 
            this.labelCambiarParte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCambiarParte.AutoSize = true;
            this.labelCambiarParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambiarParte.Location = new System.Drawing.Point(670, 1);
            this.labelCambiarParte.Name = "labelCambiarParte";
            this.labelCambiarParte.Size = new System.Drawing.Size(130, 20);
            this.labelCambiarParte.TabIndex = 12;
            this.labelCambiarParte.Text = "Cambiar Parte";
            // 
            // labelBotones
            // 
            this.labelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBotones.AutoSize = true;
            this.labelBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBotones.Location = new System.Drawing.Point(523, -1);
            this.labelBotones.Name = "labelBotones";
            this.labelBotones.Size = new System.Drawing.Size(141, 20);
            this.labelBotones.TabIndex = 14;
            this.labelBotones.Text = "Cambiar tiempo";
            // 
            // labelSegundos
            // 
            this.labelSegundos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundos.Location = new System.Drawing.Point(524, 29);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(69, 16);
            this.labelSegundos.TabIndex = 15;
            this.labelSegundos.Text = "Segundos";
            // 
            // labelMinutos
            // 
            this.labelMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutos.Location = new System.Drawing.Point(524, 55);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(53, 16);
            this.labelMinutos.TabIndex = 18;
            this.labelMinutos.Text = "Minutos";
            // 
            // botonMenosMinuto
            // 
            this.botonMenosMinuto.Location = new System.Drawing.Point(596, 52);
            this.botonMenosMinuto.Name = "botonMenosMinuto";
            this.botonMenosMinuto.Size = new System.Drawing.Size(32, 23);
            this.botonMenosMinuto.TabIndex = 17;
            this.botonMenosMinuto.Text = "-";
            this.botonMenosMinuto.UseVisualStyleBackColor = true;
            this.botonMenosMinuto.Click += new System.EventHandler(this.botonMenosMinuto_Click);
            // 
            // botonMasMinuto
            // 
            this.botonMasMinuto.Location = new System.Drawing.Point(634, 52);
            this.botonMasMinuto.Name = "botonMasMinuto";
            this.botonMasMinuto.Size = new System.Drawing.Size(30, 23);
            this.botonMasMinuto.TabIndex = 16;
            this.botonMasMinuto.Text = "+";
            this.botonMasMinuto.UseVisualStyleBackColor = true;
            this.botonMasMinuto.Click += new System.EventHandler(this.botonMasMinuto_Click);
            // 
            // partido
            // 
            this.partido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partido.AutoSize = true;
            this.partido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partido.Location = new System.Drawing.Point(567, 121);
            this.partido.Name = "partido";
            this.partido.Size = new System.Drawing.Size(198, 20);
            this.partido.TabIndex = 22;
            this.partido.Text = "COMENZAR PARTIDO";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(596, 300);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(150, 23);
            this.reset.TabIndex = 24;
            this.reset.Text = "Reiniciar partido";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // silbato
            // 
            this.silbato.Image = global::Partido.Properties.Resources.silbato_start;
            this.silbato.Location = new System.Drawing.Point(596, 144);
            this.silbato.Name = "silbato";
            this.silbato.Size = new System.Drawing.Size(150, 150);
            this.silbato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.silbato.TabIndex = 23;
            this.silbato.TabStop = false;
            this.silbato.Click += new System.EventHandler(this.silbato_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::Partido.Properties.Resources.cancha;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // marcador1
            // 
            this.marcador1.Goles1 = 1;
            this.marcador1.Goles2 = 0;
            this.marcador1.Location = new System.Drawing.Point(-5, -1);
            this.marcador1.Logo1 = global::Partido.Properties.Resources.malaga;
            this.marcador1.Logo2 = global::Partido.Properties.Resources.sevilla;
            this.marcador1.MinimumSize = new System.Drawing.Size(400, 50);
            this.marcador1.Name = "marcador1";
            this.marcador1.Nombre1 = "Malaga";
            this.marcador1.Nombre2 = "Sevilla";
            this.marcador1.Parte = 1;
            this.marcador1.Size = new System.Drawing.Size(525, 50);
            this.marcador1.TabIndex = 25;
            this.marcador1.Tiempo = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marcador1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.silbato);
            this.Controls.Add(this.partido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.botonMenosMinuto);
            this.Controls.Add(this.botonMasMinuto);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.labelBotones);
            this.Controls.Add(this.labelCambiarParte);
            this.Controls.Add(this.parte);
            this.Controls.Add(this.botonMenosSegundo);
            this.Controls.Add(this.botonMasSegundo);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Name = "Form1";
            this.Text = "Partido de Futbol";
            ((System.ComponentModel.ISupportInitialize)(this.score1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silbato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar score1;
        private System.Windows.Forms.TrackBar score2;
        private System.Windows.Forms.Button botonMasSegundo;
        private System.Windows.Forms.Button botonMenosSegundo;
        private System.Windows.Forms.ComboBox parte;
        private System.Windows.Forms.Label labelCambiarParte;
        private System.Windows.Forms.Label labelBotones;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Button botonMenosMinuto;
        private System.Windows.Forms.Button botonMasMinuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label partido;
        private System.Windows.Forms.PictureBox silbato;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button reset;
        private MarcadorFutbol.Marcador marcador1;
    }
}

