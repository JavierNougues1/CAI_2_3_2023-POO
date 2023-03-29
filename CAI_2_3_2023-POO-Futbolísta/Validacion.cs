using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Futbolísta
{
    internal class Validacion
    {
        public static int OpcionMenu(string mensaje, int min, int max)
        {
            Console.WriteLine(mensaje);
            int input;
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input < min || input > max)
                {
                    Console.WriteLine("Opción inválida, intente nuevamente:");
                    continue;
                }
                break;
            }
            return input;
        }

        public static string PedirString(string mensaje)
        {
            Console.WriteLine(mensaje);
            string input;
            int numero;
            while (true) 
            {
                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    Console.WriteLine("El campo ingresado esta vacío, intente nuevamente:");
                }
                if (int.TryParse(input, out numero))
                {
                    Console.WriteLine("El nombre del jugador no puede contener números, intente nuevamente:");
                }
            }
        }

        internal static int PedirInt(string mensaje)
        {
            Console.WriteLine(mensaje);
            int input;
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input.ToString().Length == 0)
                {
                    Console.WriteLine("El campo ingresado esta vacío, intente nuevamente:");
                }
                if (!int.TryParse(input.ToString(), out int numero))
                {
                    Console.WriteLine("La edad del jugador solo puede contener números, intente nuevamente:");
                }
            }
        }
    }
}
