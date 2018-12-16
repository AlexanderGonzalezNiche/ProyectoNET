using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Torneo_Clases.Logica;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    [DataContract]
    public class VOTorneo
    {
        [DataMember]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public List<VOEquipo> Equipos { get; set; }
        public List<VOPartido> Partidos { get; set; }

        public VOTorneo()
        {
        }

        public VOTorneo(Torneo torneo)
        {
            this.Id = torneo.Id;
            this.Nombre = torneo.Nombre;
            this.Fecha = torneo.Fecha;
        }

    }

   



}
