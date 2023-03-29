using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Carta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a 'Siete Fuegos' del reconocido chef Francis Mallmann");
            int opcMenu = Validacion.opcionMenu("Menu Principal: \n1- Tragos de Autor: \n2- Entradas:\n3- Principales: \n4- Postres: \n5- Cafetería:", 1, 5);
            switch(opcMenu) 
            { 
                case 1: 
                    Tragos.tragosAutor();
                    break;
                default : 
                    Console.WriteLine("Opción inválida.");
                    Console.WriteLine("Presione cualquier letra para continuar.");
                    Console.ReadKey();
                    break;
                    
            }
        }
    }
}
