using ComponentTest.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComponentTest
{
    public partial class Form1 : Form
    {
        private int tick;
        public Form1()
        {
            InitializeComponent();
            tick = 0;
        }

        private void termometro2_ValueChange(object sender, EventArgs e)
        {
            if (termometro2.Value == termometro2.Maximum)
            {
                pictureBox.Image = Resources.house_fire;
            } else
            {
                pictureBox.Image = Resources.house_simple;
            }
        }

        private void chrono1_TimeChange(List<int> values)
        {
            if (tick == 30)
            {
                tick = 0;
            }
            if (tick == 0)
            {
                TimeSpan ts = DateTime.Now.TimeOfDay;
                listBox1.Items.Add(ts.ToString().Substring(0,8));
            }
            tick++;
        }
    }
}
