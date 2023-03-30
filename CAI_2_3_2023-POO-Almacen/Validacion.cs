using System;

namespace CAI_2_3_2023_POO_Almacen
{
    internal class Validacion
    {
        public static int OpcionMenu(string mensaje, int min,  int max)
        {
            int input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = int.Parse(Console.ReadLine());
                if (input < min || input > max)
                {
                    Console.WriteLine($"El valor ingresado deber ser entre: {min} y {max}.");
                    continue;
                }
            }

            return input;
        }

        public static string ValidarString(string mensaje)
        {
            string input;
            while (true)
            {
                Console.Write(mensaje);
                input = Console.ReadLine();
                if (input.Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (int.TryParse(input, out int numero))
                {
                    Console.WriteLine("El valor ingresado no puede ser un número.");
                    continue;
                }
                break;
            }
            return input;
        }

        internal static int ValidarInt(string mensaje)
        {
            int input;
            while (true)
            {
                Console.Write(mensaje);
                input = int.Parse(Console.ReadLine());
                if (input.ToString().Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor:");
                    continue;
                }
                if (int.TryParse(input.ToString(), out int numero))
                {
                    Console.WriteLine("El valor ingresado debe ser un número");
                    continue;
                }
                break;
            }
            return input;
        }
    }
}