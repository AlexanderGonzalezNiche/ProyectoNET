using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_Clases.Logicia
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public List<Equipo> Equipos { get; set; }
        public List<Partido> Partidos { get; set; }
    }
}
