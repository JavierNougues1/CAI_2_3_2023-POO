using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Intento2
{
    public class Agenda
    {
        private string _nombre { get; set; }
        private string _tipo { get; set; }
        private List<Contacto> _contactos { get; set; }
        private int _cantidadMaxContactos { get; set; }

        public Agenda (string nombre, string tipo, int cantidadMaxContactos)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaxContactos = cantidadMaxContactos;
        }

        public void AgregarContacto(int codigoContacto, string nombreContacto, string apelidoContacto, int telefonoContacto, string direccionContacto, DateTime fechaNacimiento, int llamadas)
        {
            //Contacto nuevoContacto = new Contacto(codigoContacto, nombreContacto, apelidoContacto, telefonoContacto, direccionContacto, fechaNacimiento, llamadas);
            //_contactos.Add(nuevoContacto);
            _contactos.Add(new Contacto(codigoContacto, nombreContacto, apelidoContacto, telefonoContacto, direccionContacto, fechaNacimiento, llamadas));
        }
        public void EliminarContacto(int codContacto)
        {
            if (_contactos == null)
            {
                throw new Exception("No posee contactos registrados.");
            }
            foreach (var contacto in _contactos)
            {
                if (contacto._codigoContacto == codContacto)
                {
                    _contactos.Remove(contacto);
                }
                else
                {
                    throw new Exception("El código de contacto ingresado no corresponde a un contacto registrado.");
                }
                break;
            }
        }
        public Contacto TraerContactoFrecuente()
        {
            Contacto contactoFrecuente = null;
            int contadorLlamadas = 0;
            if (_contactos == null)
            {
                throw new Exception("No posee contactos registrados.");
            }
            foreach (var contacto in _contactos)
            {
                if (contacto._llamadas > contadorLlamadas)
                {
                    contadorLlamadas = contacto._llamadas;
                    contactoFrecuente = contacto;
                }
            }
            if (contadorLlamadas == 0)
            {
                Console.WriteLine("Ninguno de los contactos registrados ha realizado llamadas.");
            }
            return contactoFrecuente;
        }
        public void ListarContactos()
        {
            if (_contactos == null || _contactos.Count == 0)
            {
                throw new Exception("No posee contactos registrados.");
            }
            foreach (var contacto in _contactos)
            {
                Console.WriteLine($"{contacto._codigoContacto} {contacto._nombreContacto} {contacto._apelidoContacto} \n");
            }
            Console.WriteLine("\nPresione una tecla para continuar.");
            Console.ReadKey();
        }
        public bool BuscarContacto(int codContacto)
        {
            bool existe = false;
            if (_contactos == null || _contactos.Count == 0)
            {
                throw new Exception("No posee contactos registrados.");
            }
            foreach (var contacto in _contactos)
            {
                if (contacto._codigoContacto == codContacto)
                {
                    existe = true;
                }
                else
                {
                    throw new Exception("El código de contacto ingresado no corresponde a un contacto registrado.");
                }
                break;
            }
            return existe;
        }
    }
}
