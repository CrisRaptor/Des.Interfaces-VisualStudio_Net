using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RevolucionesCoche
{
    public partial class MainWindow : Window
    {
        int revoluciones, max_revoluciones;
        public MainWindow()
        {
            InitializeComponent();
            revoluciones = 0;
        }

        public int acelera()
        {
            revoluciones++;
            texto_revoluciones_digital.Content = revoluciones.ToString();
            imagen_puntero_revoluciones.RenderTransform = new RotateTransform(calcularAngulo(revoluciones, max_revoluciones, 230, -135));
            return revoluciones;
        }

        private void edittext_max_revoluciones_Copiar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Convert.ToInt64(edittext_caballos.Text) > 150)
            {
                edittext_caballos.Text = 150.ToString();
            } else if (Convert.ToInt64(edittext_caballos.Text) < 100)
            {
                edittext_caballos.Text = 100.ToString();
            }
        }

        private int calcularAngulo(int revoluciones, int max_revoluciones, int anguloTotal, int anguloInicio)
        {
            return ((revoluciones / max_revoluciones) * anguloTotal) - anguloInicio;
        }
    }
}
