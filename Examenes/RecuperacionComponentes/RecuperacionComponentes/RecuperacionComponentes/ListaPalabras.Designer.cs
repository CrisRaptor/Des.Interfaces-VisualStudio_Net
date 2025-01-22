namespace RecuperacionComponentes
{
    partial class ListaPalabras
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
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_input
            // 
            this.textbox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_input.Location = new System.Drawing.Point(3, 3);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(163, 22);
            this.textbox_input.TabIndex = 0;
            this.textbox_input.Text = "TextBox";
            this.textbox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_input_KeyPress);
            // 
            // listbox
            // 
            this.listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 16;
            this.listbox.Items.AddRange(new object[] {
            "Sample Item 1",
            "Sample Item 2",
            "Sample Item 3",
            "Sample Item 4",
            "Sample Item 5"});
            this.listbox.Location = new System.Drawing.Point(3, 31);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(120, 164);
            this.listbox.TabIndex = 1;
            this.listbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listbox_KeyPress);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(129, 31);
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar.Size = new System.Drawing.Size(56, 162);
            this.trackBar.TabIndex = 2;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // ListaPalabras
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.textbox_input);
            this.Name = "ListaPalabras";
            this.Size = new System.Drawing.Size(169, 203);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_input;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TrackBar trackBar;
    }
}
