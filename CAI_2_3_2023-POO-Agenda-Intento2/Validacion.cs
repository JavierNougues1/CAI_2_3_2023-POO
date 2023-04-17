using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CAI_2_3_2023_POO_Agenda_Intento2
{
    internal class Validacion
    {
        public static int Menu(string mensaje, int min, int max)
        {
            int input;
            while (true) 
            {
                Console.WriteLine(mensaje);
                input = int.Parse(Console.ReadLine());  
                if (input > max || input < min)
                {
                    throw new Exception("El valor ingresado no se encuentra dentro de los parámetros disponibles.");
                }
                if (!int.TryParse(input.ToString(), out int num))
                {
                    throw new Exception("El valor ingresado debe ser un número.");
                }
                break;
            }
            return input;
        }

        internal static int PedirInt(string mensaje)
        {
            int input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = int.Parse(Console.ReadLine());
                if (!int.TryParse(input.ToString(), out int num))
                {
                    throw new Exception("El valor ingresado debe ser un número.");
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
                    throw new Exception("Debe ingresar un valor");
                }
                if (int.TryParse(input, out int num))
                {
                    throw new Exception("El valor ingresado no debe ser un número.");
                }
                break;
            }
            return input;
        }
        public static DateTime PedirFecha(string mensaje)
        {
            DateTime input;
            while (true)
            {
                Console.WriteLine(mensaje);
                input = DateTime.Parse(Console.ReadLine());
                if (input == null)
                {
                    throw new Exception("Debe ingrear un valor.");
                }
                if (!DateTime.TryParse(input.ToString(),out  DateTime fecha))
                {
                    throw new Exception("Debe ingresar una fecha.");
                }
                break;
            }
            return input;
        }
    }
}