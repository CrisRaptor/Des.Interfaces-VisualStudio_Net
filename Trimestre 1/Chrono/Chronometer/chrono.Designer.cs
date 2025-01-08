namespace Chronometer
{
    partial class chrono
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.digit1Top = new System.Windows.Forms.Label();
            this.digit1Center = new System.Windows.Forms.Label();
            this.digit1TopStart = new System.Windows.Forms.Label();
            this.digit1TopEnd = new System.Windows.Forms.Label();
            this.digit1Botton = new System.Windows.Forms.Label();
            this.digit1BottonEnd = new System.Windows.Forms.Label();
            this.digit1BottonStart = new System.Windows.Forms.Label();
            this.digit2BottonStart = new System.Windows.Forms.Label();
            this.digit2BottonEnd = new System.Windows.Forms.Label();
            this.digit2Botton = new System.Windows.Forms.Label();
            this.digit2TopEnd = new System.Windows.Forms.Label();
            this.digit2TopStart = new System.Windows.Forms.Label();
            this.digit2Center = new System.Windows.Forms.Label();
            this.digit2Top = new System.Windows.Forms.Label();
            this.digit4BottonStart = new System.Windows.Forms.Label();
            this.digit4BottonEnd = new System.Windows.Forms.Label();
            this.digit4Botton = new System.Windows.Forms.Label();
            this.digit4TopEnd = new System.Windows.Forms.Label();
            this.digit4TopStart = new System.Windows.Forms.Label();
            this.digit4Center = new System.Windows.Forms.Label();
            this.digit4Top = new System.Windows.Forms.Label();
            this.digit3BottonStart = new System.Windows.Forms.Label();
            this.digit3BottonEnd = new System.Windows.Forms.Label();
            this.digit3Botton = new System.Windows.Forms.Label();
            this.digit3TopEnd = new System.Windows.Forms.Label();
            this.digit3TopStart = new System.Windows.Forms.Label();
            this.digit3Center = new System.Windows.Forms.Label();
            this.digit3Top = new System.Windows.Forms.Label();
            this.dot1Up = new System.Windows.Forms.Label();
            this.dot1Down = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReset.Enabled = false;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(310, 0);
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
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(150, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStart.MinimumSize = new System.Drawing.Size(80, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 30);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // digit1Top
            // 
            this.digit1Top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1Top.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1Top.Location = new System.Drawing.Point(20, 30);
            this.digit1Top.Margin = new System.Windows.Forms.Padding(0);
            this.digit1Top.Name = "digit1Top";
            this.digit1Top.Size = new System.Drawing.Size(80, 20);
            this.digit1Top.TabIndex = 8;
            // 
            // digit1Center
            // 
            this.digit1Center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1Center.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1Center.Location = new System.Drawing.Point(20, 130);
            this.digit1Center.Margin = new System.Windows.Forms.Padding(0);
            this.digit1Center.Name = "digit1Center";
            this.digit1Center.Size = new System.Drawing.Size(80, 20);
            this.digit1Center.TabIndex = 9;
            // 
            // digit1TopStart
            // 
            this.digit1TopStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1TopStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1TopStart.Location = new System.Drawing.Point(0, 50);
            this.digit1TopStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit1TopStart.Name = "digit1TopStart";
            this.digit1TopStart.Size = new System.Drawing.Size(20, 80);
            this.digit1TopStart.TabIndex = 10;
            // 
            // digit1TopEnd
            // 
            this.digit1TopEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1TopEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1TopEnd.Location = new System.Drawing.Point(100, 50);
            this.digit1TopEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit1TopEnd.Name = "digit1TopEnd";
            this.digit1TopEnd.Size = new System.Drawing.Size(20, 80);
            this.digit1TopEnd.TabIndex = 11;
            // 
            // digit1Botton
            // 
            this.digit1Botton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1Botton.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1Botton.Location = new System.Drawing.Point(20, 230);
            this.digit1Botton.Margin = new System.Windows.Forms.Padding(0);
            this.digit1Botton.Name = "digit1Botton";
            this.digit1Botton.Size = new System.Drawing.Size(80, 20);
            this.digit1Botton.TabIndex = 12;
            // 
            // digit1BottonEnd
            // 
            this.digit1BottonEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1BottonEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1BottonEnd.Location = new System.Drawing.Point(100, 150);
            this.digit1BottonEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit1BottonEnd.Name = "digit1BottonEnd";
            this.digit1BottonEnd.Size = new System.Drawing.Size(20, 80);
            this.digit1BottonEnd.TabIndex = 13;
            // 
            // digit1BottonStart
            // 
            this.digit1BottonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1BottonStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit1BottonStart.Location = new System.Drawing.Point(0, 150);
            this.digit1BottonStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit1BottonStart.Name = "digit1BottonStart";
            this.digit1BottonStart.Size = new System.Drawing.Size(20, 80);
            this.digit1BottonStart.TabIndex = 14;
            // 
            // digit2BottonStart
            // 
            this.digit2BottonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2BottonStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2BottonStart.Location = new System.Drawing.Point(130, 150);
            this.digit2BottonStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit2BottonStart.Name = "digit2BottonStart";
            this.digit2BottonStart.Size = new System.Drawing.Size(20, 80);
            this.digit2BottonStart.TabIndex = 21;
            // 
            // digit2BottonEnd
            // 
            this.digit2BottonEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2BottonEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2BottonEnd.Location = new System.Drawing.Point(230, 150);
            this.digit2BottonEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit2BottonEnd.Name = "digit2BottonEnd";
            this.digit2BottonEnd.Size = new System.Drawing.Size(20, 80);
            this.digit2BottonEnd.TabIndex = 20;
            // 
            // digit2Botton
            // 
            this.digit2Botton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2Botton.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2Botton.Location = new System.Drawing.Point(150, 230);
            this.digit2Botton.Margin = new System.Windows.Forms.Padding(0);
            this.digit2Botton.Name = "digit2Botton";
            this.digit2Botton.Size = new System.Drawing.Size(80, 20);
            this.digit2Botton.TabIndex = 19;
            // 
            // digit2TopEnd
            // 
            this.digit2TopEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2TopEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2TopEnd.Location = new System.Drawing.Point(230, 50);
            this.digit2TopEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit2TopEnd.Name = "digit2TopEnd";
            this.digit2TopEnd.Size = new System.Drawing.Size(20, 80);
            this.digit2TopEnd.TabIndex = 18;
            // 
            // digit2TopStart
            // 
            this.digit2TopStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2TopStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2TopStart.Location = new System.Drawing.Point(130, 50);
            this.digit2TopStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit2TopStart.Name = "digit2TopStart";
            this.digit2TopStart.Size = new System.Drawing.Size(20, 80);
            this.digit2TopStart.TabIndex = 17;
            // 
            // digit2Center
            // 
            this.digit2Center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2Center.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2Center.Location = new System.Drawing.Point(150, 130);
            this.digit2Center.Margin = new System.Windows.Forms.Padding(0);
            this.digit2Center.Name = "digit2Center";
            this.digit2Center.Size = new System.Drawing.Size(80, 20);
            this.digit2Center.TabIndex = 16;
            // 
            // digit2Top
            // 
            this.digit2Top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit2Top.BackColor = System.Drawing.Color.RosyBrown;
            this.digit2Top.Location = new System.Drawing.Point(150, 30);
            this.digit2Top.Margin = new System.Windows.Forms.Padding(0);
            this.digit2Top.Name = "digit2Top";
            this.digit2Top.Size = new System.Drawing.Size(80, 20);
            this.digit2Top.TabIndex = 15;
            // 
            // digit4BottonStart
            // 
            this.digit4BottonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4BottonStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4BottonStart.Location = new System.Drawing.Point(420, 150);
            this.digit4BottonStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit4BottonStart.Name = "digit4BottonStart";
            this.digit4BottonStart.Size = new System.Drawing.Size(20, 80);
            this.digit4BottonStart.TabIndex = 35;
            // 
            // digit4BottonEnd
            // 
            this.digit4BottonEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4BottonEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4BottonEnd.Location = new System.Drawing.Point(520, 150);
            this.digit4BottonEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit4BottonEnd.Name = "digit4BottonEnd";
            this.digit4BottonEnd.Size = new System.Drawing.Size(20, 80);
            this.digit4BottonEnd.TabIndex = 34;
            // 
            // digit4Botton
            // 
            this.digit4Botton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4Botton.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4Botton.Location = new System.Drawing.Point(440, 230);
            this.digit4Botton.Margin = new System.Windows.Forms.Padding(0);
            this.digit4Botton.Name = "digit4Botton";
            this.digit4Botton.Size = new System.Drawing.Size(80, 20);
            this.digit4Botton.TabIndex = 33;
            // 
            // digit4TopEnd
            // 
            this.digit4TopEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4TopEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4TopEnd.Location = new System.Drawing.Point(520, 50);
            this.digit4TopEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit4TopEnd.Name = "digit4TopEnd";
            this.digit4TopEnd.Size = new System.Drawing.Size(20, 80);
            this.digit4TopEnd.TabIndex = 32;
            // 
            // digit4TopStart
            // 
            this.digit4TopStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4TopStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4TopStart.Location = new System.Drawing.Point(420, 50);
            this.digit4TopStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit4TopStart.Name = "digit4TopStart";
            this.digit4TopStart.Size = new System.Drawing.Size(20, 80);
            this.digit4TopStart.TabIndex = 31;
            // 
            // digit4Center
            // 
            this.digit4Center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4Center.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4Center.Location = new System.Drawing.Point(440, 130);
            this.digit4Center.Margin = new System.Windows.Forms.Padding(0);
            this.digit4Center.Name = "digit4Center";
            this.digit4Center.Size = new System.Drawing.Size(80, 20);
            this.digit4Center.TabIndex = 30;
            // 
            // digit4Top
            // 
            this.digit4Top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit4Top.BackColor = System.Drawing.Color.RosyBrown;
            this.digit4Top.Location = new System.Drawing.Point(440, 30);
            this.digit4Top.Margin = new System.Windows.Forms.Padding(0);
            this.digit4Top.Name = "digit4Top";
            this.digit4Top.Size = new System.Drawing.Size(80, 20);
            this.digit4Top.TabIndex = 29;
            // 
            // digit3BottonStart
            // 
            this.digit3BottonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3BottonStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3BottonStart.Location = new System.Drawing.Point(290, 150);
            this.digit3BottonStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit3BottonStart.Name = "digit3BottonStart";
            this.digit3BottonStart.Size = new System.Drawing.Size(20, 80);
            this.digit3BottonStart.TabIndex = 28;
            // 
            // digit3BottonEnd
            // 
            this.digit3BottonEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3BottonEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3BottonEnd.Location = new System.Drawing.Point(390, 150);
            this.digit3BottonEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit3BottonEnd.Name = "digit3BottonEnd";
            this.digit3BottonEnd.Size = new System.Drawing.Size(20, 80);
            this.digit3BottonEnd.TabIndex = 27;
            // 
            // digit3Botton
            // 
            this.digit3Botton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3Botton.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3Botton.Location = new System.Drawing.Point(310, 230);
            this.digit3Botton.Margin = new System.Windows.Forms.Padding(0);
            this.digit3Botton.Name = "digit3Botton";
            this.digit3Botton.Size = new System.Drawing.Size(80, 20);
            this.digit3Botton.TabIndex = 26;
            // 
            // digit3TopEnd
            // 
            this.digit3TopEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3TopEnd.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3TopEnd.Location = new System.Drawing.Point(390, 50);
            this.digit3TopEnd.Margin = new System.Windows.Forms.Padding(0);
            this.digit3TopEnd.Name = "digit3TopEnd";
            this.digit3TopEnd.Size = new System.Drawing.Size(20, 80);
            this.digit3TopEnd.TabIndex = 25;
            // 
            // digit3TopStart
            // 
            this.digit3TopStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3TopStart.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3TopStart.Location = new System.Drawing.Point(290, 50);
            this.digit3TopStart.Margin = new System.Windows.Forms.Padding(0);
            this.digit3TopStart.Name = "digit3TopStart";
            this.digit3TopStart.Size = new System.Drawing.Size(20, 80);
            this.digit3TopStart.TabIndex = 24;
            // 
            // digit3Center
            // 
            this.digit3Center.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3Center.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3Center.Location = new System.Drawing.Point(310, 130);
            this.digit3Center.Margin = new System.Windows.Forms.Padding(0);
            this.digit3Center.Name = "digit3Center";
            this.digit3Center.Size = new System.Drawing.Size(80, 20);
            this.digit3Center.TabIndex = 23;
            // 
            // digit3Top
            // 
            this.digit3Top.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit3Top.BackColor = System.Drawing.Color.RosyBrown;
            this.digit3Top.Location = new System.Drawing.Point(310, 30);
            this.digit3Top.Margin = new System.Windows.Forms.Padding(0);
            this.digit3Top.Name = "digit3Top";
            this.digit3Top.Size = new System.Drawing.Size(80, 20);
            this.digit3Top.TabIndex = 22;
            // 
            // dot1Up
            // 
            this.dot1Up.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dot1Up.BackColor = System.Drawing.Color.RosyBrown;
            this.dot1Up.Location = new System.Drawing.Point(260, 90);
            this.dot1Up.Margin = new System.Windows.Forms.Padding(0);
            this.dot1Up.Name = "dot1Up";
            this.dot1Up.Size = new System.Drawing.Size(20, 20);
            this.dot1Up.TabIndex = 36;
            // 
            // dot1Down
            // 
            this.dot1Down.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dot1Down.BackColor = System.Drawing.Color.RosyBrown;
            this.dot1Down.Location = new System.Drawing.Point(260, 170);
            this.dot1Down.Margin = new System.Windows.Forms.Padding(0);
            this.dot1Down.Name = "dot1Down";
            this.dot1Down.Size = new System.Drawing.Size(20, 20);
            this.dot1Down.TabIndex = 37;
            // 
            // chrono
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dot1Down);
            this.Controls.Add(this.dot1Up);
            this.Controls.Add(this.digit4BottonStart);
            this.Controls.Add(this.digit4BottonEnd);
            this.Controls.Add(this.digit4Botton);
            this.Controls.Add(this.digit4TopEnd);
            this.Controls.Add(this.digit4TopStart);
            this.Controls.Add(this.digit4Center);
            this.Controls.Add(this.digit4Top);
            this.Controls.Add(this.digit3BottonStart);
            this.Controls.Add(this.digit3BottonEnd);
            this.Controls.Add(this.digit3Botton);
            this.Controls.Add(this.digit3TopEnd);
            this.Controls.Add(this.digit3TopStart);
            this.Controls.Add(this.digit3Center);
            this.Controls.Add(this.digit3Top);
            this.Controls.Add(this.digit2BottonStart);
            this.Controls.Add(this.digit2BottonEnd);
            this.Controls.Add(this.digit2Botton);
            this.Controls.Add(this.digit2TopEnd);
            this.Controls.Add(this.digit2TopStart);
            this.Controls.Add(this.digit2Center);
            this.Controls.Add(this.digit2Top);
            this.Controls.Add(this.digit1BottonStart);
            this.Controls.Add(this.digit1BottonEnd);
            this.Controls.Add(this.digit1Botton);
            this.Controls.Add(this.digit1TopEnd);
            this.Controls.Add(this.digit1TopStart);
            this.Controls.Add(this.digit1Center);
            this.Controls.Add(this.digit1Top);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonReset);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(540, 250);
            this.Name = "chrono";
            this.Size = new System.Drawing.Size(540, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label digit1Top;
        private System.Windows.Forms.Label digit1Center;
        private System.Windows.Forms.Label digit1TopStart;
        private System.Windows.Forms.Label digit1TopEnd;
        private System.Windows.Forms.Label digit1Botton;
        private System.Windows.Forms.Label digit1BottonEnd;
        private System.Windows.Forms.Label digit1BottonStart;
        private System.Windows.Forms.Label digit2BottonStart;
        private System.Windows.Forms.Label digit2BottonEnd;
        private System.Windows.Forms.Label digit2Botton;
        private System.Windows.Forms.Label digit2TopEnd;
        private System.Windows.Forms.Label digit2TopStart;
        private System.Windows.Forms.Label digit2Center;
        private System.Windows.Forms.Label digit2Top;
        private System.Windows.Forms.Label digit4BottonStart;
        private System.Windows.Forms.Label digit4BottonEnd;
        private System.Windows.Forms.Label digit4Botton;
        private System.Windows.Forms.Label digit4TopEnd;
        private System.Windows.Forms.Label digit4TopStart;
        private System.Windows.Forms.Label digit4Center;
        private System.Windows.Forms.Label digit4Top;
        private System.Windows.Forms.Label digit3BottonStart;
        private System.Windows.Forms.Label digit3BottonEnd;
        private System.Windows.Forms.Label digit3Botton;
        private System.Windows.Forms.Label digit3TopEnd;
        private System.Windows.Forms.Label digit3TopStart;
        private System.Windows.Forms.Label digit3Center;
        private System.Windows.Forms.Label digit3Top;
        private System.Windows.Forms.Label dot1Up;
        private System.Windows.Forms.Label dot1Down;
    }
}
