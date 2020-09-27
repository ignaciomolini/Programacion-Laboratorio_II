using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PruebaDeSQL
{
    public partial class FormSql : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader objetoQueRecibeLaInfo;
        List<string> lista = new List<string>();

        public FormSql()
        {
            miComando = new SqlCommand();
            miConexion = new SqlConnection("Data Source = .; Database = utnfra; Trusted_Connection = true;");
            InitializeComponent();
        }

        private void FormSql_Load(object sender, EventArgs e)
        {
            string auxNombre = "";
            string auxApellido = "";
            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos";

                miConexion.Open();

                objetoQueRecibeLaInfo = miComando.ExecuteReader();

                while(objetoQueRecibeLaInfo.Read())
                {
                    auxNombre = objetoQueRecibeLaInfo["nombre"].ToString();
                    auxApellido = objetoQueRecibeLaInfo["apellido"].ToString();
                    lista.Add((auxNombre + " " + auxApellido));
                }

                foreach(string s in lista)
                {
                    richTxtBoxDatos.Text += s + "\n";
                }
            }
            catch(Exception)
            {

            }
            finally
            {
                miConexion.Close();
            }
        }

       
    }
}
