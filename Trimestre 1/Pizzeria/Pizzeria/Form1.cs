using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pizzeria.Postre;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        static Pedido pedido;
        static Gestor gestor = new Gestor();
        List<string> ingredientes;
        public Form1()
        {
            InitializeComponent();
            //Carga los comboBox
            establecerComboBox(pizzaTamañoComboBox, Pizza.medidas);
            establecerComboBox(ingredientesComboBox, Pizza.posiblesIngredientes);
            establecerComboBox(bebidaTamañoComboBox, Bebida.medidas);
            establecerComboBox(bebidaSaborComboBox, Bebida.sabores);
            establecerComboBox(postreComboBox, Postre.opciones);
            //Establece los maximos de ProgresBarr
            pizzaProgressBar.Maximum = pizzaCountTrackBar.Value;
            bebidasProgressBar.Maximum = bebidaCountTrackBar.Value;
            postreProgressBar.Maximum = postreCountTrackBar.Value;
        }

        //Telefono solo numeros
        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //Habilita el resto del campos al indicar un cliente válido
        private void comenzarPedioButton_Click(object sender, EventArgs e)
        {
            if(nombreClienteTextBox.Text.Length>0 && direccionTextBox.Text.Length > 0 && telefonoTextBox.Text.Length > 0)
            {
                pedido = new Pedido(nombreClienteTextBox.Text, direccionTextBox.Text, telefonoTextBox.Text);
                productosPanel.Enabled = true;
                insercionAlimentosPanel.Enabled = true;
            }
        }

        private void pizzaCountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            establecerCantidadEnLabels(pizzaCountLabel, cantPizzasInsertadasLabel, pizzaCountTrackBar, "Pizza", gestor.contarPizzas(pedido));
            pizzaProgressBar.Maximum = pizzaCountTrackBar.Value;
            if (pizzaProgressBar.Maximum != 0)
            {
                pizzaButton.Enabled = true;
            }
        }

        
        private void bebidaCountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            establecerCantidadEnLabels(bebidaCountLabel, cantBebidasInsertadasLabel, bebidaCountTrackBar, "Bebida", gestor.contarBebidas(pedido));
            bebidasProgressBar.Maximum = bebidaCountTrackBar.Value;
            if (bebidasProgressBar.Maximum != 0)
            {
                bebidaButton.Enabled = true;
            }
        }

        private void postreCountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            establecerCantidadEnLabels(postreCountLabel, cantPostresInsertadosLabel, postreCountTrackBar, "Postre", gestor.contarPostres(pedido));
            postreProgressBar.Maximum = postreCountTrackBar.Value;
            if (postreProgressBar.Maximum != 0)
            {
                postreButton.Enabled = true;
            }
        }


        ///////Metodos Propios///////
        //Establece los textos de las 2 trackbars indicadas segun el valor de la trackBar indicada
        private void establecerCantidadEnLabels(Label labelTrackbar, Label labelProgressBar, TrackBar trackBar, string producto, int cant)
        {
            string cadena = "";
            if (trackBar.Value != 1)
            {
                cadena = trackBar.Value.ToString() + " " + producto + "s";
            }
            else
            {
                cadena = "1 " + producto;
            }
            labelTrackbar.Text = cadena;


            labelProgressBar.Text = cant + " de " + trackBar.Value.ToString();
        }

        private void establecerComboBox(ComboBox comboBox, string[] opciones) {
            comboBox.Items.Clear();
            foreach (string opcion in opciones)
            {
                comboBox.Items.Add(opcion);
            }
        }


        private void pizzaButton_Click(object sender, EventArgs e)
        {
            if (pizzaProgressBar.Maximum != 0)
            {
                if (pizzaTamañoComboBox.SelectedItem != null && ingredientesListBox.Items.Count > 0)
                {
                    pizzaProgressBar.Value++;

                    List<string> ingredientes = new List<string>();
                    foreach (string ing in ingredientesListBox.Items)
                    {
                        ingredientes.Add(ing.ToString());
                    }

                    Pizza pizza = new Pizza(pizzaTamañoComboBox.SelectedItem.ToString(), ingredientes);
                    pedido.productos.Add(pizza);

                    gestor.contarPizzas(pedido);

                    TreeNode pizzaNode = new TreeNode("Pizza " + pizza.tamaño.ToString());
                    foreach (string ing in ingredientes)
                    {
                        pizzaNode.Nodes.Add(ing);
                    }
                    pedidoTreeView.Nodes.Add(pizzaNode);

                    pizzaTamañoComboBox.SelectedItem = null;
                    ingredientesComboBox.SelectedItem = null;
                    ingredientesListBox.Items.Clear();
                }
            }

            if (pizzaProgressBar.Value == pizzaProgressBar.Maximum)
            {
                pizzaButton.Enabled = false;
            }
        }

        private void bebidaButton_Click(object sender, EventArgs e)
        {
            if (bebidasProgressBar.Maximum != 0)
            {
                if (bebidaTamañoComboBox.SelectedItem != null && bebidaSaborComboBox.SelectedItem != null)
                {
                    bebidasProgressBar.Value++;
                    
                    Bebida bebida = new Bebida(bebidaTamañoComboBox.SelectedItem.ToString(), bebidaSaborComboBox.SelectedItem.ToString());
                    pedido.productos.Add(bebida);

                    TreeNode bebidaNode = new TreeNode("Bebida " + bebida.tamaño.ToString());
                    bebidaNode.Nodes.Add("Sabor " + bebida.sabor);
                    pedidoTreeView.Nodes.Add(bebidaNode);

                    gestor.contarBebidas(pedido);

                    bebidaTamañoComboBox.SelectedItem = null;
                    bebidaSaborComboBox.SelectedItem = null;
                }
            }
               
            if (bebidasProgressBar.Value == bebidasProgressBar.Maximum)
            {
                bebidaButton.Enabled = false;
            }
        }

        private void postreButton_Click(object sender, EventArgs e)
        {
            if (postreProgressBar.Maximum != 0)
            {
                if (postreComboBox.SelectedItem != null)
                {
                    postreProgressBar.Value++;
                    
                    Postre postre = new Postre(postreComboBox.SelectedItem.ToString());
                    pedido.productos.Add(postre);

                    TreeNode postreNode = new TreeNode("Postre");
                    postreNode.Nodes.Add(postre.postre.ToString());
                    pedidoTreeView.Nodes.Add(postreNode);

                    gestor.contarPostres(pedido);

                    postreComboBox.SelectedItem = null;
                }
            }

            if (postreProgressBar.Value == postreProgressBar.Maximum)
            {
                postreButton.Enabled = false;
            }
        }

        private void ingredienteButton_Click(object sender, EventArgs e)
        {
            if (ingredientesListBox.Items.Count < 10)
            {
                if (ingredientesComboBox.SelectedItem != null)
                {
                    ingredientesListBox.Items.Add(ingredientesComboBox.SelectedItem.ToString());
                    ingredientesComboBox.Items.RemoveAt(ingredientesComboBox.SelectedIndex);
                }
            } 

            if (ingredientesListBox.Items.Count == 10)
            {
                ingredienteButton.Enabled = false;
            }
        }
    }
}
