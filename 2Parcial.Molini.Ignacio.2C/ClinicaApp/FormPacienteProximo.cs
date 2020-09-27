using Entidades;
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

namespace ClinicaApp
{
    public partial class FormPacienteProximo : Form
    {
        Thread hilo;
        public delegate void DelegadoImagen(string ruta);
        public static event DelegadoImagen TransferenciaDeImagen;

        /// <summary>
        /// Constructor por defecto que inicializa los componentes del formulario
        /// y suscribe el manajador al evento del otro formulario.
        /// </summary>
        public FormPacienteProximo()
        {
            InitializeComponent();
            FormTurnos.CambioDePaciente += AsignarTurnoProximo;
        }

        /// <summary>
        /// Metodo que muestra por pantalla los datos del paciente y
        /// del medico proximos, y elegi una imagen del paciente.
        /// </summary>
        /// <param name="t"></param>
        public void AsignarTurnoProximo(Turno t)
        {
            this.lblDatosProxPaciente.Text = $"{t.PacienteTurno.Nombre} {t.PacienteTurno.Apellido}";
            this.lblDatosProxDoctor.Text = $"{t.EspecialistaTurno.Nombre} {t.EspecialistaTurno.Apellido}";
            this.ElegirImagen();
        }

        /// <summary>
        /// Metodo que elige aleatoriamente una imagen para el paciente
        /// e instancia un hilo donde luego de 10 segundos se la envia al 
        /// paciente actual.
        /// </summary>
        private void ElegirImagen()
        {
            string rutaImagen = String.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\SegundoParcialUtn\FotosPacientes\foto{0}.jpg", NumeroRandom.GenerarRandom(1, 16));
            this.picBoxCara2.Image = Image.FromFile(rutaImagen);
            hilo = new Thread(new ParameterizedThreadStart(EnviarImagen));
            hilo.Start(rutaImagen);
        }

        /// <summary>
        /// Metodo que le pasa al otro formulario la imegen al lanzar el evento.
        /// </summary>
        /// <param name="rutaImagen"></param>
        private void EnviarImagen(object rutaImagen)
        {
            Thread.Sleep(10000);
            TransferenciaDeImagen.Invoke((string)rutaImagen);
        }

        /// <summary>
        /// Metodo que se fija que antes del cerra el formulario el hilo no quede abierto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPacienteProximo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
