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
        int _revoluciones = 0, _max_revoluciones;
        const int ACELERACION = 21, FRENADO = 17;
        public MainWindow()
        {
            InitializeComponent();
            //Inicializar variable
            _max_revoluciones = Convert.ToInt32(edittext_max_revoluciones.Text);

            //Ajustar caballos
            ajustarCaballos(Convert.ToInt32(edittext_caballos.Text));
        }


        //////Eventos de controladores
        
        //Ajusta los caballos a un maximo y minimo
        private void edittext_max_revoluciones_Copiar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Variables
            int min_caballos = 50, max_caballos = 200;

            //Limite de caballos
            if (Convert.ToInt64(edittext_caballos.Text) > max_caballos)
            {
                edittext_caballos.Text = max_caballos.ToString();
            } else if (Convert.ToInt64(edittext_caballos.Text) < min_caballos)
            {
                edittext_caballos.Text = min_caballos.ToString();
            }
            ajustarCaballos(Convert.ToInt32(edittext_caballos.Text));
        }

        //Repeat Button de Acelerador
        private void acelerador_Click(object sender, RoutedEventArgs e)
        {
            _revoluciones += ACELERACION;
            _revoluciones = _revoluciones > _max_revoluciones ? _max_revoluciones:_revoluciones;
            cambiarRevoluciones();
        }

        //Repeat Button de Freno
        private void freno_Click(object sender, RoutedEventArgs e)
        {
            int rev_minimas_arrancado = 1000;
            _revoluciones -= FRENADO;
            _revoluciones = _revoluciones < rev_minimas_arrancado ? rev_minimas_arrancado : _revoluciones;
            cambiarRevoluciones();
        }


        //Arranca o apaga el coche con el boton de llaves
        private async void button_arrancar_Click(object sender, RoutedEventArgs e)
        {
            //Variables
            int aceleracion_minima = 21, frenado_minimo = 17, ratio_arranque_ms = 1;
            int revoluciones_arranque = 1000, revoluciones_arranque_apagado = 0;

            //Imagen para las llaves, encendidoç
            ImageBrush llave_on = new ImageBrush();
            Uri uri1 = new Uri("Images/llave-on.png", UriKind.Relative);
            StreamResourceInfo streamInfo1 = Application.GetResourceStream(uri1);
            llave_on.ImageSource = BitmapFrame.Create(streamInfo1.Stream);

            //Imagen para las llaves, apagado
            ImageBrush llave_off = new ImageBrush();
            Uri uri2 = new Uri("Images/llave-off.png", UriKind.Relative);
            StreamResourceInfo streamInfo2 = Application.GetResourceStream(uri2);
            llave_off.ImageSource = BitmapFrame.Create(streamInfo2.Stream);

            if (_revoluciones <= 0)
            {//Encender el coche
                button_arrancar.Background = llave_on;
                button_arrancar.IsEnabled = false;
                edittext_caballos.IsEnabled = false;
                while (_revoluciones < revoluciones_arranque)
                {
                    await Task.Delay(ratio_arranque_ms);
                    _revoluciones += (((ACELERACION < aceleracion_minima) ? aceleracion_minima : ACELERACION)-2)/2;
                    
                    cambiarRevoluciones();
                }
                _revoluciones = revoluciones_arranque;
                cambiarRevoluciones(); 
                acelerador.IsEnabled = true;
                freno.IsEnabled = true;
                button_arrancar.IsEnabled = true;
            }
            else
            {//Apagar el coche
                button_arrancar.Background = llave_off;
                button_arrancar.IsEnabled = false;
                acelerador.IsEnabled = false;
                freno.IsEnabled = false;
                while (_revoluciones > revoluciones_arranque_apagado)
                { 
                    await Task.Delay(ratio_arranque_ms);

                    _revoluciones-= ((FRENADO < frenado_minimo) ?(frenado_minimo):(FRENADO)) / 2; 
                    cambiarRevoluciones();
                }
                _revoluciones = revoluciones_arranque_apagado;
                cambiarRevoluciones();
                edittext_caballos.IsEnabled = true;
                button_arrancar.IsEnabled = true;
            }
        }

        //////Metodos

        //Altera todos los elementos que dependen de las Revoluciones
        public void cambiarRevoluciones()
        {
            //Variables
            int angulo_total = 270, angulo_inicial = -135;

            //Ajustar elementos
            texto_revoluciones_digital.Content = _revoluciones.ToString();
            RotateTransform rotacion = new RotateTransform(calcularAngulo(_revoluciones, _max_revoluciones, angulo_total, angulo_inicial));
            imagen_puntero_revoluciones.RenderTransform = rotacion;
            gradiente_ocultar_revoluciones.StartPoint = new Point(1, 1-(Convert.ToDouble(_revoluciones) / _max_revoluciones));
        }

        //Calcula el angulo de una imagen segun su valor actual y su maximo
        private int calcularAngulo(int valor, int max, int angulo_total, int angulo_inicio)
        {
            return Convert.ToInt32((Convert.ToDouble(valor) / max) * angulo_total) + angulo_inicio;
        }

        //Establece la frecuencia de los intervalos
        private void ajustarCaballos(int caballos)
        {
            int ratio = 2000; //en ms
            acelerador.Interval = ratio / caballos;
            freno.Interval = ratio / caballos;
        }
    }
}
