using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Turno
    {
        private int idTurno;
        private Paciente pacienteTurno;
        private Especialista especialistaTurno;
        private int idPaciente;
        private int idEspecialista;
        private string observaciones;
        private DateTime fechaTurno;

        /// <summary>
        /// Propiedad que setea y retorna el atributo idTurno.
        /// </summary>
        public int IdTurno
        {
            get
            {
                return this.idTurno;
            }
            set
            {
                this.idTurno = value;
            }
        }

        /// <summary>
        /// Propiedad que retorna el atributo pacienteTurno.
        /// </summary>
        public Paciente PacienteTurno
        {
            get
            {
                return this.pacienteTurno;
            }
        }

        /// <summary>
        /// Propiedad que retorna el atributo especialistaTurno.
        /// </summary>
        public Especialista EspecialistaTurno
        {
            get
            {
                return this.especialistaTurno;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo idPaciente.
        /// </summary>
        public int IdPaciente
        { 
            get
            {
                return this.idPaciente;
            }
            set
            {
                this.idPaciente = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo idEspecialista.
        /// </summary>
        public int IdEspecialista
        {
            get
            {
                return this.idEspecialista;
            }
            set
            {
                this.idEspecialista = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo observaciones.
        /// </summary>
        public string Observaciones
        {
            get
            {
                return this.observaciones;
            }
            set
            {
                this.observaciones = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el fechaTurno.
        /// </summary>
        public DateTime FechaTurno
        {
            get
            {
                return this.fechaTurno;
            }
            set
            {
                this.fechaTurno = value;
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Turno()
        {

        }

        /// <summary>
        /// Constructor con parametros que asigna idTurno.
        /// </summary>
        /// <param name="idTurno"></param>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        /// <param name="observaciones"></param>
        public Turno(int idTurno, Paciente paciente, Especialista especialista, string observaciones)
            : this(paciente, especialista, observaciones)
        {
            this.idTurno = idTurno;       
        }

        /// <summary>
        /// Constructor con parametros que asigna los atributos restantes.
        /// </summary>
        /// <param name="paciente"></param>
        /// <param name="especialista"></param>
        /// <param name="observaciones"></param>
        public Turno(Paciente paciente, Especialista especialista, string observaciones)
        {
            this.pacienteTurno = paciente;
            this.especialistaTurno = especialista;
            this.idPaciente = paciente.Id;
            this.idEspecialista = especialista.Id;
            this.observaciones = observaciones;
            this.fechaTurno = DateTime.Now;
        }

        /// <summary>
        /// Metodo que muestra nombre y apellido del paciente.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public string NombrePaciente()
        {
            return $"{this.PacienteTurno.Nombre} {this.PacienteTurno.Apellido}";
        }

        /// <summary>
        /// Metodo que muestra nombre y apellido del especialista.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public string NombreEspecialista()
        {
            return $"{this.EspecialistaTurno.Nombre} {this.EspecialistaTurno.Apellido}";
        }

    }
}
