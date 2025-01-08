using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Pedido
    {
        public string nombre {  get; private set; }
        public string direccion { get; private set; }
        public int telefono { get; private set; }
        public List<Producto> productos { get; private set; }
        //Futuro -> Fecha hora, a domicilio

        public Pedido(string nombre, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = Convert.ToInt32(telefono);
            productos = new List<Producto>();
        }
    }
}
