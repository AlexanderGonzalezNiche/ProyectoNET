using System;
using Torneo_Clases.Logica;
using System.Runtime.Serialization;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    [DataContract]
    public class VOEquipo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string DT { get; set; }
        public int Puntos { get; set; }

        public VOEquipo()
        {
        }

        public VOEquipo(Equipo equipo)
        {
            this.Id = equipo.Id;
            this.Nombre = equipo.Nombre;
            this.Ciudad = equipo.Ciudad;
            this.DT = equipo.DT;
            this.Puntos = 0;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
