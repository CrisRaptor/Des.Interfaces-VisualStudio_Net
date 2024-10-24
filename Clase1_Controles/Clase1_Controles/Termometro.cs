using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1_Controles
{
    public partial class Termometro: UserControl
    {
        public Termometro()
        {
            InitializeComponent();
            temperatura.Value = 3;
        }

        private void temperatura_ValueChanged(object sender, EventArgs e)
        {
            switch (temperatura.Value)
            {
                case 1:
                    imagen.Image = Properties.Resources.hielo;
                    break;
                case 2:
                    imagen.Image = Properties.Resources.copo_de_nieve;
                    break;
                case 3:
                    imagen.Image = Properties.Resources.normal;
                    break;
                case 4:
                    imagen.Image = Properties.Resources.soleado;
                    break;
                case 5:
                    imagen.Image = Properties.Resources.flama_de_fuego;
                    break;
                default:
                    imagen.Image = null;
                    break;
            }
        }
    }
}
