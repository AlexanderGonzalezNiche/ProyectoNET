using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Torneo_Clases.Logica;

namespace Torneo_Clases.Acceso_Datos
{
    public class DAOTorneo
    {
        public List<Torneo> listaTorneo { get; set; }
        public List<Equipo> listaEquipos { get; set; }
        public List<Partido> listaPartidos { get; set; }

        public DAOTorneo()
        {
            listaTorneo = new List<Torneo>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverTorneos(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Torneo tor = new Torneo();
                        tor.Id = myReader.GetInt32(0);
                        tor.Nombre = myReader.GetString(1);
                        tor.Año = myReader.GetString(2);
                        //TODO:Faltan las lista de torneo y equipos        
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

        internal static bool AltaTorneo(int idTor, string nombreTor, string fecha)
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myCommand = new SqlCommand(Consultas.AltaTorneo(), myConnection);
                myCommand.Parameters.AddWithValue("@IDTorneo", idTor);
                myCommand.Parameters.AddWithValue("@Nombre", nombreTor);
                myCommand.Parameters.AddWithValue("@Fecha", fecha);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                vSalida = false;
            }
            finally
            {
                myConnection.Close();
            }
            return vSalida;
        }

        public static Torneo ObtenerTorneo()
        {
            Torneo tor = new Torneo();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverTorneos(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (myReader.Read())
                    {
                        tor.Id = myReader.GetInt32(0);
                        tor.Nombre = myReader.GetString(1);
                        tor.Año = myReader.GetString(2);
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
                myConnection.Close();
            }
            return tor;
        }

        internal static bool EliminarTorneo()
        {
            bool vSalida = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.EliminarTorneo(), myConnection);
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
    }
}


