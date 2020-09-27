using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ClinicaApp
{
    public partial class FormTurnos : Form
    {
        Thread hilo;
        FormPacienteActual FrmPA;
        FormPacienteProximo FrmPP;
        //public delegate void DelegadoTurno();
        public delegate void DelegadoAsignacion(Turno turno);
        public static event DelegadoAsignacion CambioDePaciente;
        public static event DelegadoAsignacion CambioDePacienteActual;
        int idTurno = 1;

        /// <summary>
        /// Constructor por defecto que inicializa los componentes del formulario e
        /// instancia los dos formularios.
        /// </summary>
        public FormTurnos()
        {
            InitializeComponent();
            FrmPA = new FormPacienteActual();
            FrmPP = new FormPacienteProximo();           
        }

        /// <summary>
        /// Metodo que carga los pacientes y especialistas en el listBox, abre los formularios
        /// e inicia el hilo donde se eligen los turnos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTurnos_Load(object sender, EventArgs e)
        {
            this.CargarPacientes();
            this.CargarEspecialistas();
            MessageBox.Show("No se pudo implementar la opcion manual, solo detiene la automatica!",
                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FrmPA.Show();
            FrmPP.Show();         
            CheckForIllegalCrossThreadCalls = false; //Use esta propiedad porque no pude hacerlo andar con InvokeRequired
            this.IniciarHilo();                      //se que no es aconsejable               
        }

        /// <summary>
        /// Metodo que carga los pacientes de la base de datos y del archivo Xml
        /// </summary>
        private void CargarPacientes()
        {
            string ruta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\SegundoParcialUtn\" +
                @"ArchivosClinica\PacientesSegundaClinica.xml";
            foreach (Paciente item in ConexionDB.listaPacientes())
            {
                this.listBoxPacientes.Items.Add(item);
            }
            foreach (Paciente item in Serializador<List<Paciente>>.DeserializarXml(ruta))
            {
                this.listBoxPacientes.Items.Add(item);
            }
        }

        /// <summary>
        /// Metodo que carga los especialistas de la base de datos y del archivo Xml.
        /// </summary>
        private void CargarEspecialistas()
        {
            string ruta = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\SegundoParcialUtn\" +
                @"ArchivosClinica\DoctoresSegundaClinica.xml";
            foreach(Especialista item in ConexionDB.listaEspecialistas())
            {
                this.listBoxEspecialistas.Items.Add(item);
            }
            foreach(Especialista item in Serializador<List<Especialista>>.DeserializarXml(ruta))
            {
                this.listBoxEspecialistas.Items.Add(item);
            }
        }

        /// <summary>
        /// Metodo que inicia el hilo donde se elige el turno.
        /// </summary>
        private void IniciarHilo()
        {
            ThreadStart ts = new ThreadStart(this.ElegirTurno);
            hilo = new Thread(ts);
            hilo.Start();
        }

        /// <summary>
        /// Metodo que le pasa a los formularios el turno alegido.
        /// </summary>
        private void ElegirTurno()
        {   
            Turno turno = null;

            while(radioBtnAutomatico.Checked)
            {
                this.CrearTurno(out turno);
 
                CambioDePaciente.Invoke(turno);

                Thread.Sleep(10000);

                CambioDePacienteActual.Invoke(turno);
            }
        }

        /// <summary>
        /// Medoto que selecciona observaciones de manera aleatoria.
        /// </summary>
        /// <returns>Retorna un string con la observacion</returns>
        private static string ObservacionesAleatorias()
        {
            string[] observaciones = new string[5];
  
            observaciones[0] = "Tiene que hacer reposo";
            observaciones[1] = "Tiene que tomer la medicacion recetada";
            observaciones[2] = "Necesita operacion";
            observaciones[3] = "Se encuentra sin ningun problema";
            observaciones[4] = "Necesitara usar yeso";

            return observaciones[NumeroRandom.GenerarRandom(0, 5)];
        }

        /// <summary>
        /// Metodo que de manera aleatoria crea un nuevo turno.
        /// </summary>
        /// <param name="turno"></param>
        private void CrearTurno(out Turno turno)
        {
            Paciente auxPaciente = null;
            Especialista auxEspecialista = null;

            if(NumeroRandom.GenerarRandom(0, 2) == 1)
            {
                auxPaciente = this.ElegirPacientes(0, 113);
                auxEspecialista = this.ElegirEspecialistas(0, 110);
                turno = new Turno(auxPaciente, auxEspecialista, FormTurnos.ObservacionesAleatorias());
            }
            else
            {
                auxPaciente = this.ElegirPacientes(113, 1113);
                auxEspecialista = this.ElegirEspecialistas(110, 129);
                turno = new Turno(idTurno, auxPaciente, auxEspecialista, FormTurnos.ObservacionesAleatorias());
                idTurno++;
            }
        }

        /// <summary>
        /// Metodo que de manera aleatoria elige un paciente del listBox.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Retorna el paciente elegido</returns>
        private Paciente ElegirPacientes(int min, int max)
        {
            this.listBoxPacientes.SelectedIndex = NumeroRandom.GenerarRandom(min, max);
            Paciente auxPaciente = (Paciente)this.listBoxPacientes.SelectedItem;

            return auxPaciente;
        }

        /// <summary>
        /// Metodo que de manera aleatoria elige un especialista del listBox.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Retorna el especialista elegido</returns>
        private Especialista ElegirEspecialistas(int min, int max)
        {  
            this.listBoxEspecialistas.SelectedIndex = NumeroRandom.GenerarRandom(min, max);
            Especialista auxEspecialista = (Especialista)this.listBoxEspecialistas.SelectedItem;
           
            return auxEspecialista;
        }

        /// <summary>
        /// Metodo que al cambiar el radio button inicia el hilo no esta vivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioBtnAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            if(!this.hilo.IsAlive)
            {
                this.IniciarHilo();
            }
        }

        /// <summary>
        /// Metodo que antes de cerrar el formulario se fija si el
        /// hilo esta vivo, y si lo esta lo cierra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTurnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
