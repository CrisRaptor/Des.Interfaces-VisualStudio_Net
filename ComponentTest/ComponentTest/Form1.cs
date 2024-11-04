﻿using ComponentTest.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
