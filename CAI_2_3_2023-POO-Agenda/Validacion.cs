using System;

namespace CAI_2_3_2023_POO_Agenda
{
    internal class Validacion
    {
        internal static int Menu(string mensaje, int min, int max)
        {
            int input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = int.Parse(Console.ReadLine());
                if (input.ToString().Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (!int.TryParse(input.ToString(), out input))
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un número.");
                    continue;
                }
                break;
            }
            return input;
        }

        internal static int PedirInt(string mensaje)
        {
            int input;
            while(true)
            {
                Console.WriteLine(mensaje);
                input = int.Parse(Console.ReadLine());
                if (input.ToString().Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un código.");
                    continue;
                }
                if (!int.TryParse(input.ToString(), out input))
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un código numérico.");
                    continue;
                }
                break;
            }
            return input;
        }
        public static string PedirString(string mensaje)
        {
            string input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = Console.ReadLine();
                if (input == null)
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if(int.TryParse(input, out int num))
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar una cadena de texto.");
                    continue;
                }
                break;
            }
            return input;
        }
    }
}