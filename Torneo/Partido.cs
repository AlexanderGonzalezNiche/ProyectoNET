using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Partido
    {
        public Equipo equipo1 { get; set; }
        public Equipo equipo2 { get; set; }
        public int GolesEquipo1 { get; set; }
        public int GolesEquipo2 { get; set; }
        public string Clima { get; set; }
        public string Estadio { get; set; }
        public string Descripcion { get; set; }
        public string Juez { get; set; }
        public DateTime Fecha { get; set; }


        public Partido() { }
        public Partido(Equipo equi1,Equipo equi2, int goles1,int goles2,string clima,string estadio,string descrip,string juez,DateTime fecha)
        {
            equipo1 = equi1;
            equipo2 = equi2;
            GolesEquipo1 = goles1;
            GolesEquipo2 = goles2;
            Clima = clima;
            Estadio = estadio;
            Descripcion = descrip;
            Juez = juez;
            Fecha = fecha;
        }
    }
}
