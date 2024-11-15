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

        }

        private void chrono_TimeChange(List<int> values)
        {
            if (tick == 30)
            {
                tick = 0;
            }
            if (tick == 0)
            {
                string time = DateTime.Now.ToLongTimeString();
                string date = DateTime.Now.ToShortDateString();

                dataGridView.Rows.Add(date + " | " + time);
                dataGridView.ClearSelection();
            }
            tick++;
        }
    }
}
