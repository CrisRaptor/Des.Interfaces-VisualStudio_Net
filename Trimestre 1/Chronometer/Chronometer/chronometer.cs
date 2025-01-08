
using System.Windows.Forms;
using System.Collections.Generic;
using Chronometer.Properties;
using System.Drawing;

using System.ComponentModel;

namespace Chronometer
{
    public partial class chronometer : UserControl
    {
        private List<int> values = new List<int>();
        private List<PictureBox> digitPictures = new List<PictureBox>();
        private int ticks, dotTicks;

        [Category("Eventos internos")]
        [Description("Se activa cuando el temporizador cambia.")]
        public Color color { get; set; }

        public chronometer()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                values.Add(0);
            }
            digitPictures.Add(digit1);
            digitPictures.Add(digit2);
            digitPictures.Add(digit3);
            digitPictures.Add(digit4);
            ticks = 0;
            dotTicks = 0;
        }

        public delegate List<int> GetValuesEventHandler(List<int> values);

        [Browsable(true)]
        [Category("Eventos internos")]
        [Description("Se activa cuando el temporizador cambia.")]
        public event GetValuesEventHandler TimeChange;



        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (buttonStart.Text != "STOP")
            {
                timer.Start();
                buttonStart.Text = "STOP";
            }
            else
            {
                timer.Stop();
                buttonStart.Text = "START";
            }

        }


        private void timer_Tick(object sender, System.EventArgs e)
        {
            ticks++;
            dotTicks++;
            if (dotTicks % 6 == 0)
            {
                dots.Image = Resources.dots_off;
                dotTicks = 0;
            }
            else
            {  
                dots.Image = Resources.dots_on;
            }
            if (ticks == 10)
            {
                ticks = 0;
                addTime();
                setTimeView();
                if (TimeChange != null) TimeChange(values);
            }

        }

        private void addTime()
        {
            if (values[values.Count - 1] < 60)
            {
                values[values.Count - 1]++;
            }
            else
            {
                values[values.Count - 1] = 0;
                if (values[values.Count - 2] < 60)
                {
                    values[values.Count - 2]++;
                }
                else
                {
                    values[values.Count - 2] = 0;
                }
            }
        }

        private void setTimeView()
        {
            setImage(values[0] / 10, digit1);
            setImage(values[0] % 10, digit2);
            setImage(values[1] / 10, digit3);
            setImage(values[1] % 10, digit4);
        }

        private void setImage(int digit, PictureBox image)
        {
            switch (digit)
            {
                case 0:
                    image.Image = Resources.number_zero;
                    break;
                case 1:
                    image.Image = Resources.number_one;
                    break;
                case 2:
                    image.Image = Resources.number_two;
                    break;
                case 3:
                    image.Image = Resources.number_three;
                    break;
                case 4:
                    image.Image = Resources.number_four;
                    break;
                case 5:
                    image.Image = Resources.number_five;
                    break;
                case 6:
                    image.Image = Resources.number_six;
                    break;
                case 7:
                    image.Image = Resources.number_seven;
                    break;
                case 8:
                    image.Image = Resources.number_eight;
                    break;
                case 9:
                    image.Image = Resources.number_nine;
                    break;
                default:
                    image.Image = Resources.number_off;
                    break;
            }

        }

        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
            setImage(-1, digit1);
            setImage(-1, digit2);
            setImage(-1, digit3);
            setImage(-1, digit4);
        }
    }
}
