using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaApp
{
    public partial class FormPacienteActual : Form
    {
        Thread hilo;
        Turno turnoAGuardar = null;

        /// <summary>
        /// Constructor por defecto que inicializa los componentes del formulario
        /// y suscribe manejadores a los eventos de los otros formularios.
        /// </summary>
        public FormPacienteActual()
        {
            InitializeComponent();
            FormTurnos.CambioDePacienteActual += AsignarTurnoActual;
            FormPacienteProximo.TransferenciaDeImagen += CambiarImagen;
        }
        
        /// <summary>
        /// Metodo que muestra por pantalla los datos del paciente y 
        /// medico actuales, y que instancia un hilo donde guarda el turno.
        /// </summary>
        /// <param name="t"></param>
        public void AsignarTurnoActual(Turno t)
        {
            this.lblDatosPacienteActual.Text = $"{t.PacienteTurno.Nombre} {t.PacienteTurno.Apellido}";
            this.lblDatosDoctorActual.Text = $"{t.EspecialistaTurno.Nombre} {t.EspecialistaTurno.Apellido}";
            turnoAGuardar = t;   
            hilo = new Thread(GuardarTurno);
            hilo.Start();
         
        }

        /// <summary>
        /// Metodo que cambia la cara de la persona que esta siendo atendida con la 
        /// ruta que le llega por parametro.
        /// </summary>
        /// <param name="rutaImagen"></param>
        private void CambiarImagen(string rutaImagen)
        {
            picBoxCara2.Image = Image.FromFile(rutaImagen);
        }

        /// <summary>
        /// Metodo que guarda el turno luego los 10 segundos que dura 
        /// la consulta del paciente, en la base de datos si pertenece a la clinica
        /// o en un archivo Xml si no es de la clinica.
        /// </summary>
        public void GuardarTurno()
        {
            Thread.Sleep(10000);

            string ruta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\SegundoParcialUtn\" +
                @"TurnosClinica\";

            if(!File.Exists(ruta))
            {
                try
                {
                    throw new ClinicaException("Se creo la ruta del archivo, ya que no existia");
                }
                catch(ClinicaException)
                {

                }
            }

            if (turnoAGuardar.IdPaciente <= 113 && turnoAGuardar.IdEspecialista <= 110)
            {
                try
                {
                    ConexionDB.InsertarTurnos(turnoAGuardar.IdPaciente, turnoAGuardar.IdEspecialista,
                    turnoAGuardar.Observaciones, turnoAGuardar.FechaTurno);
                }
                catch(ClinicaException)
                {

                }     
            }
            else
            {
                try
                {
                    ruta = ruta + $"{turnoAGuardar.FechaTurno.ToString("MMMMdd")}-{turnoAGuardar.PacienteTurno.Apellido}-" +
                        $"{turnoAGuardar.PacienteTurno.Nombre}.xml";
                    Serializador<Turno>.SerializarAXml(turnoAGuardar, ruta);
                }
                catch(ClinicaException)
                {

                }    
            }     
        }

        /// <summary>
        /// Metodo que antes de cerrar el formulario se fija si el hilo 
        /// esta abierto y si lo esta lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPacienteActual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
