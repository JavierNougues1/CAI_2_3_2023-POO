using System;
using System.Diagnostics.Contracts;

namespace CAI_2_3_2023_POO_Agenda
{
    public class Contacto
    {
        public int _codigoContacto { get; set; }
        public string _nombre { get; set; }    
        public string _apellido { get; set; }
        public string _telefono { get; set; }
        public string _direccion { get; set; }
        public DateTime _fechaNacimiento { get; set; }
        public int _llamadas { get; set; }

        public static Contacto PedirDatos()
        {
            Contacto nuevoContacto = new Contacto();
            int codContacto;
            while (true)
            {
                codContacto = Validacion.PedirInt("Ingrese un código de contacto:");
                bool validarContacto = Agenda.ValidarCodigoContacto(codContacto);
                if (validarContacto)
                {
                    Console.Clear();
                    Console.WriteLine("El código de contacto ingresado ya se encuentra registrado.");
                    continue;
                }
                break;
            }
            nuevoContacto._codigoContacto = codContacto;
            nuevoContacto._nombre = Validacion.PedirString("Ingrese nombre de contacto:");
            nuevoContacto._apellido = Validacion.PedirString("Ingrese apellido de contacto:");
            //nuevoContacto._fechaNacimiento = DateTime.Parse(Console.ReadLine());
            nuevoContacto._telefono = Validacion.PedirInt("Ingrese número de télefono de contacto:").ToString();
            nuevoContacto._direccion = Validacion.PedirString("Ingrese dirección de contacto:"); ;
            nuevoContacto._llamadas = 0;

            Agenda.AgregarContacto(nuevoContacto);
            Console.WriteLine("\nContacto agregado satisfactoriamente! \nPresione una tecla para continuar.");
            Console.ReadKey();
            return nuevoContacto;
        }

        public int Edad()
        {
            int edad;
            TimeSpan edadActaul = DateTime.Now - _fechaNacimiento;
            edad = int.Parse(edadActaul.ToString());
            return edad;
        }
        public void Llamar()
        {
            Agenda llamarContacto = new Agenda();
            int codContacto = PedirCodigoContacto();
            foreach (var contacto in llamarContacto._contactos)
            {
                if (contacto._codigoContacto == codContacto)
                {
                    contacto._llamadas += 1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No posee un contacto bajo el código ingreesado.");
                    Console.ReadKey();
                    break;
                }
                break;
            }
            if (llamarContacto._contactos.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No posee contactos registrados.");
                Console.ReadKey();
            }
        }
        private int PedirCodigoContacto()
        {
            int codContacto;
            codContacto = Validacion.PedirInt("Ingrese código de contacto para llamar:");
            return codContacto;
        }

    }
}