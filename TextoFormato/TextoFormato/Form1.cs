using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextoFormato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            caja.ForeColor = Color.White;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            caja.Font = new Font(caja.Font.FontFamily, 8);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            caja.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            caja.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            caja.ForeColor = Color.Green;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            caja.ForeColor = Color.Red;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            caja.BackColor = Color.White;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            caja.BackColor = Color.LightYellow;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            caja.BackColor = Color.LightSkyBlue;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            caja.BackColor = Color.Violet;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            caja.BackColor = Color.Black;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            caja.Font = new Font(caja.Font.FontFamily, 10);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            caja.Font = new Font(caja.Font.FontFamily, 12);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            caja.Font = new Font(caja.Font.FontFamily, 16);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            caja.Font = new Font(caja.Font.FontFamily, 24);
        }
    }
}
