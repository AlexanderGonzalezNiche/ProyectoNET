using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo_Clases.Acceso_Datos;

namespace Torneo_Clases.Logicia
{
    public class Torneo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public DAOEquipos Equipos { get; set; }
        public DAOPartidos Partidos { get; set; }
    }
}
