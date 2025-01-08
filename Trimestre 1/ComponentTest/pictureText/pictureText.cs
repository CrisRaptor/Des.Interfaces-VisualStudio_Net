using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace pictureText
{
    public partial class pictureText: UserControl
    {
        [Category("Appearance")]
        [Description("Texto de la leyenda debajo de la imagen.")]
        public string Leyenda
        {
            get
            {
                return labelDescription.Text;
            }
            set
            {
                labelDescription.Text = value;
                adjustLabelX();
            }
        }
        [Category("Appearance")]
        [Description("Texto de la leyenda debajo de la imagen.")]
        public Color Color {
            get
            {
                return labelDescription.ForeColor;
            }
            set
            {
                labelDescription.ForeColor = value;
            }
        }
        
        [Category("Appearance")]
        [Description("Fuente usada en el texto de la leyenda debajo de la imagen.")]
        public Font Fuente
        {
            get
            {
                return labelDescription.Font;
            }
            set
            {
                labelDescription.Font = value;
            }
        }

        [Category("Appearance")]
        [DefaultValue(typeof(Image),null)]
        [Description("Imagen utilizada.")]
        public Image Imagen
        {
            get
            {
                 return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }

        private Point lastPoint = new Point(0, 0), initialPoint;
        private bool isDragging = false;
        private int pictureInitialWeight, pictureInitialHeight;
        public pictureText()
        {
            InitializeComponent();
            adjustLabelX();

            pictureInitialWeight = pictureBox.Width;
            pictureInitialHeight = pictureBox.Height;
            initialPoint = new Point(pictureBox.Location.X, pictureBox.Location.Y);
            panelPicture.Width = pictureBox.Width;
            panelPicture.Height = pictureBox.Height;
            pictureBox.Location = new Point(0, 0);

            pictureBox.MouseWheel += pictureBox_MouseWheel;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseDown += pictureBox_MouseDown;

            panelPicture.MouseDown += panel_MouseDown;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox.Location = initialPoint;
                pictureBox.Height = pictureInitialHeight;
                pictureBox.Width = pictureInitialWeight;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastPoint = e.Location;
            } else if (e.Button == MouseButtons.Right)
            {
                pictureBox.Location = initialPoint;
                pictureBox.Height = pictureInitialHeight;
                pictureBox.Width = pictureInitialWeight;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastPoint.X;
                int deltaY = e.Y - lastPoint.Y;
                pictureBox.Left += deltaX;
                pictureBox.Top += deltaY;
            }

        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void centerPictureBox()
        {
            pictureBox.Top = (this.ClientSize.Height - pictureBox.Height) / 2;
            pictureBox.Left = (this.ClientSize.Width - pictureBox.Width) / 2;
        }


        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null) return;
            float ImageScale = 1.1f;
            if (e.Delta > 0)
            {
                pictureBox.Size = new Size(
                (int)(pictureBox.Width * ImageScale),
                (int)(pictureBox.Height * ImageScale));
            } else
            {
                pictureBox.Size = new Size(
                (int)(pictureBox.Width / ImageScale),
                (int)(pictureBox.Height / ImageScale));
            }

            centerPictureBox();
            adjustLabelX();
        }

        private void labelDescription_TextChanged(object sender, EventArgs e)
        {
            adjustLabelX();
        }

        private void pictureText_SizeChanged(object sender, EventArgs e)
        {
            adjustLabelX();
        }

        private void adjustLabelX()
        {
            labelDescription.Location = new Point((panelPicture.Width - labelDescription.Width) / 2, panelPicture.Height);
        }
    }
}
