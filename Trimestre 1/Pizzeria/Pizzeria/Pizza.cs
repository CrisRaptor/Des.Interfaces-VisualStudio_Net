using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Pizza : Producto
    {
        public static string[] medidas = new string[] { "Pequeña", "Mediana", "Grande" };
        public static string[] posiblesIngredientes = new string[] { "Queso", "Tomate", "Jamon", "Champiñones", "Piña", "Bacon", "Salsa carbonara" };

        public string tamaño { get; set; }
        List<string> ingredientes;

        public Pizza(string medida, List<string> ingredientes)
        {
            this.tamaño = medida;
            this.ingredientes = ingredientes;
            switch (tamaño)
            {
                case "Pequeña":
                    precio = 6;
                    break;
                case "Grande":
                    precio = 10;
                    break;
                default:
                    precio = 8;
                    break;
            }
        }
    }
}
