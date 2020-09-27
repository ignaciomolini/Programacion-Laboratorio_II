using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(DateTime.Now.ToString("dddd d 'de' MMMM 'de' yyy HH:mm'hs'"));
            sb.Append(" - Se realizó una llamada.");
      
            Console.WriteLine(sb.ToString().Substring(0, 1).ToUpper() + sb.ToString().Substring(1));

            Console.ReadKey();
        }
    }
}
