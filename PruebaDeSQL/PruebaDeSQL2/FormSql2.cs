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

namespace PruebaDeSQL2
{
    public partial class FormSql2 : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader objQueRicibeLaInfo;
        DataTable miTabla;

        public FormSql2()
        {
            miConexion = new SqlConnection("Data Source = .; Database = utnfra; Trusted_Connection = true;");
            miComando = new SqlCommand();
            miTabla = new DataTable();

            InitializeComponent();
        }

        private void FormSql2_Load(object sender, EventArgs e)
        {
            //Se puede hacer todo esto desde las propiedades del form
            dataGridView.DataSource = miTabla;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
               
                miTabla.Rows.Clear();
                
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Alumnos WHERE curso = @cursoAFiltrar";

                miComando.Parameters.Clear();
                miComando.Parameters.Add(new SqlParameter("cursoAFiltrar", int.Parse(txtBoxFiltro.Text)));

                miConexion.Open();
                objQueRicibeLaInfo = miComando.ExecuteReader();

                miTabla.Load(objQueRicibeLaInfo);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }
    }
}
