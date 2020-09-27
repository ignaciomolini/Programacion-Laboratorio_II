using CentralitaHerencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDAO
{
    public class ProvincialDAO
    {
        private SqlConnection miConexion;
        private SqlCommand miComando;
        private SqlDataReader lectorBDD;

        public ProvincialDAO()
        {
            miConexion = new SqlConnection("Data Source = .; Database = centralita62; Trusted_Connection = true;");
            miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.Text;
        }

        public bool Guardar(Provincial provincial)
        {
            bool retorno = false;

            try
            {
                miComando.CommandText = $"INSERT INTO Llamadas (Duración, Origen, Destino, Costo, Tipo) " +
                $"VALUES({(int)provincial.Duracion}, '{provincial.NroOrigen}', '{provincial.NroDestino}', {(int)provincial.CostoLlamada}, 1)";
                miConexion.Open();
                miComando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (miConexion.State == ConnectionState.Open)
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
                miComando.CommandText = "SELECT * FROM Llamadas WHERE Tipo = 1";
                miConexion.Open();
                lectorBDD = miComando.ExecuteReader();

                while (lectorBDD.Read())
                {
                    float duracion = (int)lectorBDD["Duración"];
                    string origen = lectorBDD["Origen"].ToString();
                    string destino = lectorBDD["Destino"].ToString();
                    float.TryParse(lectorBDD["Costo"].ToString(), out float costo);
                    Provincial.Franja franja;

                    if(costo == (duracion * 0.99))
                    {
                        franja = Provincial.Franja.Franja_1;
                    }
                    else if(costo == (duracion * 1.25))
                    {
                        franja = Provincial.Franja.Franja_2;
                    }
                    else
                    {
                        franja = Provincial.Franja.Franja_3;
                    }

                    listaLlamadas.Add(new Provincial(origen, franja, duracion, destino));
                }
            }
            catch (Exception ex)
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

            return listaLlamadas;
        }
    }
}
