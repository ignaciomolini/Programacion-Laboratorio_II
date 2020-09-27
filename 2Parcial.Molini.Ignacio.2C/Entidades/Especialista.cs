using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Especialista : Persona
    {
        private string campo;

        /// <summary>
        /// Propiedad que setea y retorna el atributo campo.
        /// </summary>
        public string Campo
        {
            get
            {
                return this.campo;
            }
            set
            {
                this.campo = value;
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Especialista() : base()
        {

        }

        /// <summary>
        /// Constructor con parametros que asigna campo.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        /// <param name="especialidad"></param>
        public Especialista(int id, string apellido, string nombre, int edad, string sexo, string direccion, string especialidad)
            : base(id, apellido, nombre, edad, sexo, direccion)
        {
            this.campo = especialidad;
        }

        /// <summary>
        /// Metodo que muestra los datos del especialista.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($" * Especialidad: {this.Campo}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura del metodo ToString para mostrar los datos 
        /// del especialista de manera publica.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
