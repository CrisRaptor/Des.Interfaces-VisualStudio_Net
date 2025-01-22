using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacionComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listaPalabras1.ItemInsertado += new EventHandler(listaPalabras1_ItemInsertado);
        }

        private void button_cargar_Click(object sender, EventArgs e)
        {
            if (listaPalabras1.ListBox_Items.Count != 0) {
                textBox_longest_word.BackColor = SystemColors.Window;
                ListBox.ObjectCollection items = listaPalabras1.ListBox_Items;
                int posicion_palabra_mas_larga = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].ToString().Length > items[posicion_palabra_mas_larga].ToString().Length)
                    {
                        posicion_palabra_mas_larga = i;
                    }
                }
                textBox_longest_word.Text = items[posicion_palabra_mas_larga].ToString();
            } else
            {
                textBox_longest_word.Text = "NO HAY REGISTROS";
                textBox_longest_word.BackColor = Color.Red;
            }
        }

        //////Eventos para el parpadeo de la imagen
        //Al insertar un valor en el componente, inicia los timer
        private void listaPalabras1_ItemInsertado(object sender, EventArgs e)
        {
            timer_parpadeo.Start();
            timer_stop.Start();
        }

        //Tras el tick de timerstop (2 segundos), detener el parpadeo
        private void timer_stop_Tick(object sender, EventArgs e)
        {
            
            timer_parpadeo.Stop();
            timer_stop.Stop();
            pictureBox.Visible = false;
        }

        //Muestra y oculta la imagen en cada tick
        private void timer_parpadeo_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Visible)
            {
                pictureBox.Visible = false;
            } else
            {
                pictureBox.Visible = true;
            }
        }
    }
}
