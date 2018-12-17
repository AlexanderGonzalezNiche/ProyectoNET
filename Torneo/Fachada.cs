using System;
using Torneo_Clases.Value_Objects;
using Torneo_Clases.Acceso_Datos;
using Torneo_Clases.Logica;
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

        public bool ExisteEquipo(int idEquipo)
        {
            Equipo eq = new Equipo();
            bool retorno = false;
            eq = DAOEquipos.ObtenerEquipoPorID(idEquipo);
            if (eq != null)
            {
                retorno = true;
            }
            return retorno;
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

        public bool EliminarEquipo(VOEquipo unEquipo)
        {
            return DAOEquipos.EliminarEquipo(unEquipo.Id);
        }

        public List<VOPartido> DevolverPartidos()
        {
            List<VOPartido> listaVOPartidos = new List<VOPartido>();
            DAOPartidos daoPartidos = new DAOPartidos();
            List<Partido> listaPartidos = daoPartidos.listaPartidos ;
            foreach(Partido part in listaPartidos)
            {
                VOPartido voPart = new VOPartido(part);
                listaVOPartidos.Add(voPart);
            }
            return listaVOPartidos;
        }

        public bool ExisteTorneo()
        {
            Torneo tor = new Torneo();
            bool retorno = false;
            tor = DAOTorneo.ObtenerTorneo();
            if (tor.Nombre != null)
            {
                retorno = true;
            }
            return retorno;
        }

        public VOTorneo ObtenerTorneo()
        {
            if (this.ExisteTorneo())
            {
                VOTorneo torneoRetorno = new VOTorneo();
                DAOTorneo daoTorneo = new DAOTorneo();
                torneoRetorno = new VOTorneo(DAOTorneo.ObtenerTorneo());
                return torneoRetorno;
            }
            else
            {
                return null;
            }
         
        }

        public bool ExistePartido(int idPartido)
        {
            Partido part = new Partido();
            bool retorno = false;
            part = DAOPartidos.ObtenerPartidoPorID(idPartido);
           if (part != null)
            {
                retorno = true;
            }
            return retorno;
        }

        //Altas
        //Alta  Equipo
        public bool AltaEquipo(VOEquipo eq)
        {
            return DAOEquipos.AltaEquipo(eq.Id, eq.Nombre, eq.Ciudad, eq.DT, eq.Puntos);
        }
       
        //Alta partido
        public bool AltaPartido(VOPartido part)
        {
            return DAOPartidos.AltaPartido(part.Id, part.IdTorneo, part.Equipo1.Id, part.Equipo2.Id, part.Estadio, part.Juez, part.Fecha, part.Resultado.Id);
        }

        //Alta torneo
        public bool AltaTorneo(VOTorneo torneo)
        {   
            return DAOTorneo.AltaTorneo(torneo.Id, torneo.Nombre, torneo.Año);
        }

        //Baja torneo 
        public bool EliminarTorneo()
        {
            return DAOTorneo.EliminarTorneo();
        }

        //Ingresar resultado a partido
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

        

        

        //Listar datos del torneo
        //ingresar datos de tabla de posiciones
        //estadistiad de la fecha

        //clima 
        public string DevolverClimaPorCiudad(String ciudad)
        {
            var ws = new servicioWebClima.WebServiceClima();

            double temp = ws.darTemperatura(ciudad);
            double velViento = ws.darVelocidadViento(ciudad);
            string nubocidad = ws.darNubosidad(ciudad);

            string clima = "El clima estaba: " + nubocidad + " temperatura " + temp + " velocidad del viento " + velViento;
            return clima;
        }

    }
}
