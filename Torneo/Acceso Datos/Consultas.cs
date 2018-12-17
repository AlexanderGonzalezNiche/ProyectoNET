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
        internal static string AltaEquipo()
        {
            return "INSERT INTO Equipos(IdEquipo, Nombre, Ciudad, DT, Puntos) VALUES (@IdEquipo, @Nombre, @Ciudad, @DT, @Puntos);";
        }
        
        internal static string DevolverEquipos()
        {
            return "SELECT Id, Nombre, Ciudad, DT FROM Equipos;";
        }

        internal static string ObtenerEquipoPorID(int idEquipo)
        {
            return "SELECT Id, Nombre, Ciudad, DT FROM Equipos WHERE Id = " + idEquipo.ToString() + ";";
        }

        internal static string EliminarEquipo()
        {
            return "DELETE FROM Equipos WHERE IdEquipo = @idEquipo;";
        }
        //RESULTADOS

        internal static string DevolverResultados()
        {
            return "SELECT IDPartido, GolesEquipo1, GolesEquipo2, Clima, Descripcion FROM Resultados;";
        }

        internal static string ObtenerResultadoPorPartido(int idPartido)
        {
            return "SELECT IDPartido, GolesEquipo1, GolesEquipo2, Clima, Descripcion FROM Resultados WHERE IdPartido = " + idPartido.ToString() + ";";
        }
        
        internal static string AgregarResultadoAPartido(int idPartido)
        {
            return "UPDATE Resultado SET IdResultado = @IdResultado, GolesEquipo1 = @GolesEquipo1, GolesEquipo2 = @GolesEquipo2, Clima = @Clima, Descripcion = @Descripcion WHERE IdPartido = "+ idPartido.ToString() + "; ";
        }
        //PARTIDO

        internal static string AltaPartido()
        {
            return "INSERT INTO Partidos(IDPartido, IDTorneo, Equipo1, Equipo2, Estadio, Juez, Fecha) VALUES (@IDPartido, @Equipo1, @Equipo2, @Estadio, @Juez, @Fecha)";
        }

        internal static string DevolverPartidos()
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos;";
        }

        internal static string ObtenerPartidoPorID(int idPartido)
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos WHERE IDPartido = " + idPartido.ToString() + ";";
        }

        internal static string ObtenerPartidosDeFecha(DateTime fecha)
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos WHERE Fecha = " + fecha.ToShortDateString() + ";";
        }

        internal static string ObtenerPartidosDeEquipo(string idEquipo)
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos WHERE IdEquipo1 = " + idEquipo + " OR idEquipo2 = " + idEquipo + ";";
        }

        internal static string ObtenerPartidosDeEquipoEnFecha(string idEquipo, DateTime fecha)
        {
            return "SELECT IDPartido, IdEquipo1, IdEquipo2, Estadio, Juez, Fecha FROM Partidos WHERE Fecha = " + fecha.ToShortDateString() + " AND  IdEquipo1 = " + idEquipo + " OR idEquipo2 = " + idEquipo + ";";
        }

        internal static string ModificarPartido()
        {
            return "UPDATE Partidos SET Usuario= @NickName, Password =  Password, Nombre = @Nombre, Apellido = @Apellido, Cedula = @Cedula, Direccion = @Direccion, IdPerfil = @IdPerfil WHERE Usuario = @NickNameAnterior;";

        }

        internal static string EliminarPartido()
        {
            return "DELETE FROM Partidos WHERE IdPartido = @idPartido;";
        }

        //TORNEO
        internal static string DevolverTorneos()
        {
            return "SELECT IDTorneo, Nombre, Fecha FROM Torneos;";
        }

        internal static string AltaTorneo()
        {
            return "INSERT INTO Torneos(IDTorneo, Nombre, Fecha)";//TODO: Falta la lista de equipos y partidos
        }
    }
}
