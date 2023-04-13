using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
                    int opcMenu = Validacion.Menu("1. Agregar Contacto \n2. Eliminar Contacto \n3. Visualizar Contacto Frecuente \n4. Llamar Contacto \n0. Salir", 0, 4);
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
            agenda.TraerContactoFrecuente();
        }

        private static void EliminarContacto(Agenda agenda)
        {
            try
            {
                int codigo = Validacion.Int("Codigo:");
                agenda.EliminarContacto(codigo);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en los datos: " + ex.Message);
            }
        }

        private static void AgregarContacto(Agenda agenda)
        {
            try
            {
                int codigo = Validacion.Int("Codigo:");
                string nombre = Validacion.String("Nombre:");
                string apellido = Validacion.String("Apellido:");
                string telefono = Validacion.String("Telefono:");
                string direccion = Validacion.String("Dirección:");
                DateTime fecha = Validacion.Fecha("Fecha de Nacimiento:");
                int llamadas = 0;

                agenda.AgregarContacto(codigo, nombre, apellido, telefono, direccion, fecha, llamadas);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el ingreso de datos: " + ex.Message);
            }

        }
    }
}
