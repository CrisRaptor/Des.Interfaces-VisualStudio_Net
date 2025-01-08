using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformeCiudades
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            loadComboBoxData(comboBoxDatos, (Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString() + "\\Data\\"));
            if (comboBoxDatos.Items.Count > 0)
            {
                comboBoxDatos.SelectedIndex = 0;
            } else
            {
                buttonMostrarCiudades.Enabled = false;
            }
        }

        //Devuelve la lista de ciudades
        private List<Ciudad> leerCsv(string ruta)
        {
            //Lee toda las lineas del archivo (menos la primera), cada linea genera un objeto Ciudad y lo convierte en una lista
            List<Ciudad> ciudades = File.ReadAllLines(ruta).Skip(1).Select(linea => ciudadDesdeCsv(linea)).ToList();
            return ciudades;
        }

        //Crea un objeto ciudad a partir de una linea
        private Ciudad ciudadDesdeCsv(string linea)
        {
            //Divide los datos
            string[] csv = linea.Split(';');
            Ciudad ciudad = new Ciudad();
            //Asigna los valores
            if (csv.Length >= 5)
            {
                ciudad.Name = csv[0];
                ciudad.Latitude = csv[1];
                ciudad.Longitude = csv[2];
                ciudad.Population = int.Parse(csv[3]);
                ciudad.Timezone = csv[4];
            }
            return ciudad;
        }

        //Busca los radiobutton marcados y los desmarca
        private void buttonResetZonaHoraria_Click(object sender, EventArgs e)
        {
            groupTimeZone.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
        }

        //Crea un formulario Ciudades, le pasa los datos asignando propiedades y lo muestra
        private void buttonMostrarCiudades_Click(object sender, EventArgs e)
        {
            
            //El boton solo funciona si se indica un fichero en el combobox
            if (comboBoxDatos != null)
            {
                //Crea el formulario
                Ciudades ciudadesForm = new Ciudades();

                //Calcula la ruta del fichero
                string ruta = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()+ "\\Data\\" + comboBoxDatos.Items[comboBoxDatos.SelectedIndex].ToString();
                
                //Establece los valores del formulario
                ciudadesForm.Busqueda = textBoxBuscarCiudad.Text; //Filtro de busqueda de una ciudad
                ciudadesForm.CiudadesGrandes = checkBoxCiudadesGrandes.Checked;//Filtro Booleano de ciudades grandes
                //Filtro de zonahoraria
                string zonaHoraria = "";
                //Busca si hay una zona horaria indicada en el groupbox
                foreach (RadioButton radioButton in groupTimeZone.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked)
                    {
                        zonaHoraria = "/"+radioButton.Text.ToString();
                    }
                }
                //Si no se indica la zona horaria es "America", sino se le añade "/" y la zona horaria indicada
                ciudadesForm.ZonaHoraria = "America"+zonaHoraria;

                //Lee los datos del archivo, pasandolos a una lista del objeto Ciudad
                List<Ciudad> listaCiudades = leerCsv(ruta);
                //Traspasa los datos a la propiedad del formulario
                ciudadesForm.listaCiudades = listaCiudades;

                //Muestra el formulario
                ciudadesForm.Show();
            }
        }

        private void loadComboBoxData(ComboBox comboBox, string directorio)
        {
            comboBox.Items.Clear();
            foreach (string file in Directory.GetFiles(directorio, "*", SearchOption.AllDirectories).Select(file => Path.GetFileName(file)))
            {
                comboBox.Items.Add(file);
            }
        }
    }
}
