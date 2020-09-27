using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEj63
{
    public partial class Form : System.Windows.Forms.Form
    {
        //No se puede realizar el ejercicio haciendolo del modo del punto 1

        /******punto 2******/

        //public Form()
        //{
        //    InitializeComponent();
        //}

        //private void Form_Load(object sender, EventArgs e)
        //{
        //    this.AsignarHora();
        //}

        //private void AsignarHora()
        //{
        //    this.lblHora.Text = DateTime.Now.ToString();
        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    this.AsignarHora();
        //}

        //private void Form_FormClosing(object sender, FormClosingEventArgs e)
        //{

        //}

        /******punto 3******/

        Thread t;

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(this.ModificarHora);
            t = new Thread(ts);
            t.Start();
        }

        delegate void DelegadoSetHora();

        private void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                DelegadoSetHora aux = new DelegadoSetHora(this.AsignarHora);
                this.Invoke(aux);
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }

        }

        private void ModificarHora()
        {
            do
            {
                this.AsignarHora();
                Thread.Sleep(1000);
            } while (true);
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
        }
    }
}
