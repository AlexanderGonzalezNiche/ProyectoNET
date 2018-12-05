﻿using System;
using System.Runtime.Serialization;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    [DataContract]
    public class VOPartido
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public VOEqupo Equipo1 { get; set; }
        public VOEqupo Equipo2 { get; set; }
        public string Estadio { get; set; }
        public string Juez { get; set; }
        public DateTime Fecha { get; set; }
        public VOResultado Resultado { get; set; }

        public VOPartido()
        {

        }
        public VOPartido(Partido partido)
        {
            this.Id = partido.Id;
            this.Equipo1 = new VOEqupo(partido.Equipo1);
            this.Equipo2 = new VOEqupo(partido.Equipo2);
            this.Estadio = partido.Estadio;
            this.Juez = partido.Juez;
            this.Fecha = partido.Fecha;
            this.Resultado = new VOResultado(partido.Resultado);
         }
    }

}
