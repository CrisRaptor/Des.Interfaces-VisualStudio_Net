namespace MarcadorFutbol
{
    partial class Marcador
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
            this.labelTeam1 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.labelTeam2 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.timeDivider = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelParte = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureTeam1 = new System.Windows.Forms.PictureBox();
            this.pictureTeam2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTeam1
            // 
            this.labelTeam1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTeam1.AutoSize = true;
            this.labelTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam1.Location = new System.Drawing.Point(41, 15);
            this.labelTeam1.Name = "labelTeam1";
            this.labelTeam1.Size = new System.Drawing.Size(82, 20);
            this.labelTeam1.TabIndex = 0;
            this.labelTeam1.Text = "Equipo 1";
            // 
            // score1
            // 
            this.score1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(6, 0);
            this.score1.Margin = new System.Windows.Forms.Padding(0);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(19, 20);
            this.score1.TabIndex = 3;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(36, 0);
            this.score2.Margin = new System.Windows.Forms.Padding(0);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(19, 20);
            this.score2.TabIndex = 4;
            this.score2.Text = "0";
            // 
            // labelTeam2
            // 
            this.labelTeam2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTeam2.AutoSize = true;
            this.labelTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam2.Location = new System.Drawing.Point(232, 15);
            this.labelTeam2.Name = "labelTeam2";
            this.labelTeam2.Size = new System.Drawing.Size(82, 20);
            this.labelTeam2.TabIndex = 7;
            this.labelTeam2.Text = "Equipo 2";
            // 
            // minutes
            // 
            this.minutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(0, 0);
            this.minutes.Margin = new System.Windows.Forms.Padding(0);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(29, 20);
            this.minutes.TabIndex = 10;
            this.minutes.Text = "00";
            // 
            // seconds
            // 
            this.seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.Location = new System.Drawing.Point(44, 0);
            this.seconds.Margin = new System.Windows.Forms.Padding(0);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(29, 20);
            this.seconds.TabIndex = 11;
            this.seconds.Text = "00";
            // 
            // timeDivider
            // 
            this.timeDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeDivider.AutoSize = true;
            this.timeDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDivider.Location = new System.Drawing.Point(29, 0);
            this.timeDivider.Margin = new System.Windows.Forms.Padding(0);
            this.timeDivider.Name = "timeDivider";
            this.timeDivider.Size = new System.Drawing.Size(15, 20);
            this.timeDivider.TabIndex = 12;
            this.timeDivider.Text = ":";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 46);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelParte
            // 
            this.labelParte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParte.AutoSize = true;
            this.labelParte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParte.Location = new System.Drawing.Point(9, 0);
            this.labelParte.Margin = new System.Windows.Forms.Padding(0);
            this.labelParte.Name = "labelParte";
            this.labelParte.Size = new System.Drawing.Size(70, 20);
            this.labelParte.TabIndex = 14;
            this.labelParte.Text = "Parte 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.260646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.43227F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.19741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.260646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.65161F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureTeam1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureTeam2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTeam2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTeam1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(400, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 50);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.score1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.score2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(150, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(55, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(55, 20);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.labelParte);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(80, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(80, 46);
            this.flowLayoutPanel3.TabIndex = 16;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.minutes);
            this.flowLayoutPanel5.Controls.Add(this.timeDivider);
            this.flowLayoutPanel5.Controls.Add(this.seconds);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 23);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(73, 20);
            this.flowLayoutPanel5.TabIndex = 17;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.panel1);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(355, 1);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(94, 48);
            this.flowLayoutPanel4.TabIndex = 17;
            // 
            // pictureTeam1
            // 
            this.pictureTeam1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureTeam1.Location = new System.Drawing.Point(1, 1);
            this.pictureTeam1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureTeam1.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureTeam1.Name = "pictureTeam1";
            this.pictureTeam1.Size = new System.Drawing.Size(36, 48);
            this.pictureTeam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTeam1.TabIndex = 1;
            this.pictureTeam1.TabStop = false;
            // 
            // pictureTeam2
            // 
            this.pictureTeam2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureTeam2.Location = new System.Drawing.Point(318, 1);
            this.pictureTeam2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureTeam2.MinimumSize = new System.Drawing.Size(30, 30);
            this.pictureTeam2.Name = "pictureTeam2";
            this.pictureTeam2.Size = new System.Drawing.Size(36, 48);
            this.pictureTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTeam2.TabIndex = 2;
            this.pictureTeam2.TabStop = false;
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 50);
            this.Name = "Marcador";
            this.Size = new System.Drawing.Size(450, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTeam2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTeam1;
        private System.Windows.Forms.PictureBox pictureTeam1;
        private System.Windows.Forms.PictureBox pictureTeam2;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label labelTeam2;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label timeDivider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelParte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}
