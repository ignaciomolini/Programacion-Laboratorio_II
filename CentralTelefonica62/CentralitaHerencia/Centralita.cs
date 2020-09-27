﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        private string rutaDeArchivo = "registroDeLlamadas.txt";
            
        #region Propiedades
        public string RutaDeArchivo 
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        public bool Guardar()
        {
            bool retorno = false;
            string mensaje;
            StringBuilder sb = new StringBuilder();

            sb.Append(DateTime.Now.ToString("dddd d 'de' MMMM 'de' yyy HH:mm'hs'"));
            sb.Append(" - Se realizó una llamada.");
            mensaje = sb.ToString().First().ToString().ToUpper() + sb.ToString().Substring(1);

            try
            {
                using (StreamWriter sw = new StreamWriter(this.RutaDeArchivo, true, UTF8Encoding.Default))
                {
                    sw.WriteLine(mensaje);
                    retorno = true;
                }
            }
            catch(Exception)
            {
                
            }
                
            return retorno;
        }

        public string Leer()
        {
            string info = "";

            if(File.Exists(this.RutaDeArchivo))
            {
                using (StreamReader sr = new StreamReader(this.RutaDeArchivo, UTF8Encoding.Default))
                {
                    info = sr.ReadToEnd();
                }
            }
           
            return info;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retornoGanancias = 0;

            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (item is Local)
                        {
                            retornoGanancias += ((Local)item).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (item is Provincial)
                        {
                            retornoGanancias += ((Provincial)item).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if (item is Local)
                        {
                            retornoGanancias += ((Local)item).CostoLlamada;
                        }
                        else if (item is Provincial)
                        {
                            retornoGanancias += ((Provincial)item).CostoLlamada;
                        }
                        break;
                }
            }

            return retornoGanancias;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            int i = 1;

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancias en llamadas locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancias en llamadas provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine($"Ganancias en total: {this.GananciasPorTotal}");

            sb.AppendLine("\nDatos de las llamadas:\n");
            foreach (Llamada item in this.listaDeLlamadas)
            {
                if (item is Local)
                {
                    sb.AppendLine($"{i}-{((Local)item).ToString()}");
                }
                else if (item is Provincial)
                {
                    sb.AppendLine($"{i}-{((Provincial)item).ToString()}");
                }
                i++;
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion

        #region Operadores
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada item in c.Llamadas)
            {
                if(item == llamada)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if(c == nuevaLlamada)
            {
                throw new CentralitaException("La llamada ya esta en el sistema", "Centralita", "Sobrecarga operador +");
            }
            else
            {
                if(!c.Guardar())
                {
                    throw new CentralitaException("FallaLogException", "Centralita", "Sobrecarga operador +");
                }
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }
        #endregion

    }
}
