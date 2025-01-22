using RecuperacionComponentes.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperacionComponentes
{
    public partial class ListaPalabras : UserControl
    {
        int _max_items = 10, _max_length = 20;

        //Propiedades del componente
        [Browsable(true), Category("Ajustes"), Description("Numero máximo de elementos del listbox")]
        public int Max_Items {
            get {
                return _max_items;
            }
            set{
                _max_items = value;
                trackBar.Maximum = _max_items;
            } 
        }

        [Browsable(true), Category("Ajustes"), Description("Numero máximo de caracteres de los elementos del listbox")]
        public int Max_Length {
            get
            {
                return _max_length;
            }
            set
            {
                _max_length = value;
                textbox_input.MaxLength = _max_length;
            }
        }

        [Browsable(true), Category("Ajustes"), Description("Numero máximo de caracteres de los elementos del listbox")]
        public Color Slider_Background { 
            get
            {
                return trackBar.BackColor;
            }
            set
            {
                trackBar.BackColor = value;
            }
        }

        [Browsable(true), Category("Ajustes"), Description("Numero máximo de caracteres de los elementos del listbox")]
        public ListBox.ObjectCollection ListBox_Items {
            get
            {
                return listbox.Items;
            }
        }

        //Eventos del componente
        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado al insertar un valor en la lista")]
        public event EventHandler ItemInsertado;

        public ListaPalabras()
        {
            InitializeComponent();
            //Establece los valores iniciales
            textbox_input.MaxLength = _max_length;
            trackBar.Maximum = _max_items;
            trackBar.Value = listbox.Items.Count;
        }

        //Borrar un elemento al presionar la tecla retroceso "Back"
        private void listbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                listbox.Items.Remove(listbox.SelectedItem);
                textbox_input.BackColor = SystemColors.Window;
                textbox_input.Enabled = true;
                trackBar.Value = listbox.Items.Count;
            }
        }

        //Inserta si es posible, un nuevo elemento en la lista al presionar "Enter"
        private void textbox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (listbox.Items.Count < _max_items)
                {
                    listbox.Items.Add(textbox_input.Text);
                    trackBar.Value =  listbox.Items.Count;
                    textbox_input.Clear();
                    //Llama al evento Item Insertado
                    if (this.ItemInsertado != null)
                    {

                        ItemInsertado(this, new EventArgs());
                    }
                }
                else
                {
                    textbox_input.BackColor = Color.Red;
                    textbox_input.Enabled = false;
                }
            }
        }
    }
}
