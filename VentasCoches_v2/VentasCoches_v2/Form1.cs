using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasCoches_v2
{
    public partial class Form1 : Form
    {
        Boolean isEnabled = false;
        List<string> extras = new List<string>() {"Audio Bose",
            "Bizona", "Camara trasea", "Sensores", "Cuero", "Control. velocidad",
            "Cambio carril", "GPS", "Llantas 18\"", "Asist. aparcamiento",
            "Automatico", "Android", "CR7 Asistente", "Asientos calefactores"};

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.default_kia;
        }

        private void loadListData(ListBox objeto, List<string> lista, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                objeto.Items.Add(lista[i]);
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            foreach (int item in listBox2.SelectedIndices)
            {
                values.Add(listBox2.Items[item].ToString());
            }
            listBox1.Items.AddRange(values.ToArray());
            foreach (string c in values)
            {
                listBox2.Items.Remove(c);
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            foreach (int item in listBox1.SelectedIndices)
            {
                values.Add(listBox1.Items[item].ToString());
            }
            listBox2.Items.AddRange(values.ToArray());
            foreach (string c in values)
            {
                listBox1.Items.Remove(c);
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            if (!isEnabled) { 
                textBox1.Enabled = true;
                numericUpDown1.Enabled = true;
                listBox1.Enabled = true;
                listBox2.Enabled = true;
                listBox3.Enabled = true;
                rightButton.Enabled = true;
                leftButton.Enabled = true;
                isEnabled = true;
            } 
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    loadListData(listBox1, extras, 4);
                    pictureBox1.Image = Properties.Resources.ceed_520x260;
                    break;
                case 1:
                    loadListData(listBox1, extras, 7);
                    pictureBox1.Image = Properties.Resources.niro_hev_520x260;
                    break;
                case 2:
                    loadListData(listBox1, extras, 11);
                    pictureBox1.Image = Properties.Resources.picanto_520x260;
                    break;
                case 3:
                    loadListData(listBox1, extras, 14);
                    pictureBox1.Image = Properties.Resources.sportage_520x260;
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 5)
            {
                textBox1.ForeColor = Color.Red;
            } else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text.Length == 5 && listBox3.Items.Count < 3) {
                    listBox3.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    errorProvider1.Clear();
                }
                else
                {
                    String errorMessage = ((textBox1.Text.Length != 5) ? "Obligatory 5 characters" : "Maximum 3 discounts");
                    errorProvider1.SetError(textBox1, errorMessage);
                }
            }
            
        }

        private void listBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }
    }
}
