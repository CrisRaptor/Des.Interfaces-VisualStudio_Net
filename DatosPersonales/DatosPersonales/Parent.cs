using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosPersonales
{
    internal class Parent
    {
        public int id;
        static int idCount = 0;
        public string name { get; set; }
        public string apellidos { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public int childCount { get; set; }
        public List<string> childs = new List<string>() { };

        public Parent (string name, string apellidos, string address, string phone, int childCount)
        {
            idCount++;
            this.id = idCount;
            this.name = name;
            this.apellidos = apellidos;
            this.address = address;
            this.phone = phone;
            this.childCount = childCount;
            for (int i = 0; i < childCount; i++) {
                childs.Add("¿?");
            }
        }
    }
}
