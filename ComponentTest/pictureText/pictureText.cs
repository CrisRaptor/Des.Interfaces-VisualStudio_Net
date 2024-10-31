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

        [Category("Behaviour")]
        [Description("Imagen utilizada.")]
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image == null) return;

            float zoomFactor = 1.1f;

            if (e.Delta > 0)
            {
                pictureBox.Width = (int)(pictureBox.Width * zoomFactor);
                pictureBox.Height = (int)(pictureBox.Height * zoomFactor);
            }
            else
            {
                pictureBox.Width = (int)(pictureBox.Width / zoomFactor);
                pictureBox.Height = (int)(pictureBox.Height / zoomFactor);
            }


        }

        public pictureText()
        {
            InitializeComponent();
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
            labelDescription.Location = new Point((pictureBox.Width - labelDescription.Width) / 2, labelDescription.Location.Y);
        }
    }
}
