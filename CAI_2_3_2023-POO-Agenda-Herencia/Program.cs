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
                    throw new Exception("La opción es inválida." + ex.Message);
                }
                break;
            }
        }

        private static void AgregarContacto(Agenda agenda)
        {
            try
            {
                Contacto nuevoContacto = null;
                int cod = Validacion.PedirInt("Codigo:");
                string direc = Validacion.PedirString("Dirección:");
                int llamadas = 0;
                int opcContacto = Validacion.Menu("1. Persona Física \n2. Empresa", 1, 2);
                switch (opcContacto)
                {
                    case 1:
                        string nombre = Validacion.PedirString("Nombre:");
                        string apellido = Validacion.PedirString("Apellido:");
                        DateTime fechaNac = Validacion.PedirFecha("Fecha de NAcimiento:");
                        nuevoContacto = new ContactoPersona(cod, direc, llamadas, nombre, apellido, fechaNac);
                        break;
                    case 2:
                        string razon = Validacion.PedirString("Razón Social:");
                        DateTime fechaConst = Validacion.PedirFecha("Fecha de Constitución:");
                        nuevoContacto = new ContactoEmpresa(cod, direc,llamadas, razon, fechaConst);
                        break;
                }
                agenda.AgregarContacto(nuevoContacto);
                Console.WriteLine($"\nContacto: {cod} agregado. \nPresione una tecla para continuar.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private static void EliminarContacto(Agenda agenda)
        {
            try
            {
                int cod = Validacion.PedirInt("Código:");
                agenda.EliminarContacto(cod);

                Console.WriteLine($"\nContacto: {cod} eliminado. \nPresione una tecla para continuar.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void VisualizarContactoFrecuente(Agenda agenda)
        {
            try
            {
                agenda.TraerContactoFrecuente();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void VisualizarContactos(Agenda agenda)
        {
            try
            {

            }
            catch (Exception ex)
            { 
                throw new Exception(ex.Message);
            }
        }
    }
}
