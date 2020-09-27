using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        protected int id;
        protected string apellido;
        protected string nombre;
        protected int edad;
        protected string sexo;
        protected string direccion;

        /// <summary>
        /// Propiedad que setea y retorna el atributo id.
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo apellido.
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo edad.
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo sexo.
        /// </summary>
        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        /// <summary>
        /// Propiedad que setea y retorna el atributo direccion.
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Persona()
        {

        }

        /// <summary>
        /// Constructor con parametros que asigna todos los atributos que se le pasan.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sexo"></param>
        /// <param name="direccion"></param>
        public Persona(int id, string apellido, string nombre, int edad, string sexo, string direccion)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.direccion = direccion;
        }

        /// <summary>
        /// Metodo que muestra los datos de la persona.
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"ID: {this.Id}");
            sb.Append($" * Nombre: {this.Nombre}");
            sb.Append($" * Apellido: {this.Apellido}");
            sb.Append($" * Edad: {this.Edad}");
            sb.Append($" * Direccion: {this.Direccion}");

            return sb.ToString();
        }
    }
}
