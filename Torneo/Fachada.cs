using System;
using Torneo_Clases.Value_Objects;
using Torneo_Clases.Acceso_Datos;
using Torneo_Clases.Logicia;
using System.Collections.Generic;

using System.Linq;

namespace Torneo_Clases
{
    public class Fachada
    {
        public Fachada()
        {
        }

        public bool LoginCorrecto(string nombUsuario, string password)
        {
            return this.UsuarioCorrecto(nombUsuario, password);
        }

        private bool UsuarioCorrecto(string nombUsuario, string password)
        {
            DAOUsuarios daoUsuarios = new DAOUsuarios();
            return daoUsuarios.listaUsuarios.Exists(usuario => usuario.NombreUsuario == nombUsuario && usuario.Password == password);
        }

        public bool ExistenEquipos()
        {
            bool existen = false;
            if (this.DevolverEquipos().Any())
            {
                existen = true;
            }
            return existen;
        }

        public bool ExistenPartidos()
        {
            bool existen = false;
            if(this.DevolverPartidos().Any())
            {
                existen = true;
            }
            return existen;
        }

        public bool ExisteUsuario(string nombUsu)
        {
            return DAOUsuarios.ExisteUsuario(nombUsu);
        }

        public List<VOEquipo> DevolverEquipos()
        {
            List<VOEquipo> listaVOEquipos = new List<VOEquipo>();
            DAOEquipos daoEquipos = new DAOEquipos();
            List<Equipo> listaEquipos = daoEquipos.listaEquipos;
            foreach(Equipo eq in listaEquipos)
            {
                VOEquipo voEq = new VOEquipo(eq);
                listaVOEquipos.Add(voEq);
            }
            return listaVOEquipos;
        }

        public List<VOPartido> DevolverPartidos()
        {
            List<VOPartido> listaVOPartidos = new List<VOPartido>();
            DAOPartidos daoPartidos = new DAOPartidos();
            List<Partido> listaPartidos = daoPartidos.listaPartidos;
            foreach(Partido part in listaPartidos)
            {
                VOPartido voPart = new VOPartido(part);
                listaVOPartidos.Add(voPart);
            }
            return listaVOPartidos;
        }
        //Ingresar partido
        public bool AltaPartido(VOPartido part)
        {
            return DAOPartidos.AltaPartido(part.Equipo1.Id, part.Equipo2.Id, part.Estadio, part.Juez, part.Fecha, part.Resultado.Id);
        }

        public bool AgregarResultadoAPartido(VOResultado res, int idPartido)
        {
            return DAOResultados.InsertarResultadoDePartido(idPartido, res.Id, res.GolesEquipo1, res.GolesEquipo2, res.Clima, res.Descripcion);
        }

        //Buscar partidos de fecha
        public List<VOPartido> DevolverPartidosDeFecha(DateTime fecha)
        {
            List<VOPartido> listaVOPartidos = new List<VOPartido>();
            DAOPartidos daoPartidos = new DAOPartidos();
            daoPartidos.CargarPartidosDeFecha(fecha);
            List<Partido> listaPartidos = daoPartidos.listaPartidos;
            foreach (Partido part in listaPartidos)
            {
                VOPartido voPart = new VOPartido(part);
                listaVOPartidos.Add(voPart);
            }
            return listaVOPartidos;
        }

        //Buscar partidos por Equipo
    
        public List<VOPartido> DevolverPartidosDeEquipo(string idEquipo)
        {
            List<VOPartido> listaVOPartidos = new List<VOPartido>();
            DAOPartidos daoPartidos = new DAOPartidos();
            daoPartidos.CargarPartidosDeEquipo(idEquipo);
            List<Partido> listaPartidos = daoPartidos.listaPartidos;
            foreach (Partido part in listaPartidos)
            {
                VOPartido voPart = new VOPartido(part);
                listaVOPartidos.Add(voPart);
            }
            return listaVOPartidos;
        }

        //Buscar partido por fecha y equipo

        public VOPartido DevolverPartidoDeEquipoEnFecha(string idEquipo, DateTime fecha)
        {
            VOPartido partidoRetorno = new VOPartido();
            DAOPartidos daoPartidos = new DAOPartidos();
            daoPartidos.CargarPartidosDeEquipoEnFecha(idEquipo, fecha);
            List<Partido> listaPartidos = daoPartidos.listaPartidos;
            foreach (Partido part in listaPartidos)
            {
                partidoRetorno = new VOPartido(part);
            }
            return partidoRetorno;
        }

        //Alta torneo
        public bool AltaTorneo(VOTorneo torneo)
        {
            return DAOTorneo.AltaTorneo(torneo.Id, torneo.Nombre, torneo.Fecha);
        }

        //Listar datos del torneo
        //ingresar datos de tabla de posiciones
        //estadistiad de la fecha

        //clima 


    }
}
