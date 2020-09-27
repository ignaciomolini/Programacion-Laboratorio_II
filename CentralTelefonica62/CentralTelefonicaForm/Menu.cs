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


namespace CentralTelefonicaForm
{
    public partial class FrmMenu : Form
    {
        Centralita centralita;  

        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Nacho center");      
        }

        private void buttonGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(centralita);
            llamador.ShowDialog();
        }

        private void buttonFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            mostrar.ShowDialog();
        }

        private void buttonFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            mostrar.ShowDialog();
        }

        private void buttonFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TipoLlamada = Llamada.TipoLlamada.Provincial; 
            mostrar.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(centralita.Leer(), "Registro de llamadas");
            FrmLlamadasBDD formLlamadas = new FrmLlamadasBDD();
            formLlamadas.ShowDialog();
        }
    }
}
