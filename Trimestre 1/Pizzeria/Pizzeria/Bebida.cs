using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Bebida : Producto
    {
        public static string[] medidas = new string[] { "Pequeña", "Mediana", "Grande" };

        public static string[] sabores = new string[] { "CocaCola", "Fanta Naranja", "Fanta Limon", "Agua" };

        public string tamaño { get; set; }
        public string sabor {  get; set; }

        public Bebida(string tamaño, string sabor)
        {
            this.tamaño = tamaño;
            this.sabor = sabor;
            switch (this.tamaño)
            {
                case "Pequeña":
                    precio = 2;
                    break;
                case "Grande":
                    precio = 4;
                    break;
                default: //Mediana
                    precio = 3;
                    break;
            }
        }
    }
}
