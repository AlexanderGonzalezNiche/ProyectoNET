using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Torneo_Clases.Logicia;

namespace Torneo_Clases.Acceso_Datos
{
    class DAOUsuarios
    {
        public List<Usuario> listaUsuarios { get; set; }

        public DAOUsuarios()
        {
            listaUsuarios = new List<Usuario>();
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.DevolverUsuarios(), myConnection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Usuario usu = new Usuario();
                        usu.NombreUsuario = myReader.GetString(0);
                        usu.Password = myReader.GetString(1);
                        usu.Nombre = myReader.GetString(2);
                        usu.Apellido = myReader.GetString(3);
                        usu.Ciudad = myReader.GetString(4);
                        listaUsuarios.Add(usu);
                    }
                }
                else
                {
                    Console.WriteLine("No hay ususarios en el Sistema");
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

        internal static bool ExisteUsuario(string nombreUsuario)
        {
            bool retorno = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            SqlDataReader myReader = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.ExisteUsuario(nombreUsuario), myConnection);
                myReader = myCommand.ExecuteReader();
                if (!myReader.HasRows)
                {
                    retorno = false;
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
            return retorno;
        }

        internal static bool AltaUsuario(string nombreUsuario, string password, string nombre, string apellido, string ciudad)
        {
            bool creado = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.AltaUsuario(), myConnection);
                myCommand.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                myCommand.Parameters.AddWithValue("@Password", password);
                myCommand.Parameters.AddWithValue("@Nombre", nombre);
                myCommand.Parameters.AddWithValue("@Apellido", apellido);
                myCommand.Parameters.AddWithValue("@Ciudad", ciudad);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                creado = false;
            }
            finally
            {
                myConnection.Close();
            }
            return creado;
        }


        internal static bool EliminarUsuario(string nombreUsuario)
        {
            bool retorno = true;
            SqlConnection myConnection = null;
            SqlCommand myCommand = null;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                myConnection = new SqlConnection(connectionString);
                myConnection.Open();
                myCommand = new SqlCommand(Consultas.EliminarUsuario(), myConnection);
                myCommand.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                retorno = false;
            }
            finally
            {
                myConnection.Close();
            }
            return retorno;
        }
    }
}
