using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Intento3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda("agenda1", "Amigos", 100);
            while (true)
            {
                try
                {
                    int opcMenu = Validacion.Menu("1. Agregar Contacto \n2. Eliminar Contacto \n3. Visualizar Contacto Frecuente \n4. Llamar Contacto \n0. Salir");
                    switch (opcMenu)
                    {
                        case 0:Console.WriteLine("Gracias por utilizar nuestro sistema. \nPresione una tecla para salir."); break;
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
                            LlamarContacto(agenda);
                            continue;
                        default: Console.WriteLine("Opciónn inválida. \n Presione una tecla para continuar."); continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
            }
        }

        private static void LlamarContacto(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void VisualizarContactoFrecuente(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void EliminarContacto(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        private static void AgregarContacto(Agenda agenda)
        {

        }
    }
}
