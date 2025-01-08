using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaCoches_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources.ceed_520x260;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.niro_hev_520x260;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.picanto_520x260;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.sorento_24_520x260;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.sportage_520x260;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
