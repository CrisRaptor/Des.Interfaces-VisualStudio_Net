using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Postre : Producto
    {
        public static string[] opciones = new string[] {"Tarta Tres Chocolates", "Tarta Queso", "Helado Nata", "Arroz Con Leche" };

        public string postre;

        public Postre(string eleccion)
        {
            this.postre = eleccion;
            this.precio = 3;
        }
    }
}
