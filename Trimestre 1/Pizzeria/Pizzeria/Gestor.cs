using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Gestor
    {
        public Gestor() { }

        public int contarPizzas(Pedido pedido)
        {
            int cantPizzas = 0;
            foreach (Producto p in pedido.productos)
            {
                if (p is Pizza)
                {
                    cantPizzas++;
                }
            }
            return cantPizzas;
        }

        public int contarBebidas(Pedido pedido)
        {
            int cantPizzas = 0;
            foreach (Producto p in pedido.productos)
            {
                if (p is Bebida)
                {
                    cantPizzas++;
                }
            }
            return cantPizzas;
        }

        public int contarPostres(Pedido pedido)
        {
            int cantPizzas = 0;
            foreach (Producto p in pedido.productos)
            {
                if (p is Postre)
                {
                    cantPizzas++;
                }
            }
            return cantPizzas;
        }

        }
}
