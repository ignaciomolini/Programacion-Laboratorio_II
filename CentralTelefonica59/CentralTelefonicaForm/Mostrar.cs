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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        Llamada.TipoLlamada tipoLlamada;

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public FrmMostrar(Centralita centralita) : this()
        {
            this.centralita = centralita;
        }

        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            string aux = "";
            switch(this.tipoLlamada)
            {
                case Llamada.TipoLlamada.Todas:
                    aux = ($"La ganancia total es de: {this.centralita.GananciasPorTotal}");
                    break;

                case Llamada.TipoLlamada.Local:
                    aux = ($"La ganancia local es de: {this.centralita.GananciasPorLocal}");
                    break;

                case Llamada.TipoLlamada.Provincial:
                    aux = ($"La ganancia provincial es de: {this.centralita.GananciasPorProvincial}");
                    break;
            }

            this.richTextBoxInfo.Text = aux;
        }
    }
}
