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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        TextBox textBoxEntrada;

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            this.comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            textBoxEntrada = textBoxNroDestino;
            comboBoxFranja.Enabled = false;
        }

        private void ControlarEntrada(string numero)
        {
            if(textBoxEntrada.Text == "Nro Destino" || textBoxEntrada.Text == "Nro Origen")
            {
                textBoxEntrada.Text = numero;
            }
            else
            {
                textBoxEntrada.Text += numero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlarEntrada("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlarEntrada("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlarEntrada("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlarEntrada("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ControlarEntrada("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ControlarEntrada("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ControlarEntrada("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ControlarEntrada("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ControlarEntrada("9");
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            ControlarEntrada("*");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ControlarEntrada("0");
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            ControlarEntrada("#");
        }

        private void CambiarTextoDestino(object sender, EventArgs e)
        {
            this.textBoxEntrada = textBoxNroDestino;
        }

        private void CambiarTextoOrigen(object sender, EventArgs e)
        {
            this.textBoxEntrada = textBoxNroOrigen;
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            Random nroRandom = new Random();
            StringBuilder sb = new StringBuilder();
            Llamada llamada;          
            Provincial.Franja franja;
            Enum.TryParse<Provincial.Franja>(comboBoxFranja.SelectedValue.ToString(), out franja);

            if((textBoxNroDestino.Text != "Nro Destino" && textBoxNroOrigen.Text != "Nro Origen"))
            {
                if (textBoxNroDestino.Text[0] == '#')
                {
                    llamada = new Provincial(this.textBoxNroOrigen.Text, franja, nroRandom.Next(1, 50), this.textBoxNroDestino.Text);

                }
                else
                {
                    llamada = new Local(this.textBoxNroOrigen.Text, nroRandom.Next(1, 50), this.textBoxNroDestino.Text, (float)(nroRandom.Next(5, 56) / 10));
                }

                try
                {
                    this.centralita += llamada;

                    sb.AppendLine("Se agrego una nueva llamada!\n");
                    sb.AppendLine(llamada.ToString());
                    MessageBox.Show(sb.ToString());
                }
                catch(CentralitaException ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }      
        }

        private void textBoxNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNroDestino.Text[0] == '#')
            {
                comboBoxFranja.Enabled = true;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNroDestino.Text = "Nro Destino";
            this.textBoxNroOrigen.Text = "Nro Origen";
            comboBoxFranja.Enabled = false;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
