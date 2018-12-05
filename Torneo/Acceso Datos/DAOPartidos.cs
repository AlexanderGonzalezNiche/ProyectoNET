using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Acceso_Datos
{
    class DAOPartidos
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
    }
}