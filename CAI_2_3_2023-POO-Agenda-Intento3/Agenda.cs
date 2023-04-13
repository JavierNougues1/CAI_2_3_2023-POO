using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Intento3
{
    internal class Agenda
    {
        private string _nombre { get; }
        private string _tipo { get; }
        private int _cantMaxContactos { get; }
        private List<Contacto> _contactos = new List<Contacto>();

        public Agenda(string nombre, string tipo, int cantMaxContactos)//, List<Contacto> contactos)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantMaxContactos = cantMaxContactos;
            //_contactos = contactos;
        }

        public void AgregarContacto(int codContacto, string nombreContacto, string apellidoContacto, string telefonoContacto, string direccionContacto, DateTime fechaNacContacto, int llamadasContacto)
        {
            if (_contactos.Count < _cantMaxContactos)
            {
                _contactos.Add(new Contacto(codContacto, nombreContacto, apellidoContacto, telefonoContacto, direccionContacto, fechaNacContacto, llamadasContacto));
            }
            else { throw new Exception("Cantidad máxima de contactos alcanzada."); }
        }
        public void EliminarContacto(int codContacto)
        {
            if (_contactos != null || _contactos.Count == 0)
            {
                throw new Exception("La agenda esta vacía.");
            }
            foreach (var c in _contactos)
            {
                if (c._codContacto == codContacto)
                {
                    _contactos.Remove(c);
                }
                else
                {
                    throw new Exception("No hay un contacto registrado bajo el código ingresado.");
                }
                break;
            }
        }
        public Contacto TraerContactoFrecuente()
        {
            Contacto contactoFrecuente = null;
            int cantLlamadas = 0;
            if (_contactos != null || _contactos.Count == 0)
            {
                throw new Exception("La agenda esta vacía.");
            }
            foreach (var c in _contactos)
            {
                if (c._llamadasContacto > cantLlamadas)
                {
                    cantLlamadas = c._llamadasContacto;
                    contactoFrecuente = c;
                }
            }
            if (cantLlamadas == 0)
            {
                throw new Exception("No posee llamadas registradas para niguno de sus contactos.");
            }
            return contactoFrecuente;
        }
    }
}
