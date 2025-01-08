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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.HoraRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chrono = new Chronometer.chrono();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoraRegistro});
            this.dataGridView.Location = new System.Drawing.Point(579, 9);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(300, 250);
            this.dataGridView.TabIndex = 2;
            // 
            // HoraRegistro
            // 
            this.HoraRegistro.HeaderText = "Hora Registrada";
            this.HoraRegistro.MinimumWidth = 6;
            this.HoraRegistro.Name = "HoraRegistro";
            this.HoraRegistro.ReadOnly = true;
            // 
            // chrono
            // 
            this.chrono.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chrono.BackColor = System.Drawing.Color.Transparent;
            this.chrono.colorOff = System.Drawing.Color.Transparent;
            this.chrono.colorOn = System.Drawing.Color.Red;
            this.chrono.DotTicksRatio = 6;
            this.chrono.Location = new System.Drawing.Point(9, 9);
            this.chrono.Margin = new System.Windows.Forms.Padding(0);
            this.chrono.MinimumSize = new System.Drawing.Size(540, 250);
            this.chrono.Name = "chrono";
            this.chrono.Size = new System.Drawing.Size(540, 250);
            this.chrono.TabIndex = 3;
            this.chrono.TimeChange += new Chronometer.chrono.GetValuesEventHandler(this.chrono_TimeChange);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(899, 546);
            this.Controls.Add(this.chrono);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraRegistro;
        private Chronometer.chrono chrono;
    }
}

