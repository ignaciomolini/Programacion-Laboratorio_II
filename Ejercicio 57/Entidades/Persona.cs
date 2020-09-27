using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(Persona person, string path)
        {
            bool retorno = false;
            Stream fs = null;
            BinaryFormatter ser = new BinaryFormatter();

            try
            {
                fs = new FileStream(path, FileMode.Create);
                ser.Serialize(fs, person);
                retorno = true;
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(!(fs is null))
                {
                    fs.Close();
                }      
            }

            return retorno;
        }

        public static Persona Leer(string path)
        {
            Persona personaRetorno = null;
            Stream fs = null;
            BinaryFormatter ser = new BinaryFormatter();

            try
            {
                fs = new FileStream(path, FileMode.Open);
                personaRetorno = (Persona)ser.Deserialize(fs);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(!(fs is null))
                {
                    fs.Close();
                }
            }

            return personaRetorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");

            return sb.ToString();
        }
    }
}
