using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAI_2_3_2023_POO_Carta;

namespace CAI_2_3_2023_POO_Futbolísta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al sistema de 'Almacenamiento de Futbolístas'!");
                int opcMenu = Validacion.OpcionMenu("Qué desea hacer?: \n1- Agregar Jugador \n2- Buscar Jugador \n3- Mostrar todos los Jugadores \n0- Salir del sistema", 0, 3);
                switch (opcMenu)
                {
                    case 1:
                        Jugador.AgregarJugador();
                        continue;
                    case 2:
                        Jugador.BuscarJugador();
                        continue;
                    case 3:
                        Jugador.DesplegarJugador();
                        continue;
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida.");
                        continue;
                }
                break;
            }

        }
    }
}
