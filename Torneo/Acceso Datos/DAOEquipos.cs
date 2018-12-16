using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using Torneo_Clases.Logica;

namespace Torneo_Clases.Acceso_Datos
{
    public class DAOEquipos
    {
        public List<Equipo> listaEquipos { get; set; }
        public DAOEquipos()
        {
            listaEquipos = new List<Equipo>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverEquipos(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Equipo eq = new Equipo();
                        eq.Nombre = myReader.GetString(0);
                        eq.Ciudad = myReader.GetString(1);
                        eq.DT = myReader.GetString(2);
                        listaEquipos.Add(eq);
                    }
                }
                else
                {
                    Console.WriteLine("No hay equipos en el Sistema");
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


       
        internal static bool AltaEquipo(int idEqu, string nombre, string ciudad, string DT, int puntos)
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myCommand = new SqlCommand(Consultas.AltaEquipo(), myConnection);
                myCommand.Parameters.AddWithValue("@IdEquipo", idEqu);
                myCommand.Parameters.AddWithValue("@Nombre", nombre);
                myCommand.Parameters.AddWithValue("@Ciudad", ciudad);
                myCommand.Parameters.AddWithValue("@DT", DT);
                myCommand.Parameters.AddWithValue("@Puntos", puntos);

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

        public static Equipo ObtenerEquipoPorID(int idEquipo)
        {
            Equipo unEquipo = new Equipo();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.ObtenerEquipoPorID(idEquipo), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        unEquipo.Id = myReader.GetInt32(0);
                        unEquipo.Nombre = myReader.GetString(1);
                        unEquipo.Ciudad = myReader.GetString(2);
                        unEquipo.DT = myReader.GetString(3);
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
            return unEquipo;
        }
    }
}
