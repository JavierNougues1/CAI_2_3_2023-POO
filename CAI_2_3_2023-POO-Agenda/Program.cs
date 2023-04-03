using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                int opcMenu = Validacion.Menu("Seleccione una operación: \n1- Llamar contaco. \n2- Agregar contacto. \n3- Eliminar contacto \n4- Traer contacto frecuente \n0- Salir", 0, 4);
                switch (opcMenu)
                {
                    case 0: System.Environment.Exit(0); break;
                    case 1:
                        Contacto contactoActivo = new Contacto();
                        contactoActivo.Llamar();
                        continue;
                    case 2:
                        Contacto.PedirDatos();
                        continue;
                    case 3:
                        //Agenda.EliminarContacto();
                        continue;
                    case 4:
                        //Agenda.TraerContactoFrecuente();
                        continue;
                    default: continue;
                }
                break;
            }
        }
    }
}
