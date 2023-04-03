using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda
{
    public class Agenda
    {
        private string _nombre { get; set; }
        private string _tipo { get; set; }
        private int _cantidadMaximaContactos {  get; set; }

        public List<Contacto> _contactos = new List<Contacto> { };

        public Agenda() { }

        public static void AgregarContacto(Contacto nuevoContacto)
        {
            Agenda agenda = new Agenda();
            agenda._contactos.Add(nuevoContacto);
        }
        public void EliminarContacto(int codContacto)
        {
            foreach (var contacto in _contactos)
            {
                if (contacto._codigoContacto == codContacto)
                {
                    _contactos.Remove(contacto);
                }
                else
                {
                    Console.WriteLine("No se encotró el contacto.");
                }
                break;
            }
        }
        public Contacto TraerContactoFrecuente()
        {
            Contacto contactoFrecuente = new Contacto();
            int contador = 0;
            if (_contactos == null)
            {
                Console.WriteLine("No posee contactos registrados.");
            }
            foreach (var contacto in _contactos)
            {
                if (contacto._llamadas > contador)
                {
                    contador = contacto._llamadas;
                    contactoFrecuente = contacto;
                }
            }
            return contactoFrecuente;
        }
        public static bool ValidarCodigoContacto(int codContacto)
        {
            Agenda agenda = new Agenda();
            bool existe = false;
            foreach (var contacto in agenda._contactos)
            {
                if (contacto._codigoContacto == codContacto)
                {
                    existe = true;
                }
            }
            return existe;
        }
    }
}
