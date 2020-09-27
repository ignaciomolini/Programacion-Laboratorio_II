using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Estaciones
    {
        Verano, Primavera, Invierno, Otonio
    }

    public static class MetodoDeExtension
    {
        public static string ObtenerPlacaCronica(this DateTime fecha, Estaciones estacion)
        {
            string diasQueFaltan;
            TimeSpan timeSpan = new TimeSpan();
            DateTime dateTime;
            
            switch(estacion)
            {
                case Estaciones.Verano:
                    dateTime = new DateTime(2020, 12, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;

                case Estaciones.Primavera:
                    dateTime = new DateTime(2020, 9, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;

                case Estaciones.Invierno:
                    dateTime = new DateTime(2020, 6, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;

                case Estaciones.Otonio:
                    dateTime = new DateTime(2021, 3, 21);
                    timeSpan = dateTime.Subtract(fecha);
                    break;
            }

            if(estacion == Estaciones.Primavera)
            {
                diasQueFaltan = $"Faltan {(int)timeSpan.TotalDays} para la Primavera";
            }
            else
            {
                diasQueFaltan = $"Faltan {(int)timeSpan.TotalDays} para el {estacion}";
            }

            return diasQueFaltan;
        }
    }
}
