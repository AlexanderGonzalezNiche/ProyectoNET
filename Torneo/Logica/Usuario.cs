using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo_Clases.Logica
{
    public class Usuario
    {   //Properties
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Ciudad { get; set; }
        public List<Equipo> EquiposFavoritos { get; set; }
        public List<Partido> PartidosEvaluados { get; set; }

        //constructor por defecto
        public Usuario() { }
        //constructor Comun
        public Usuario(string nombre,string apellido,string nomusuario,string pass,string ciudad,List<Equipo> Equifavoritos,List<Partido> parevaluados)
        {
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nomusuario;
            Password = pass;
            Ciudad = ciudad;
            EquiposFavoritos = Equifavoritos;
            PartidosEvaluados = parevaluados;
        }
    }
}
