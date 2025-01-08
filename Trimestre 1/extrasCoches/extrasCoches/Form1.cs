using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extrasCoches
{
    public partial class Form1 : Form
    {
        List<string> extras = new List<string>() {"Audio Bose", 
            "Bizona", "Camara trasea", "Sensores", "Cuero", "Control. velocidad", 
            "Cambio carril", "GPS", "Llantas 18\"", "Asist. aparcamiento", 
            "Automatico", "Android", "CR7 Asistente", "Asientos calefactores"};

        public Form1()
        {
            InitializeComponent();
        }

        private void loadListData(ListBox objeto, List<string> lista, int cantidad) {
            
            for (int i = 0; i < cantidad; i++)
            {
                objeto.Items.Add(lista[i]);
            }
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ceed (4), Niro (3), Picanto (4), Sportage(3)

            listBox1.Items.Clear();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    loadListData(listBox1, extras, 4);
                    break;
                case 1:
                    loadListData(listBox1, extras, 7);
                    break;
                case 2:
                    loadListData(listBox1, extras, 11);
                    break;
                case 3:
                    loadListData(listBox1, extras, 14);
                    break;
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
    }
}
