using MarcadorFutbol;
using Partido.Properties;
using System;
using System.Windows.Forms;

namespace Partido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            score1.Value = marcador1.Goles1;
            score2.Value = marcador1.Goles2;
            parte.SelectedIndex = marcador1.Parte - 1;
        }

        private void score1_ValueChanged(object sender, EventArgs e)
        {
            marcador1.Goles1 = score1.Value;
        }

        private void score2_ValueChanged(object sender, EventArgs e)
        {
            marcador1.Goles2 = score2.Value;
        }

        private void parte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (parte.SelectedIndex == 0)
            {
                marcador1.Parte = 1;
            } else
            {
                marcador1.Parte = 2;
            }
        }

        private void botonMenosSegundo_Click(object sender, EventArgs e)
        {
            
            marcador1.Tiempo--;
            comprobarTiempo();
        }

        private void botonMasSegundo_Click(object sender, EventArgs e)
        {
            marcador1.Tiempo++;
            comprobarTiempo();
        }

        private void botonMenosMinuto_Click(object sender, EventArgs e)
        {
            marcador1.Tiempo -= 60;
            comprobarTiempo();
        }

        private void botonMasMinuto_Click(object sender, EventArgs e)
        {
            marcador1.Tiempo += 60;
            comprobarTiempo();
        }

        private void comprobarTiempo()
        {
            //Comprueba si habilita los botones de restar
            if (marcador1.Tiempo < 1)
            {//Segundos
                botonMenosMinuto.Enabled = false;
                botonMenosSegundo.Enabled = false;
            } else
            {//Habilita segundos y comprueba minutos
                botonMenosSegundo.Enabled = true;
                if (marcador1.Tiempo < 60)
                {
                    botonMenosMinuto.Enabled = false;
                }
                else
                {
                    botonMenosMinuto.Enabled = true;
                }
            }
            //Comprueba si habilita los botones de sumar
            if (marcador1.Tiempo == marcador1.Parte * 45 * 60)
            { //Segundos
                botonMasMinuto.Enabled = false;
                botonMasSegundo.Enabled = false;
            } else
            { //Habilita segundos y comprueba minutos
                botonMasSegundo.Enabled = true;
                if (marcador1.Tiempo <= marcador1.Parte * 44 * 60)
                {
                    botonMasMinuto.Enabled = true;
                }
                else
                {
                    botonMasMinuto.Enabled = false;
                }
            }
            
        }

        private void silbato_Click(object sender, EventArgs e)
        {
            if (partido.Text == "COMENZAR PARTIDO")
            {
                botonMasMinuto.Enabled = false;
                botonMasSegundo.Enabled = false;
                botonMenosMinuto.Enabled = false;
                botonMenosSegundo.Enabled = false;
                parte.Enabled = false;
                timer.Start();
                partido.Text = "TERMINAR PARTIDO";
                silbato.Image = Resources.silbato_stop;
            } else
            {
                parte.Enabled = true;
                comprobarTiempo();
                timer.Stop();
                partido.Text = "COMENZAR PARTIDO";
                silbato.Image = Resources.silbato_start;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            marcador1.Tiempo = 0;
            parte.SelectedIndex = 0;
            timer.Stop();
            partido.Text = "COMENZAR PARTIDO";
            silbato.Image = Resources.silbato_start;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            marcador1.Tiempo++;
        }
    }
}
