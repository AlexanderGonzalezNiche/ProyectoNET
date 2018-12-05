using System;
using Torneo_Clases.Logicia;
using System.Runtime.Serialization;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    [DataContract]
    public class VOEqupo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string DT { get; set; }

        public VOEqupo()
        {

        }
        public VOEqupo(Equipo equipo)
        {
            this.Id = equipo.Id;
            this.Nombre = equipo.Nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
