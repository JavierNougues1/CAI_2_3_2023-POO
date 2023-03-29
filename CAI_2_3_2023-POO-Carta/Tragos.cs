using System;

namespace CAI_2_3_2023_POO_Carta
{
    internal class Tragos
    {
        public static void tragosAutor()
        {


            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("En 'Siete Fuegos' contamos con una reducida pero exquisita carta de tragos los cuales lo llevarán a lugares inóspitos de su imaginación:");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            int opcMenu = Validacion.opcionMenu("1- No estoy seguro que ordenar, prefiero que me sorprendan con un trago!!! \n2- Visualizar carta de tragos:", 1, 2);
            switch (opcMenu)
            {
                case 1:
                    generarTrago();
                    break;
                case 2:
                    visualizarTrago();
                    break;
            }

        }

        private static void generarTrago()
        {
            Random rand = new Random();
            int randGenerado = rand.Next(1, 5);
            switch (randGenerado)
            {
                case 1:
                    Console.WriteLine("El trago seleccionado es el: Gin Tonic de Frutos Rojos");
                    break;
                case 2:
                    Console.WriteLine("El trago seleccionado es el: Porteño Sour");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Presione una tecla para volver al 'Menú Principal'!");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("El trago seleccionado es el: Johnnie Lemon");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Presione una tecla para volver al 'Menú Principal'!");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("El trago seleccionado es el: Pisco Mendozino");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Presione una tecla para volver al 'Menú Principal'!");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("El trago seleccionado es el: Gin Cordillero");
                    Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Presione una tecla para volver al 'Menú Principal'!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    Console.WriteLine("Presione cualquier letra para continuar.");
                    Console.ReadKey();
                    break;
            }
        }

        private static void visualizarTrago ()
            {
            int opcMenu = Validacion.opcionMenu("1- Gin Tonic de Frutos Rojos \n2- Porteño Sour \n3- Johnnie Lemon \n4- Pisco Mendozino \n5- Gin Cordillero", 1, 5);
            Console.WriteLine ("Maravillosa elección! El trago llegará a su mesa en tan solo unos momentos!");
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Presione una tecla para volver al 'Menú Principal'!");
            Console.ReadKey();
            }
    }
}