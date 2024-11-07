using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chronometer
{
    internal class Dots
    {
        private Label top;
        private Label bottom;
        private Color _color;
        private Color _backcolor;
        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                if (top.BackColor == _color)
                {
                    paintDots(value);
                }
                else
                {
                    paintDots(_backcolor);
                }
                _color = value;
            }
        }
        public Color backcolor
        {
            get
            {
                return _backcolor;
            }
            set
            {
                if (top.BackColor == _backcolor)
                {
                    paintDots(value);
                }
                else
                {
                    paintDots(_color);
                }
                _backcolor = value;
            }
        }


        public Dots(Label top, Label bottom, Color color, Color backcolor)
        {
            this.top = top;
            this.bottom = bottom;
            this.color = color;
            this.backcolor = backcolor;
        }

        public void paintDots(Boolean on)
        {
            if (on)
            {
                top.BackColor = _backcolor;
                bottom.BackColor = _backcolor;
            }
            else
            {
                top.BackColor = _color;
                bottom.BackColor = _color;
            }
        }

        public void paintDots(Color newColor)
        {
            top.BackColor = newColor;
            bottom.BackColor = newColor;
        }
    }
}
