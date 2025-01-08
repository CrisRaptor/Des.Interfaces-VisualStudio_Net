using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcadorFutbol
{
    public partial class Marcador: UserControl
    {
        //Equipo 1
        [Browsable(true),Category("Equipo 1"),Description("Imagen de logo del equipo 1")]
        public Image Logo1 { 
            get{
                return pictureTeam1.Image;
            }
            set
            {
                pictureTeam1.Image = value;
            }
        }
        [Browsable(true), Category("Equipo 1"), Description("Nombre del equipo 1")]
        public string Nombre1 { 
            get
            {
                return labelTeam1.Text;
            }
            set{
                labelTeam1.Text = value;
            }
        }
        [Browsable(true), Category("Equipo 1"), Description("Goles anotados del equipo 1")]
        public int Goles1{
            get
            {
                return int.Parse(score1.Text);
            }
            set
            {
                score1.Text = value.ToString();
            }
        }

        //Equipo 2
        [Browsable(true), Category("Equipo 2"), Description("Imagen de logo del equipo 2")]
        public Image Logo2 { 
            get{
                return pictureTeam2.Image;
            }
            set
            {
                pictureTeam2.Image = value;
            }
        }

        [Browsable(true), Category("Equipo 2"), Description("Nombre del equipo 2")]
        public string Nombre2
        {
            get
            {
                return labelTeam2.Text;
            }
            set
            {
                labelTeam2.Text = value;
            }
        }
        [Browsable(true), Category("Equipo 2"), Description("Goles anotados del equipo 2")]
        public int Goles2
        {
            get
            {
                return int.Parse(score2.Text);
            }
            set
            {
                score2.Text = value.ToString();
            }
        }
        //Partido
        [Browsable(true), Category("Partido"), Description("Parte")]
        public int Parte
        {
            get
            {
                string valor = labelParte.Text.ToString().Substring(6);
                return int.Parse(valor);
            }
            set
            {
                if (value < 1)
                {
                    value = 1; //Valor minimo
                } else if (value > 2)
                {
                    value = 2; //Valor maximo
                }
                labelParte.Text = "Parte "+value.ToString();
                if (value == 2)
                {
                    Tiempo = 45 * 60;
                } else
                {
                    Tiempo = 0;
                }
            }
        }

        [Browsable(true),Category("Partido"),Description("Tiempo en segundos que han transcurrido")]
        public int Tiempo
        {
            get
            {
                return int.Parse(minutes.Text) * 60 + int.Parse(seconds.Text);
            }
            set
            {
                //Comprobacion
                if (value < 0)
                {
                    value = 0;//Tiempo minimo
                } else if (value > (Parte * 45) * 60) //Comprueba si el tiempo supera el maximo
                {
                    value = (Parte * 45) * 60;//Tiempo maximo
                }
                //Establece el texto
                if (value > 0) //Evita dividir entre 0
                {
                    minutes.Text = ajustarFormatoTiempo(value / 60);
                }
                seconds.Text = ajustarFormatoTiempo(value%60);
            }
        }

        public Marcador()
        {
            InitializeComponent();
        }

        private string ajustarFormatoTiempo(int valor)
        {
            string text = valor.ToString();
            if (valor < 10)
            {
                text = "0" + text;
            }
            return text;
        }

        public void SumaSegundo()
        {
            Tiempo++;
        }

        public void RestaSegundo()
        {
            Tiempo--;
        }

        public void SumaMinuto()
        {
            Tiempo += 60;
        }

        public void RestaMinuto()
        {
            Tiempo -= 60;
        }
    }
}   
