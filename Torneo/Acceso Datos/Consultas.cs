using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torneo_Clases.Acceso_Datos
{
    class Consultas
    {
        //USUARIOS
        internal static string ExisteUsuario(string nombreUsuario)
        {
            return "SELECT * FROM Usuarios WHERE NombreUsuario = '" + nombreUsuario.ToString() + "';";
        }

        internal static string DevolverUsuarios()
        {
            return "SELECT NombreUsuario, Password, Nombre, Apellido, Ciudad FROM Usuarios;";
        }

        internal static string AltaUsuario()
        {
            return "INSERT INTO Usuarios(NombreUsuario, Password, Nombre, Apellido, Ciudad) VALUES (@NombreUsuario, @Password, @Nombre, @Apellido, @Ciudad);";
        } 

        internal static string EliminarUsuario()
        {
            return "DELETE FROM Usuarios WHERE Usuario = @NombreUsuario;";
        }

        //EQUIPOS
        internal static string DevolverEquipos()
        {
            return "SELECT Id, Nombre, Ciudad, DT FROM Equipos;";
        }

        internal static string ObtenerEquipoPorID(int idEquipo)
        {
            return "SELECT Id, Nombre, Ciudad, DT FROM Equipos WHERE Id = " + idEquipo.ToString() + ";";
        }

        //RESULTADOS

        internal static string DevolverResultados()
        {
            return "SELECT IDPartido, GolesEquipo1, GolesEquipo2, Clima, Descripcion FROM Resultados;";
        }

        internal static string ObtenerResultadoPorPartido(int idPartido)
        {
            return "SELECT IDPartido, GolesEquipo1, GolesEquipo2, Clima, Descripcion FROM Resultados WHERE IDPartido = " + idPartido.ToString() + ";";
        }

        //PARTIDOS

        internal static string DevolverPartidos()
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos;";
        }

        internal static string ObtenerPartidoPorID(int idPartido)
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos WHERE IDPartido = " + idPartido.ToString() + ";";
        }
    }
}
