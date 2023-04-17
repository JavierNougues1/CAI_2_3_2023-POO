using System;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    internal class Validacion
    {
        internal static int Menu(string v1, int min, int max)
        {
            string input;
            int num;
            while (true)
            {
                Console.WriteLine(v1);
                input = Console.ReadLine();
                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Debe ingrear un valor numerico.");
                    continue;
                }
                if (int.TryParse(input, out num))
                {
                    if (num < min || num > max)
                        {
                            Console.WriteLine($"Debe ingrear un valor numerico entre: {min} y {max}.");
                            continue;
                        }
                    
                }
                break;
            }
            
            return Convert.ToInt32(input);
        }

        internal static DateTime PedirFecha(string v)
        {
            string input;
            while (true)
            {
                Console.WriteLine(v);
                input = Console.ReadLine();
                if (v == null || v.Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (!DateTime.TryParse(input, out DateTime fecha))
                {
                    Console.WriteLine("Debe ingresar fecha.");
                    continue;
                }
                break;
            }
            return Convert.ToDateTime(input);
        }

        internal static int PedirInt(string v)
        {
            string input;
            while (true)
            {
                Console.WriteLine(v);
                input = Console.ReadLine();
                if (v == null || v.Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("Debe ingresar un valor numerico.");
                    continue;
                }
                break;
            }
            return Convert.ToInt32(input);
        }

        internal static string PedirString(string v)
        {
            string input;
            while (true)
            {
                Console.WriteLine(v);
                input = Console.ReadLine();
                if (v == null || v.Length == 0)
                {
                    Console.WriteLine("Debe ingresar un valor.");
                    continue;
                }
                if (int.TryParse(input, out int num))
                {
                    Console.WriteLine("No puede ingresar un valor numerico.");
                    continue;
                }
                break;
            }
            return input;
        }
    }
}