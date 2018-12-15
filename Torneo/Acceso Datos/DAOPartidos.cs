using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Acceso_Datos
{
    public class DAOPartidos
    {
        public List<Partido> listaPartidos { get; set; }
        public DAOPartidos()
        {
            listaPartidos = new List<Partido>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverPartidos(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Partido part = new Partido();
                        part.Id = myReader.GetInt32(0);
                        part.Equipo1 = DAOEquipos.ObtenerEquipoPorID(myReader.GetInt32(1));
                        part.Equipo2 = DAOEquipos.ObtenerEquipoPorID(myReader.GetInt32(2));
                        part.Estadio = myReader.GetString(3);
                        part.Juez = myReader.GetString(4);
                        part.Fecha = myReader.GetDateTime(5);
                        listaPartidos.Add(part);
                    }
                }
                else
                {
                    Console.WriteLine("No hay partidos en el Sistema");
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
        }

        public static Partido ObtenerPartidoPorID(int idPartido)
        {
            Partido part = new Partido();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.ObtenerPartidoPorID(idPartido), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        part.Id = myReader.GetInt32(0);
                        part.Equipo1 = DAOEquipos.ObtenerEquipoPorID(myReader.GetInt32(1));
                        part.Equipo2 = DAOEquipos.ObtenerEquipoPorID(myReader.GetInt32(2));
                        part.Estadio = myReader.GetString(3);
                        part.Juez = myReader.GetString(4);
                        part.Fecha = myReader.GetDateTime(5);
                    }
                }
                else
                {
                    Console.WriteLine("Error de consistencia");
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
            return part;
        }


        internal static bool AltaPartido(int idPart, int idTorneo, int idEq1, int idEq2, string estadio, string juez, DateTime fecha, int idRes)
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myCommand = new SqlCommand(Consultas.AltaPartido(), myConnection);
                myCommand.Parameters.AddWithValue("@IdPartifo", idPart);
                myCommand.Parameters.AddWithValue("@IdTorneo", idTorneo);
                myCommand.Parameters.AddWithValue("@Equipo1", idEq1);
                myCommand.Parameters.AddWithValue("@Equipo2", idEq2);
                myCommand.Parameters.AddWithValue("@Estadio", estadio);
                myCommand.Parameters.AddWithValue("@Juez", juez);
                myCommand.Parameters.AddWithValue("@Fecha", fecha);
                myCommand.Parameters.AddWithValue("@Resultado", idRes);

                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                vSalida = false;
            }
            finally
            {
                myConnection.Close();
            }
            return vSalida;
        }

        internal static bool ModificarPartido(int idPart, int idEq1, int idEq2, string estadio, string juez, DateTime fecha, int idRes)
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myCommand = new SqlCommand(Consultas.ModificarPartido(), myConnection);
                myCommand.Parameters.AddWithValue("@Id", idPart);
                myCommand.Parameters.AddWithValue("@IdEquipo1", idEq1);
                myCommand.Parameters.AddWithValue("@IdEquipo2", idEq2);
                myCommand.Parameters.AddWithValue("@Estadio", estadio);
                myCommand.Parameters.AddWithValue("@Juez", juez);
                myCommand.Parameters.AddWithValue("@Fecha", fecha);
                myCommand.Parameters.AddWithValue("@Resultado", idRes);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                vSalida = false;
            }
            finally
            {
                myConnection.Close();
            }
            return vSalida;
        }

        internal static bool EliminarPartido(int idPartido)
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.EliminarPartido(), myConnection);
                myCommand.Parameters.AddWithValue("@IdPartido", idPartido);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                vSalida = false;
            }
            finally
            {
                myConnection.Close();
            }
            return vSalida;
        }

        internal void CargarPartidosDeFecha(DateTime fecha)
        {
            this.listaPartidos = new List<Partido>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.ObtenerPartidosDeFecha(fecha), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Partido unPartido = new Partido();
                        unPartido.Id = myReader.GetInt32(0);
                        unPartido.Equipo1.Id = myReader.GetInt32(1);
                        unPartido.Equipo2.Id = myReader.GetInt32(2);
                        unPartido.Estadio = myReader.GetString(3);
                        unPartido.Juez = myReader.GetString(4);
                        unPartido.Fecha = myReader.GetDateTime(5);
                        unPartido.Resultado.Id = myReader.GetInt32(6);

                        this.listaPartidos.Add(unPartido);
           
                    }
                }
                else
                {
                    Console.WriteLine("No hay parttidos en base");
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
        }

        internal void CargarPartidosDeEquipo(string idEquipo)
        {
            this.listaPartidos = new List<Partido>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.ObtenerPartidosDeEquipo(idEquipo), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Partido unPartido = new Partido();
                        unPartido.Id = myReader.GetInt32(0);
                        unPartido.Equipo1.Id = myReader.GetInt32(1);
                        unPartido.Equipo2.Id = myReader.GetInt32(2);
                        unPartido.Estadio = myReader.GetString(3);
                        unPartido.Juez = myReader.GetString(4);
                        unPartido.Fecha = myReader.GetDateTime(5);
                        unPartido.Resultado.Id = myReader.GetInt32(6);

                        this.listaPartidos.Add(unPartido);

                    }
                }
                else
                {
                    Console.WriteLine("No hay parttidos en base");
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
        }
    

    internal void CargarPartidosDeEquipoEnFecha(string idEquipo, DateTime fecha)
    {
        this.listaPartidos = new List<Partido>();
        SqlConnection myConnection = null;
        SqlCommand myCommand = null;
        SqlDataReader myReader = null;
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand(Consultas.ObtenerPartidosDeEquipoEnFecha(idEquipo, fecha), myConnection);
            myReader = myCommand.ExecuteReader();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    Partido unPartido = new Partido();
                    unPartido.Id = myReader.GetInt32(0);
                    unPartido.Equipo1.Id = myReader.GetInt32(1);
                    unPartido.Equipo2.Id = myReader.GetInt32(2);
                    unPartido.Estadio = myReader.GetString(3);
                    unPartido.Juez = myReader.GetString(4);
                    unPartido.Fecha = myReader.GetDateTime(5);
                    unPartido.Resultado.Id = myReader.GetInt32(6);

                    this.listaPartidos.Add(unPartido);

                }
            }
            else
            {
                Console.WriteLine("No hay parttidos en base");
            }
        }
        catch (Exception e)
        {
        }
        finally
        {
            myReader.Close();
            myConnection.Close();
        }
    }
}
}