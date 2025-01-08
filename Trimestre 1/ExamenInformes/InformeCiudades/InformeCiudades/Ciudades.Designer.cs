namespace InformeCiudades
{
    partial class Ciudades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ciudades));
            this.reportViewerCiudades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerCiudades
            // 
            this.reportViewerCiudades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerCiudades.LocalReport.ReportEmbeddedResource = "InformeCiudades.Informes.ReportCiudades.rdlc";
            this.reportViewerCiudades.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCiudades.Name = "reportViewerCiudades";
            this.reportViewerCiudades.ServerReport.BearerToken = null;
            this.reportViewerCiudades.Size = new System.Drawing.Size(800, 450);
            this.reportViewerCiudades.TabIndex = 0;
            // 
            // Ciudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerCiudades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ciudades";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.Ciudades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCiudades;
    }
}