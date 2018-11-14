using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string DT { get; set; }

        public Equipo() { }
        public Equipo(string nombre,string ciudad, string dt)
        {
            Nombre = nombre;
            Ciudad = ciudad;
            DT = dt;
        }
            


    }
}
