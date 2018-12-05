using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Acceso_Datos
{
    class DAOResultados
    {
        public List<Resultado> listaResultados { get; set; }
        public DAOResultados()
        {
            listaResultados = new List<Resultado>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverResultados(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Resultado res = new Resultado();
                        res.Partido = DAOPartidos.ObtenerPartidoPorID(myReader.GetInt32(0));
                        res.GolesEquipo1 = myReader.GetInt32(1);
                        res.GolesEquipo1 = myReader.GetInt32(2);
                        res.Descripcion = myReader.GetString(3);
                        res.Clima = myReader.GetString(4);
                        listaResultados.Add(res);
                    }
                }
                else
                {
                    Console.WriteLine("No hay resultados en el Sistema");
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
    }
}

