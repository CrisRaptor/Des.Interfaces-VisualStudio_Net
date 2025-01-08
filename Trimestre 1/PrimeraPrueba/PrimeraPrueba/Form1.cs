using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraPrueba
{
    public partial class CajaIdiomas : Form
    {
        public CajaIdiomas()
        {
            InitializeComponent();
            listBox1.BackColor = Color.LightYellow;
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clicAcepto_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(caja.Text);
            } else
            {
                listBox2.Items.Add(caja.Text);
            }
            caja.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enterCaja(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.BackColor = Color.LightYellow;
                listBox2.BackColor = Color.White;
            } else
            {
                listBox2.BackColor = Color.LightYellow;
                listBox1.BackColor = Color.White;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
