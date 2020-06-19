using EjemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using EjemploMVC.ViewModels;

namespace EjemploMVC.AccesoDatos
{
    public class AD_Personas
    {

        public static bool InsertarNuevaPersona(Persona per )
        {

            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;
            bool resultado;

            try 
	        {	        
                cmd = new OleDbCommand();
                String consulta = "INSERT INTO Persona(Nombre,Apellido,Edad,Telefono) VALUES(@nombre, @apellido, @edad, @telefono)";
		        cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", per.Id);
                cmd.Parameters.AddWithValue("@nombre",per.Nombre);
                cmd.Parameters.AddWithValue("@apellido",per.Apellido);
                cmd.Parameters.AddWithValue("@edad",per.Edad);
                cmd.Parameters.AddWithValue("@telefono",per.Telefono);
                //cmd.Parameters.AddWithValue("@idSexo",per.IdSexo);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;

	           }
	           catch (Exception)
	           {
		
		       throw;
	           }
               finally
               {
                conexion.Close();
               }

                return resultado;
               }

        public static List<Persona> ObtenerListaPersona()
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbDataReader dr;
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;

            List<Persona> resultado = new List<Persona>();


            conexion = new OleDbConnection(cadenaConexion);

            try
            {

                cmd = new OleDbCommand();
                String consulta = "SELECT * FROM Persona";
                cmd.Parameters.Clear();


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Persona aux = new Persona();
                        aux.Id = int.Parse(dr["id"].ToString());
                        aux.Nombre = dr["nombre"].ToString();
                        aux.Apellido = dr["apellido"].ToString();
                        aux.Edad = int.Parse(dr["edad"].ToString());
                        aux.Telefono = dr["telefono"].ToString();
                        
                        resultado.Add(aux);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public static Persona ObtenerPersona(int idPersona)
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbDataReader dr;
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;

            Persona resultado = new Persona();

            conexion = new OleDbConnection(cadenaConexion);

            try
            {

                cmd = new OleDbCommand();
                String consulta = "SELECT * FROM Persona WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idPersona);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        
                        resultado.Id = int.Parse(dr["Id"].ToString());
                        resultado.Nombre = dr["Nombre"].ToString();
                        resultado.Apellido = dr["Apellido"].ToString();
                        resultado.Edad = int.Parse(dr["Edad"].ToString());
                        resultado.Telefono = dr["Telefono"].ToString();

                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public static bool ActualizarPersona(Persona per)
        {

            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;
            bool resultado;

            try
            {
                cmd = new OleDbCommand();
                String consulta = "UPDATE Persona SET Nombre = @nombre, Apellido = @apellido, Edad = @edad, Telefono = @telefono WHERE Id = @id ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", per.Nombre);
                cmd.Parameters.AddWithValue("@apellido", per.Apellido);
                cmd.Parameters.AddWithValue("@edad", per.Edad);
                cmd.Parameters.AddWithValue("@telefono", per.Telefono);
                cmd.Parameters.AddWithValue("@id", per.Id);


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public static bool EliminarPersona(Persona per)
        {

            OleDbConnection conexion = new OleDbConnection();
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;
            bool resultado;

            try
            {
                cmd = new OleDbCommand();
                String consulta = "DELETE Persona WHERE Id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", per.Id);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public static List<SexoItemVM> ObtenerListaSexo()
        {
            OleDbConnection conexion = new OleDbConnection();
            OleDbDataReader dr;
            OleDbCommand cmd;
            String cadenaConexion;
            cadenaConexion = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Desktop\Proyectos VisualStudio\DBFPersona.mdb");
            conexion.ConnectionString = cadenaConexion;

            List<SexoItemVM> resultado = new List<SexoItemVM>();


            conexion = new OleDbConnection(cadenaConexion);

            try
            {

                cmd = new OleDbCommand();
                String consulta = "SELECT * FROM Sexo";
                cmd.Parameters.Clear();


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = consulta;

                conexion.Open();
                cmd.Connection = conexion;

                dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        SexoItemVM aux = new SexoItemVM();
                        aux.idSexo = int.Parse(dr["Id"].ToString());
                        aux.nombre = dr["Nombre"].ToString();


                        resultado.Add(aux);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }
    }
}