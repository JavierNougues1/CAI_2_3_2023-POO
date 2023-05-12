using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class PedirUtilidad
    {
        public static string PedirString(string mensaje)
        {
            string input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = Console.ReadLine();
                if (input is null || input.Length == 0)
                {
                    Console.WriteLine("Ingrese una cadena.");
                    continue;
                }
                if (int.TryParse(input, out int num))
                {
                    Console.WriteLine("Ingrese una cadena.");
                    continue;
                }
                break;
            }
            return input;
        }
    }
}
