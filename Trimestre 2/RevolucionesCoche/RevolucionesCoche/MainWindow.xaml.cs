using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;

namespace RevolucionesCoche
{
    public partial class MainWindow : Window
    {
        int revoluciones, max_revoluciones, aceleracion, frenado;
        public MainWindow()
        {
            InitializeComponent();
            //Inicializar variables
            revoluciones = 0;
            max_revoluciones = Convert.ToInt32(edittext_max_revoluciones.Text);
            aceleracion = 21;
            frenado = 17;

            //Ajustar caballos
            ajustarCaballos(Convert.ToInt32(edittext_caballos.Text));
        }


        //////Eventos de controladores
        
        //Ajusta los caballas a un maximo y minimo
        private void edittext_max_revoluciones_Copiar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //
            if (Convert.ToInt64(edittext_caballos.Text) > 1500)
            {
                edittext_caballos.Text = 150.ToString();
            } else if (Convert.ToInt64(edittext_caballos.Text) < 100)
            {
                edittext_caballos.Text = 100.ToString();
            }
            ajustarCaballos(Convert.ToInt32(edittext_caballos.Text));
        }

        //Repeat Button de Acelerador
        private void acelerador_Click(object sender, RoutedEventArgs e)
        {
            revoluciones += aceleracion;
            revoluciones = revoluciones > max_revoluciones ? max_revoluciones:revoluciones;
            cambiarRevoluciones();
        }

        //Repeat Button de Freno
        private void freno_Click(object sender, RoutedEventArgs e)
        {
            revoluciones -= frenado;
            revoluciones = revoluciones < 1000 ? 1000 : revoluciones;
            cambiarRevoluciones();
        }


        //Arranca o apaga el coche con el boton de llaves
        private async void button_arrancar_Click(object sender, RoutedEventArgs e)
        {
            //Imagen para las llaves, encendido
            ImageBrush llave_on = new ImageBrush();
            Uri uri1 = new Uri("Images/llave-on.png", UriKind.Relative);
            StreamResourceInfo streamInfo1 = Application.GetResourceStream(uri1);
            llave_on.ImageSource = BitmapFrame.Create(streamInfo1.Stream);

            //Imagen para las llaves, apagado
            ImageBrush llave_off = new ImageBrush();
            Uri uri2 = new Uri("Images/llave-off.png", UriKind.Relative);
            StreamResourceInfo streamInfo2 = Application.GetResourceStream(uri2);
            llave_off.ImageSource = BitmapFrame.Create(streamInfo2.Stream);

            if (revoluciones == 0)
            {//Encender el coche
                button_arrancar.Background = llave_on;
                edittext_caballos.IsEnabled = false;
                while (revoluciones < 1000)
                {
                    await Task.Delay(1);
                    revoluciones += (aceleracion < 21)?9:(aceleracion-2)/2;
                    
                    cambiarRevoluciones();
                }
                revoluciones = 1000;
                cambiarRevoluciones(); 
                acelerador.IsEnabled = true;
                freno.IsEnabled = true;
            }
            else
            {//Apagar el coche
                button_arrancar.Background = llave_off;
                acelerador.IsEnabled = false;
                freno.IsEnabled = false;
                while (revoluciones > 0)
                { 
                    await Task.Delay(1);

                    revoluciones-= (frenado < 17)?8:(frenado/2); 
                    cambiarRevoluciones();
                }
                revoluciones = 0;
                cambiarRevoluciones();
                edittext_caballos.IsEnabled = true;
            }
        }

        //////Metodos

        //Altera todos los elementos que dependen de las Revoluciones
        public void cambiarRevoluciones()
        {
            texto_revoluciones_digital.Content = revoluciones.ToString();
            RotateTransform rotacion = new RotateTransform(calcularAngulo(revoluciones, max_revoluciones, 270, -135));
            imagen_puntero_revoluciones.RenderTransform = rotacion;
            gradiente_ocultar_revoluciones.StartPoint = new Point(1, 1-(Convert.ToDouble(revoluciones) / max_revoluciones));
        }

        //Calcula el angulo de una imagen segun su valor actual y su maximo
        private int calcularAngulo(int valor, int max, int anguloTotal, int anguloInicio)
        {
            return Convert.ToInt32((Convert.ToDouble(valor) / max) * anguloTotal) + anguloInicio;
        }

        //Establece la frecuencia de los intervalos
        private void ajustarCaballos(int caballos)
        {
            acelerador.Interval = 10000 / caballos;
            freno.Interval = 10000 / caballos;
        }
    }
}
