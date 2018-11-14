using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Torneo
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public List<Equipo> Equipo { get; set; }
        public List<Partido> Par { get; set; }

        public Torneo() { }
        public Torneo(string nombre, DateTime fecha,List<Equipo> equi,List<Partido> par)
        {
            Nombre = nombre;
            Fecha = fecha;
            Equipo = equi;
            Par = par;


        }


    }
}
