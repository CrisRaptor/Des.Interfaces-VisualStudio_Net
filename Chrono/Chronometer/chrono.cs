
using System.Windows.Forms;
using System.Collections.Generic;
using Chronometer.Properties;
using System.Drawing;

using System.ComponentModel;
using System;

namespace Chronometer
{
    public partial class chrono : UserControl
    {
        private List<Counter> contadores = new List<Counter>();
        private List<Dots> dotList = new List<Dots>();
        
        private int ticks, dotTicks, tickRatio = 1;
        
        private Boolean dotsOn = true;

        [Category("Frecuencia")]
        [Description("Frecuencia de parpadeo de los puntos medido en décimas de segundo.")]
        public int dotTicksRatio { get; set; }


        [Category("Coloreado")]
        [Description("Color de las líneas encendidas.")]
        public Color colorOn
        {
            get
            {
                if (contadores.Count > 0)
                {
                    return contadores[0].color;
                } else {
                    return Color.Red;
                }
            }
            set
            {
                foreach (Counter counter in contadores)
                {
                    counter.color = value;
                }
                foreach (Dots dot in dotList)
                {
                    dot.color = value;
                }
            }
        }
        [Category("Coloreado")]
        [Description("Color de las líneas apagadas.")]
        public Color colorOff
        {
            get
            {
                if (contadores.Count > 0)
                {
                    return contadores[0].backcolor;
                }
                else
                {
                    return Color.Transparent;
                }
            }
            set
            {
                foreach (Counter counter in contadores)
                {
                    counter.backcolor = value;
                }
                foreach (Dots dot in dotList)
                {
                    dot.backcolor = value;
                }
            }
        }

        public chrono()
        {
            InitializeComponent();
            tickRatio = 1;
            dotTicksRatio = 6;

            //Crear contador para los minutos
            Digit digit1 = new Digit(digit1Top, digit1TopStart, digit1TopEnd, digit1Center, digit1BottonStart, digit1BottonEnd, digit1Botton);
            Digit digit2 = new Digit(digit2Top, digit2TopStart, digit2TopEnd, digit2Center, digit2BottonStart, digit2BottonEnd, digit2Botton);
            List<Digit> digitsMinutes = new List<Digit>{digit1,digit2};
            Counter minutes = new Counter(digitsMinutes, 59, colorOn, colorOff);

            //Crear contador para los segundos
            Digit digit3 = new Digit(digit3Top, digit3TopStart, digit3TopEnd, digit3Center, digit3BottonStart, digit3BottonEnd, digit3Botton);
            Digit digit4 = new Digit(digit4Top, digit4TopStart, digit4TopEnd, digit4Center, digit4BottonStart, digit4BottonEnd, digit4Botton);
            List<Digit> digitsSeconds = new List<Digit> { digit3, digit4 };
            Counter seconds = new Counter(digitsSeconds,59, colorOn, colorOff);
            
            //Añadir contadores
            contadores.Add(minutes);
            contadores.Add(seconds);

            //Añadir puntos
            Dots dots = new Dots(dot1Up,dot1Down, colorOn, colorOff);
            dotList.Add(dots);
            ticks = 0;
            dotTicks = 0;
        }

        public delegate void GetValuesEventHandler(List<int> values);

        [Browsable(true)]
        [Category("Eventos internos")]
        [Description("Se activa cuando el temporizador cambia.")]
        public event GetValuesEventHandler TimeChange;



        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (buttonStart.Text != "STOP")
            {
                timer.Start();
                buttonReset.Enabled = true;
                buttonStart.Text = "STOP";
            }
            else
            {
                timer.Stop();
                foreach (Dots dot in dotList)
                {
                    dot.paintDots(false);
                }
                dotsOn = true;
                buttonStart.Text = "START";
            }

        }


        private void timer_Tick(object sender, System.EventArgs e)
        {
            ticks++;
            dotTicks++;
            if ((dotTicks % (dotTicksRatio/tickRatio)) == 0)
            {
                foreach (Dots dot in dotList)
                {
                    dot.paintDots(dotsOn);
                }
                dotsOn = !dotsOn;
                dotTicks = 0;
            }

            if (ticks == (10 / tickRatio))
            {
                ticks = 0;
                addTime();
                List<int> values = new List<int>();
                foreach (Counter contador in contadores)
                {
                    values.Add(contador.number);
                }
                if (TimeChange != null) TimeChange(values);
            }

        }
        private void addTime()
        {
            int pos = contadores.Count - 1;
            while (pos >= 0)
            {
                int increase = contadores[pos].increase();
                if (increase == 0)
                {
                    pos--;
                }
                else
                {
                    pos = 0;
                }
            }
        }


        private void buttonReset_Click(object sender, System.EventArgs e)
        {
            timer.Stop();
            foreach (Counter counter in contadores)
            {
                counter.number = counter.getMaxValue();
                counter.increase();
            }
            foreach (Dots dot in dotList)
            {
                dot.paintDots(false);
            }
            dotsOn = true;
            buttonStart.Text = "START";
            buttonReset.Enabled = false;
        }
    }
}
