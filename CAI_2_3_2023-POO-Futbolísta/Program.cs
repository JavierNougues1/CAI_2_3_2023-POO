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
            Console.WriteLine("Bienvenido al sistema de 'Almacenamiento de Futbolístas'!");
            int opcMenu = Validacion.OpcionMenu("Qué desea hacer?: \n1- Agregar jugador \n2- Visualizar jugadores", 1,2);
            switch (opcMenu)
            {
                case 1:
                    Jugador nuevoJugador = new Jugador();
                    nuevoJugador.AgregarJugador(nuevoJugador);
                    break;
                case 2:
                    Jugador buscarJugador = new Jugador();
                    buscarJugador.BuscarJugador(buscarJugador);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}
