using System;
using System.Runtime.Serialization;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    [DataContract]
    public class VOResultado
    {
        [DataMember]
        public VOPartido Partido { get; set; }
        public int GolesEquipo1 { get; set; }
        public int GolesEquipo2 { get; set; }
        public string Clima { get; set; }
        public string Descripcion { get; set; }

        public VOResultado()
        {

        }

        public VOResultado(Resultado res)
        {
            this.Partido = new VOPartido(res.Partido);
            this.GolesEquipo1 = res.GolesEquipo1;
            this.GolesEquipo2 = res.GolesEquipo2;
            this.Clima = res.Clima;
            this.Descripcion = res.Descripcion;
        }

    }
}
