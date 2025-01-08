namespace InformeCiudades
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonMostrarCiudades = new System.Windows.Forms.Button();
            this.groupTimeZone = new System.Windows.Forms.GroupBox();
            this.buttonResetZonaHoraria = new System.Windows.Forms.Button();
            this.radioChicago = new System.Windows.Forms.RadioButton();
            this.radioLosAngeles = new System.Windows.Forms.RadioButton();
            this.radioNewYork = new System.Windows.Forms.RadioButton();
            this.checkBoxCiudadesGrandes = new System.Windows.Forms.CheckBox();
            this.labelCiudadesGrandes = new System.Windows.Forms.Label();
            this.labelBuscarCiudad = new System.Windows.Forms.Label();
            this.textBoxBuscarCiudad = new System.Windows.Forms.TextBox();
            this.comboBoxDatos = new System.Windows.Forms.ComboBox();
            this.labelDatos = new System.Windows.Forms.Label();
            this.groupTimeZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(221, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Ciudades americanas";
            // 
            // buttonMostrarCiudades
            // 
            this.buttonMostrarCiudades.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMostrarCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarCiudades.Location = new System.Drawing.Point(60, 218);
            this.buttonMostrarCiudades.Name = "buttonMostrarCiudades";
            this.buttonMostrarCiudades.Size = new System.Drawing.Size(180, 23);
            this.buttonMostrarCiudades.TabIndex = 1;
            this.buttonMostrarCiudades.Text = "Mostrar las ciudades";
            this.buttonMostrarCiudades.UseVisualStyleBackColor = true;
            this.buttonMostrarCiudades.Click += new System.EventHandler(this.buttonMostrarCiudades_Click);
            // 
            // groupTimeZone
            // 
            this.groupTimeZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupTimeZone.Controls.Add(this.buttonResetZonaHoraria);
            this.groupTimeZone.Controls.Add(this.radioChicago);
            this.groupTimeZone.Controls.Add(this.radioLosAngeles);
            this.groupTimeZone.Controls.Add(this.radioNewYork);
            this.groupTimeZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTimeZone.Location = new System.Drawing.Point(17, 64);
            this.groupTimeZone.Name = "groupTimeZone";
            this.groupTimeZone.Size = new System.Drawing.Size(117, 128);
            this.groupTimeZone.TabIndex = 2;
            this.groupTimeZone.TabStop = false;
            this.groupTimeZone.Text = "Zona horaria";
            // 
            // buttonResetZonaHoraria
            // 
            this.buttonResetZonaHoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetZonaHoraria.Location = new System.Drawing.Point(6, 100);
            this.buttonResetZonaHoraria.Name = "buttonResetZonaHoraria";
            this.buttonResetZonaHoraria.Size = new System.Drawing.Size(97, 23);
            this.buttonResetZonaHoraria.TabIndex = 9;
            this.buttonResetZonaHoraria.Text = "Desmarcar";
            this.buttonResetZonaHoraria.UseVisualStyleBackColor = true;
            this.buttonResetZonaHoraria.Click += new System.EventHandler(this.buttonResetZonaHoraria_Click);
            // 
            // radioChicago
            // 
            this.radioChicago.AutoSize = true;
            this.radioChicago.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioChicago.Location = new System.Drawing.Point(7, 74);
            this.radioChicago.Name = "radioChicago";
            this.radioChicago.Size = new System.Drawing.Size(78, 20);
            this.radioChicago.TabIndex = 2;
            this.radioChicago.TabStop = true;
            this.radioChicago.Text = "Chicago";
            this.radioChicago.UseVisualStyleBackColor = true;
            // 
            // radioLosAngeles
            // 
            this.radioLosAngeles.AutoSize = true;
            this.radioLosAngeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLosAngeles.Location = new System.Drawing.Point(7, 49);
            this.radioLosAngeles.Name = "radioLosAngeles";
            this.radioLosAngeles.Size = new System.Drawing.Size(107, 20);
            this.radioLosAngeles.TabIndex = 1;
            this.radioLosAngeles.TabStop = true;
            this.radioLosAngeles.Text = "Los_Angeles";
            this.radioLosAngeles.UseVisualStyleBackColor = true;
            // 
            // radioNewYork
            // 
            this.radioNewYork.AutoSize = true;
            this.radioNewYork.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNewYork.Location = new System.Drawing.Point(7, 22);
            this.radioNewYork.Name = "radioNewYork";
            this.radioNewYork.Size = new System.Drawing.Size(90, 20);
            this.radioNewYork.TabIndex = 0;
            this.radioNewYork.TabStop = true;
            this.radioNewYork.Text = "New_York";
            this.radioNewYork.UseVisualStyleBackColor = true;
            // 
            // checkBoxCiudadesGrandes
            // 
            this.checkBoxCiudadesGrandes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxCiudadesGrandes.AutoSize = true;
            this.checkBoxCiudadesGrandes.Location = new System.Drawing.Point(140, 163);
            this.checkBoxCiudadesGrandes.Name = "checkBoxCiudadesGrandes";
            this.checkBoxCiudadesGrandes.Size = new System.Drawing.Size(140, 20);
            this.checkBoxCiudadesGrandes.TabIndex = 3;
            this.checkBoxCiudadesGrandes.Text = "Ciudades grandes";
            this.checkBoxCiudadesGrandes.UseVisualStyleBackColor = true;
            // 
            // labelCiudadesGrandes
            // 
            this.labelCiudadesGrandes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCiudadesGrandes.AutoSize = true;
            this.labelCiudadesGrandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCiudadesGrandes.Location = new System.Drawing.Point(161, 142);
            this.labelCiudadesGrandes.Name = "labelCiudadesGrandes";
            this.labelCiudadesGrandes.Size = new System.Drawing.Size(119, 16);
            this.labelCiudadesGrandes.TabIndex = 4;
            this.labelCiudadesGrandes.Text = "Filtro de tamaño";
            this.labelCiudadesGrandes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelBuscarCiudad
            // 
            this.labelBuscarCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBuscarCiudad.AutoSize = true;
            this.labelBuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarCiudad.Location = new System.Drawing.Point(165, 70);
            this.labelBuscarCiudad.Name = "labelBuscarCiudad";
            this.labelBuscarCiudad.Size = new System.Drawing.Size(120, 16);
            this.labelBuscarCiudad.TabIndex = 5;
            this.labelBuscarCiudad.Text = "Ciudad buscada";
            // 
            // textBoxBuscarCiudad
            // 
            this.textBoxBuscarCiudad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxBuscarCiudad.Location = new System.Drawing.Point(164, 91);
            this.textBoxBuscarCiudad.Name = "textBoxBuscarCiudad";
            this.textBoxBuscarCiudad.Size = new System.Drawing.Size(106, 22);
            this.textBoxBuscarCiudad.TabIndex = 6;
            // 
            // comboBoxDatos
            // 
            this.comboBoxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDatos.FormattingEnabled = true;
            this.comboBoxDatos.Items.AddRange(new object[] {
            "CiudadesEEUU.csv"});
            this.comboBoxDatos.Location = new System.Drawing.Point(72, 37);
            this.comboBoxDatos.Name = "comboBoxDatos";
            this.comboBoxDatos.Size = new System.Drawing.Size(179, 24);
            this.comboBoxDatos.TabIndex = 7;
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatos.Location = new System.Drawing.Point(14, 40);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(52, 16);
            this.labelDatos.TabIndex = 8;
            this.labelDatos.Text = "Datos:";
            // 
            // Inicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.comboBoxDatos);
            this.Controls.Add(this.textBoxBuscarCiudad);
            this.Controls.Add(this.labelBuscarCiudad);
            this.Controls.Add(this.labelCiudadesGrandes);
            this.Controls.Add(this.checkBoxCiudadesGrandes);
            this.Controls.Add(this.groupTimeZone);
            this.Controls.Add(this.buttonMostrarCiudades);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Inicio";
            this.Text = "Reporte de ciudades";
            this.groupTimeZone.ResumeLayout(false);
            this.groupTimeZone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonMostrarCiudades;
        private System.Windows.Forms.GroupBox groupTimeZone;
        private System.Windows.Forms.RadioButton radioChicago;
        private System.Windows.Forms.RadioButton radioLosAngeles;
        private System.Windows.Forms.RadioButton radioNewYork;
        private System.Windows.Forms.CheckBox checkBoxCiudadesGrandes;
        private System.Windows.Forms.Label labelCiudadesGrandes;
        private System.Windows.Forms.Label labelBuscarCiudad;
        private System.Windows.Forms.TextBox textBoxBuscarCiudad;
        private System.Windows.Forms.ComboBox comboBoxDatos;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Button buttonResetZonaHoraria;
    }
}

