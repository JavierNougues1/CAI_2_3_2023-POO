using System;

namespace CAI_2_3_2023_POO_Carta
{
    internal class Validacion
    {
        public static int opcionMenu(string mensaje, int min, int max)
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
    }
}