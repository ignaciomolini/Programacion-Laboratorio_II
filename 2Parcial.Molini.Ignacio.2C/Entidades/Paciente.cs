using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Paciente : Persona
    {
        private string obraSocial;

        /// <summary>
        /// Propiedad que setea y retorna el atributo obraSocial.
        /// </summary>
        public string ObraSocial
        {
            get
            {
                return this.obraSocial;
            }
            set
            {
                this.obraSocial = value;
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Paciente() : base()
        {

        }

        /// <summary>
        /// Constructor con parametros que asigna obraSocial.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="obraSocial"></param>
        public Paciente(int id, string apellido, string nombre, int edad, string sexo, string direccion, string obraSocial)
            : base(id, apellido, nombre, edad, sexo, direccion)
        {
            this.obraSocial = obraSocial;
        }

        /// <summary>
        /// Metodo que muestra los datos del paciente.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.Append($" * Plan médico: {this.ObraSocial}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString para mostrar los datos 
        /// del paciente de manera publica.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
