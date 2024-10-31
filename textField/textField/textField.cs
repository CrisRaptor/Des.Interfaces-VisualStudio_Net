using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace textField
{
    public enum positions
    {
        Top = 0, Left = 1
    };
    public partial class textField : UserControl
    {
        [Description("Variable que almacena la posicion del texto de la izquierda."), Category("Private")]
        private positions _Position;
        [Description("Caracteres máximos para el campo editable."), Category("Behavior")]
        public int CharacterLimit
        {
            get
            {
                return textBox.MaxLength;
            }
            set
            {
                textBox.MaxLength = value;
                setLabelLimit();
            }
        }
        [Description("Texto dentro de el titulo de la izquierda."), Category("Appearance")]
        public string TextLeft
        {
            get
            {
                return labelFieldName.Text;
            }
            set
            {
                labelFieldName.Text = value;
            }
        }
        [Description("Posicion del texto de la izquierda en el componente."), Category("Behavior")]
        public positions Position
        {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
                adjustLeftLabel();
            }
        }

        public textField()
        {
            InitializeComponent();
            adjustRightLabel();
        }

        private void setLabelLimit()
        {
            labelLimit.Text = textBox.Text.Length + " / " + textBox.MaxLength;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            setLabelLimit();
        }

        private void adjustRightLabel()
        {
            
            labelLimit.Location = new Point(Right - Left - labelLimit.Width, 0);
        }
    
        private void adjustLeftLabel()
        {
            switch (Position)
            {
                case positions.Top:
                    textBox.Width = Width;
                    labelFieldName.Location = new Point(0, 0);
                    textBox.Location = new Point(0, textBox.Location.Y);
                    break;
                case positions.Left:
                    textBox.Width = Width - labelFieldName.Width;
                    labelFieldName.Location = new Point(0, textBox.Location.Y + 3);
                    textBox.Location = new Point(labelFieldName.Width, textBox.Location.Y);
                    break;
            }
        }

        public void textBox_SizeChanged(object sender, EventArgs e)
        {
            adjustRightLabel();
        }
    }
}
