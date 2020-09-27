using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using CentralitaHerencia;
using System.Collections.Specialized;

namespace EntidadesDAO
{
    public class LocalDAO
    {
        private SqlConnection miConexion;
        private SqlCommand miComando;
        private SqlDataReader lectorBDD;

        public LocalDAO()
        {
            miConexion = new SqlConnection("Data Source = .; Database = centralita62; Trusted_Connection = true;");
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }

        public bool Guardar(Local local)
        {
            bool retorno = false;

            try
            {
                miComando.CommandText = $"INSERT INTO Llamadas (Duración, Origen, Destino, Costo, Tipo)" +
                    $"VALUES ({(int)local.Duracion}, '{local.NroOrigen}', '{local.NroDestino}', {(int)local.CostoLlamada}, {0})";
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
                if(miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
            }

            return retorno;
        }

        public List<Llamada> Leer()
        {
            List<Llamada> listaLlamadas = new List<Llamada>();

            try
            {
                miComando.CommandText = "SELECT * FROM Llamadas WHERE Tipo = 0";
                miConexion.Open();
                lectorBDD = miComando.ExecuteReader();

                while(lectorBDD.Read())
                {
                    float duracion = (int)lectorBDD["Duración"];
                    string origen = lectorBDD["Origen"].ToString();
                    string destino = lectorBDD["Destino"].ToString();
                    float.TryParse(lectorBDD["Costo"].ToString(), out float costo);

                    listaLlamadas.Add(new Local(origen, duracion, destino, costo));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(miConexion.State != ConnectionState.Closed)
                {
                    miConexion.Close();
                }
            }

            return listaLlamadas;
        }
    }
}
