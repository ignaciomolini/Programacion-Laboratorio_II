using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ConexionDB
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        /// <summary>
        /// Constructor estatico que estable la conexion a la base de datos
        /// y le asigna al comando la conexion y el tipo.
        /// </summary>
        static ConexionDB()
        {
            ConexionDB.conexion = new SqlConnection("Data Source = .; Database = ClinicaUtn; Trusted_Connection = True;");
            ConexionDB.comando = new SqlCommand();
            ConexionDB.comando.Connection = ConexionDB.conexion;
            ConexionDB.comando.CommandType = CommandType.Text;
        }

        /// <summary>
        /// Metodo que consulta a la base de datos la informacion de todos los pacientes 
        /// y la carga en una lista de pacientes.
        /// Si hay un error lanza una excepcion personalizada.
        /// </summary>
        /// <returns>Retorna una lista de pacientes con todos los que obtuvo de la base de datos</returns>
        public static List<Paciente> listaPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            try
            {
                ConexionDB.comando.CommandText = "SELECT * FROM Pacientes";
                ConexionDB.conexion.Open();
                SqlDataReader dr = ConexionDB.comando.ExecuteReader();

                while(dr.Read())
                {
                    int idPaciente = Convert.ToInt32(dr["idPaciente"]);
                    string apellido = dr["apellido"].ToString();
                    string nombre = dr["nombre"].ToString();
                    int edad = Convert.ToInt32(dr["edad"]);
                    string sexo = dr["sexo"].ToString();
                    string direccion = dr["direccion"].ToString();
                    string obraSocial = dr["obraSocial"].ToString();
                    Paciente paciente = new Paciente(idPaciente, apellido, nombre, edad, sexo, direccion, obraSocial);
                    listaPacientes.Add(paciente);
                }
            }
            catch(Exception ex)
            {
                throw new ClinicaException("Error al traer los pacientes la base de datos", ex);
            }
            finally
            {
                if(ConexionDB.conexion.State != ConnectionState.Closed)
                {
                    ConexionDB.conexion.Close();
                }
            }

            return listaPacientes;
        }


        /// <summary>
        /// Metodo que consulta a la base de datos la informacion de todos los especialistas 
        /// y la carga en una lista de especialistas.
        /// Si hay un error lanza una excepcion personalizada.
        /// </summary>
        /// <returns>Retorna una lista de especialistas con todos los que obtuvo de la base de datos</returns>
        public static List<Especialista> listaEspecialistas()
        {
            List<Especialista> listaEspecialistas = new List<Especialista>();

            try
            {
                ConexionDB.comando.CommandText = "SELECT * FROM Especialistas";
                ConexionDB.conexion.Open();
                SqlDataReader dr = ConexionDB.comando.ExecuteReader();

                while (dr.Read())
                {
                    int idEspecialista = Convert.ToInt32(dr["idEspecialista"]);
                    string apellido = dr["apellido"].ToString();
                    string nombre = dr["nombre"].ToString();
                    int edad = Convert.ToInt32(dr["edad"]);
                    string sexo = dr["sexo"].ToString();
                    string direccion = dr["direccion"].ToString();
                    string especialidad = dr["especialidad"].ToString();
                    Especialista especialista = new Especialista(idEspecialista, apellido, nombre, edad, sexo, direccion, especialidad);
                    listaEspecialistas.Add(especialista);
                }
            }
            catch (Exception ex)
            {
                throw new ClinicaException("Error al traer los espcialistad de la base de datos", ex);
            }
            finally
            {
                if (ConexionDB.conexion.State != ConnectionState.Closed)
                {
                    ConexionDB.conexion.Close();
                }
            }

            return listaEspecialistas;
        }

        /// <summary>
        /// Metodo que carga en la base de datos una nueva fila con los datos 
        /// pasados por parametro.
        /// </summary>
        /// <param name="idPaciente"></param>
        /// <param name="idEspecialista"></param>
        /// <param name="observaciones"></param>
        /// <param name="fechaTurno"></param>
        public static void InsertarTurnos(int idPaciente, int idEspecialista, string observaciones, DateTime fechaTurno)
        {
            try
            {
                string fechaT = fechaTurno.ToString();
                ConexionDB.comando.CommandText = "INSERT INTO Turnos (idPaciente, idEspecialista, observacionesTurno, fechaTurno)" +
                    $"VALUES ({idPaciente}, {idEspecialista}, '{observaciones}', '{fechaT}')";
                if(ConexionDB.conexion.State != ConnectionState.Open)
                {
                    ConexionDB.conexion.Open();
                } 
                ConexionDB.comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new ClinicaException("Error al insertar un turno en la base de datos", ex);
            }
            finally
            {
                if(ConexionDB.conexion.State != ConnectionState.Closed)
                {
                    ConexionDB.conexion.Close();
                }
            }
        }
    }
}
