using System;

namespace CAI_2_3_2023_POO_Agenda_Intento3
{
    internal class Validacion
    {
        internal static DateTime Fecha(string msj)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msj);
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    throw new Exception("Debe ingresar un valor:");
                }
                if (!DateTime.TryParse(input, out DateTime date))
                {
                    throw new Exception("Debe ingresar un valor fecha:");
                }
                break;
            }
            return Convert.ToDateTime(input);
        }

        internal static int Int(string msj)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msj);
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    throw new Exception("Debe ingresar un valor:");
                }
                if (!int.TryParse(input, out int num))
                {
                    throw new Exception("Debe ingresar un valor numérico:");
                }
                break;
            }
            return Convert.ToInt32(input);
        }

        internal static int Menu(string msj, int min, int max)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msj);
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    throw new Exception("Debe ingresar un valor:");
                }
                if (!int.TryParse(input, out int num))
                {
                    throw new Exception("Debe ingresar un valor numérico:");
                }
                if (Convert.ToInt32(input) < min || Convert.ToInt32(input) > max)
                {
                    throw new Exception("Opción incorrecta:");
                }
                break;
            }
            return Convert.ToInt32(input);
        }

        internal static string String(string msj)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msj);
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    throw new Exception("Debe ingresar un valor:");
                }
                if (int.TryParse(input, out int num))
                {
                    throw new Exception("El valor ingresado debe ser texto:");
                }
                break;
            }
            return input;
        }
    }
}