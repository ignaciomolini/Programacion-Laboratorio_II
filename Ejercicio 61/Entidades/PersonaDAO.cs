using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaDAO
    {
        private SqlConnection miConexion;
        private SqlCommand miComando;
        private SqlDataReader lectorBDD;

        public PersonaDAO()
        {
            miConexion = new SqlConnection(@"Data Source = .; Database = baseEjercicio61; Trusted_Connection = true;");
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }

        public bool Guardar(Persona persona)
        {
            bool retorno = false;

            try
            {
                miComando.CommandText = String.Format("INSERT INTO Persona (Nombre, Apellido) VALUES ('{0}', '{1}')", persona.Nombre, persona.Apellido);          
                miConexion.Open();
                miComando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return retorno;
        }

        public List<Persona> Leer()
        {
            Persona auxPersona;
            List<Persona> listaPersonas = new List<Persona>();

            try
            {
                miComando.CommandText = "SELECT * FROM Persona";
                miConexion.Open();
                lectorBDD = miComando.ExecuteReader();

                while(lectorBDD.Read())
                {
                    auxPersona = new Persona((int)lectorBDD["ID"], lectorBDD["Nombre"].ToString(), lectorBDD["Apellido"].ToString());
                    listaPersonas.Add(auxPersona);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return listaPersonas;
        }

        public Persona LeerPorID(int id)
        {
            Persona auxPersona = null;

            try
            {
                miComando.CommandText = String.Format("SELECT * FROM Persona WHERE ID = {0}", id);
                miConexion.Open();
                lectorBDD = miComando.ExecuteReader();

                if(lectorBDD.Read())
                {
                    auxPersona = new Persona((int)lectorBDD["ID"], lectorBDD["Nombre"].ToString(), lectorBDD["Apellido"].ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return auxPersona;
        }

        public bool Modificar(Persona persona)
        {
            bool retorno = false;

            try
            {
                miComando.CommandText = String.Format($"UPDATE Persona SET Nombre = '{persona.Nombre}'," +
                    $" Apellido = '{persona.Apellido}' WHERE ID = {persona.Id}");
                miConexion.Open();
                miComando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return retorno;
        }

        public bool Borrar(int id)
        {
            bool retorno = false;

            try
            {
                miComando.CommandText = String.Format($"DELETE FROM Persona WHERE ID = {id}");
                miConexion.Open();
                miComando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return retorno;
        }


    }
}
