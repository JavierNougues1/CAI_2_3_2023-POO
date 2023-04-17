using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda("Agenda", "Contactos", 5);
            while(true)
            {
                try
                {
                    int opcMenu = Validacion.Menu("1. Agregar Contacto \n 2. Eliminar Contacto \n3. Visualizar Contacto Frecuente \n4. Visualizar Contactos \n0. Salir", 0, 4);
                    switch (opcMenu)
                    {
                        case 0:
                            Console.WriteLine("Presione una tecla para salir.");
                            Console.ReadKey();
                            break;
                        case 1: 
                            AgregarContacto(agenda);
                            continue;
                        case 2:
                            EliminarContacto(agenda);
                            continue;
                        case 3:
                            VisualizarContactoFrecuente(agenda);
                            continue;
                        case 4:
                            VisualizarContactos(agenda);
                            continue;
                        default: 
                            Console.WriteLine("Opción inválida, presione una tecla para continuar.");
                            Console.ReadKey();
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("La opción es inválida.");
                }
                break;
            }
        }

        private static void AgregarContacto(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void EliminarContacto(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void VisualizarContactoFrecuente(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void VisualizarContactos(Agenda agenda)
        {
            throw new NotImplementedException();
        }
    }
}
