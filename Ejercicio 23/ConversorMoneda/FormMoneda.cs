using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace ConversorMoneda
{
    public partial class FormMoneda : Form
    {
        public FormMoneda()
        {   
            InitializeComponent();
        }   

        private void FormMoneda_Load(object sender, EventArgs e)
        {
            textBoxCotEuro.Text = Euro.GetCotizacion().ToString();
            textBoxCotDolar.Text = Dolar.GetCotizacion().ToString();
            textBoxCotPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void buttonCotizacion_Click(object sender, EventArgs e)
        {
            if(textBoxCotPeso.Enabled)
            {
                buttonCotizacion.Image = imageList.Images[0];
                textBoxCotEuro.Enabled = false;
                textBoxCotDolar.Enabled = false;
                textBoxCotPeso.Enabled = false;
            }
            else
            {
                buttonCotizacion.Image = imageList.Images[1];
                textBoxCotEuro.Enabled = true;
                textBoxCotDolar.Enabled = true;
                textBoxCotPeso.Enabled = true;
            }
           
        }

        private void buttonDolar_Click(object sender, EventArgs e)
        {
            double aux = 0;

            if (double.TryParse(textBoxDolar.Text, out aux))
            {
                Dolar moneda = new Dolar(aux);

                textBoxDolarDolar.Text = moneda.GetCantidad().ToString();
                textBoxDolarEuro.Text = ((Euro)moneda).GetCantidad().ToString("n2");
                textBoxDolarPeso.Text = ((Pesos)moneda).GetCantidad().ToString("n2");
            }
        }

        private void buttonPeso_Click(object sender, EventArgs e)
        {
            double aux = 0;

            if (double.TryParse(textBoxPeso.Text, out aux))
            {
                Pesos moneda = new Pesos(aux);

                textBoxPesoPeso.Text = moneda.GetCantidad().ToString();
                textBoxPesoDolar.Text = ((Dolar)moneda).GetCantidad().ToString("n2");
                textBoxPesoEuro.Text = ((Euro)moneda).GetCantidad().ToString("n2");
            }
        }

        private void buttonEuro_Click(object sender, EventArgs e)
        {
            double aux = 0;

            if (double.TryParse(textBoxEuro.Text, out aux))
            {
                Euro moneda = new Euro(aux);

                textBoxEuroEuro.Text = moneda.GetCantidad().ToString();
                textBoxEuroDolar.Text = ((Dolar)moneda).GetCantidad().ToString("n2");
                textBoxEuroPeso.Text = ((Pesos)moneda).GetCantidad().ToString("n2");
            }
        }

        private void textBoxCotEuro_Leave(object sender, EventArgs e)
        {
            double aux = 0;

            if(double.TryParse(textBoxCotEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                textBoxCotEuro.Focus();
            }
        }

        private void textBoxCotDolar_Leave(object sender, EventArgs e)
        {
            double aux = 0;

            if (double.TryParse(textBoxCotDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                textBoxCotDolar.Focus();
            }
        }

        private void textBoxCotPeso_Leave(object sender, EventArgs e)
        {
            double aux = 0;

            if (double.TryParse(textBoxCotPeso.Text, out aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
            {
                textBoxCotPeso.Focus();
            }
        }
    }
}
