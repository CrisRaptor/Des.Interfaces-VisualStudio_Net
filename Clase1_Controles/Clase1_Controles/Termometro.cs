using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Clase1_Controles
{
    public partial class Termometro: UserControl
    {
        public int Cachopo 
            {
                get{
                    return temperatura.Value;
                }
                set
                {
                    temperatura.Value = (value>temperatura.Maximum)?temperatura.Maximum:(value < temperatura.Minimum)?temperatura.Minimum:value;
                }
            }
            
        

        public Termometro()
        {
            InitializeComponent();
        }

        private void temperatura_ValueChanged(object sender, EventArgs e)
        {

            switch (temperatura.Value)
            {
                case int n when (n <= (temperatura.Maximum * 0.2)):
                    imagen.Image = Properties.Resources.hielo;
                    break;
                case int n when (n <= (temperatura.Maximum * 0.4)):
                    imagen.Image = Properties.Resources.copo_de_nieve;
                    break;
                case int n when (n <= (temperatura.Maximum * 0.6)):
                    imagen.Image = Properties.Resources.normal;
                    break;
                case int n when (n <= (temperatura.Maximum * 0.8)):
                    imagen.Image = Properties.Resources.soleado;
                    break;
                case int n when (n <= (temperatura.Maximum * 1)):
                    imagen.Image = Properties.Resources.flama_de_fuego;
                    break;
                default:
                    imagen.Image = null;
                    break;
            }
            if (this.ValueChange != null)
            {
                ValueChange(this, new EventArgs());
            }

        }

        [Browsable(true)]
        [Category("Eventos internos")]
        [Description("Se activa cuando la temperatura cambiar")]
        public event EventHandler ValueChange;
    }
}
