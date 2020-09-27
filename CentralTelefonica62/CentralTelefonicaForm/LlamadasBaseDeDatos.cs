using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
using EntidadesDAO;

namespace CentralTelefonicaForm
{
    public partial class FrmLlamadasBDD : Form
    {
        ProvincialDAO provincialDAO;
        LocalDAO localDAO;

        public FrmLlamadasBDD()
        {
            InitializeComponent();
            provincialDAO = new ProvincialDAO();
            localDAO = new LocalDAO();
        }

        private void LlamadasBaseDeDatos_Load(object sender, EventArgs e)
        {
            List<Llamada> listaLlamadasProvinciales = provincialDAO.Leer();
            List<Llamada> listaLlamadasLocales = localDAO.Leer();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Llamadas provinciales: \n");

            foreach (Provincial item in listaLlamadasProvinciales)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Llamadas locales: \n");

            foreach (Local item in listaLlamadasLocales)
            {
                sb.AppendLine(item.ToString());
            }

            this.richTextBoxLlamadas.Text = sb.ToString();

        }
    }
}
