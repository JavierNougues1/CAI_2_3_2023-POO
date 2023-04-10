﻿using Microsoft.SqlServer.Server;
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
            Agenda agenda = new Agenda("Agenda1", "Tipo1", 100);

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
                        agenda.ListarContactos();
                        continue;
                    case 5:
                        agenda.TraerContactoFrecuente();
                        continue;

                    default: break;

                }
            }
        }
        private static void AgregarContacto()
        {
            
            int cod = Validacion.PedirInt("Código de Contacto:");
            string nombre = Validacion.PedirString("Nombre Contacto:");
            string apelido = Validacion.PedirString("Apellido Contacto");
            string tel = Validacion.PedirString("Teléfono Contacto:");
            DateTime fecha= Validacion.PedirFecha("Fecha Nacimiento Contacto");
            string direc = Validacion.PedirString("Dirección Contacto:");
            int llamadas = 0;

            Agenda.AgregarContacto(cod, nombre, apelido, tel, direc, fecha, llamadas);

            Console.WriteLine("Se agregó el contacto satisfactoriamente. \nPresione una tecla para continuar.");
            Console.ReadKey();
        }
        private static void EliminarContacto()
        {
            int codContacto = Validacion.PedirInt("Ingrese el código del contacto a eliminar:");

            Agenda.EliminarContacto(codContacto);

            Console.WriteLine("Se agregó el contacto satisfactoriamente. \nPresione una tecla para continuar.");
            Console.ReadKey();

        }
        private static void LlamarContacto()
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
