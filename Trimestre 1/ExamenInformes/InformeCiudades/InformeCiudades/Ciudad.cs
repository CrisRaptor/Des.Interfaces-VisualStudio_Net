using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeCiudades
{
    public class Ciudad
    {
        public string Name {  get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Population { get; set; }
        public string Timezone { get; set; }
        public Ciudad() { }

        public Ciudad(string name, string latitude, string longitude, int population, string timezone)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Population = population;
            Timezone = timezone;
        }
    }
}
