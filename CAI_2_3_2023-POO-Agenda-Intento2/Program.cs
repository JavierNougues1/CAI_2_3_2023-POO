using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Intento2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Me falta el parametro de la lista de contactos.
            Agenda agenda = new Agenda("Agenda1", "Tipo1", , 100);

            while (true) 
            {
                int opcMenu = Validacion.Menu("1- Agregar Contacto \n2- Eliminar Contacto \n3- Llamar Contacto \n4- Listar Contactos \n5- Mostrar Contacto Frecuente \n0- Salir", 0, 5);
                switch (opcMenu)
                {
                    case 0: 
                        Console.WriteLine("Gracias por utilizar nustro sistema. \nPresione una tecla para continuar.");
                        Console.ReadKey();
                        System.Environment.Exit(0); break;
                    case 1:
                        AgregarContacto();
                        continue;
                    case 2:
                        EliminarContacto();
                        continue;
                    case 3:
                        LlamarContacto();
                        continue;
                    case 4:
                        ListarContactos();
                        continue;
                    case 5:
                        TraerContactoFrecuente();
                        continue;

                    default: break;

                }
            }
        }
        private static void AgregarContacto()
        {
            Contacto nuevoContacto = null;
            nuevoContacto._codigoContacto = Validacion.PedirInt("Código de Contacto:");
            nuevoContacto._nombreContacto = Validacion.PedirString("Nombre Contacto:");
            nuevoContacto._apelidoContacto = Validacion.PedirString("Apellido Contacto");
            nuevoContacto._telefonoContacto = Validacion.PedirString("Teléfono Contacto:");
            nuevoContacto._fechaNacimiento = Validacion.PedirFecha("Fecha Nacimiento Contacto");
            nuevoContacto._direccionContacto = Validacion.PedirString("Dirección Contacto:");
            nuevoContacto._llamadas = 0;

            agenda.AgregarContacto(nuevoContacto);

            Console.WriteLine("Se agregó el contacto satisfactoriamente. \nPresione una tecla para continuar.");
            Console.ReadKey();
        }
        private static void EliminarContacto()
        {
            int codContacto = Validacion.PedirInt("Ingrese el código del contacto a eliminar:");

            agenda.EiminarContacto(codContacto);

            Console.WriteLine("Se agregó el contacto satisfactoriamente. \nPresione una tecla para continuar.");
            Console.ReadKey();

        }
        private void LlamarContacto()
        {
            Contacto contactoBuscado = null;
            int codContacto = Validacion.PedirInt("Ingrese código de contacto:");
            contactoBuscado = agenda.BuscarContacto(codContacto);
            if (contactoBuscado != null)
            {
                contactoBuscado.Llamar();
            }

            Console.WriteLine("\nPresione una tecla para continuar.");
            Console.ReadKey();
        }
    }
}
