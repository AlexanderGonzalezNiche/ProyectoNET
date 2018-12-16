using System;
using Torneo_Clases.Logica;

namespace Torneo_Clases.Value_Objects
{
    [Serializable]
    public class VOUsuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Ciudad { get; set; }
       
        public VOUsuario()
        {
        }

        public VOUsuario(Usuario usu)
        {
            this.Nombre = usu.Nombre;
            this.Apellido = usu.Apellido;
            this.NombreUsuario = usu.NombreUsuario;
            this.Password = usu.Password;
            this.Ciudad = usu.Ciudad;
        }

        public override string ToString()
        {
            return this.NombreUsuario;
        }
    }
}