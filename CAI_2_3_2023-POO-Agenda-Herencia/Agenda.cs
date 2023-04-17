using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    internal class Agenda
    {
        private string _nombreAgenda { get; }
        private string _tipoAgenda { get; }
        private int _cantContactosAgenda { get; }

        private List<Contacto> _contactos = new List<Contacto>();

        public Agenda(String nombreAgenda, string tipoAgenda, int cantContactosAgenda)
        {
            _nombreAgenda = nombreAgenda;
            _tipoAgenda = tipoAgenda;
            _cantContactosAgenda = cantContactosAgenda;
        }
        public void AgregarContacto(Contacto nuevoContacto)
        {
            if (_contactos.Count >= _cantContactosAgenda)
            {
                throw new Exception("Agenda llena.");
            }
            if (ContactoExiste(nuevoContacto._codigoContacto))
            {
                throw new Exception("El contacto que desea agregar ya se encuentra registrado.");
            }
            _contactos.Add(nuevoContacto);
        }
        public void EliminarContacto(int codigoContacto)
        {
            if (!ContactoExiste(codigoContacto))
            {
                throw new Exception("El contacto que desea eliminar no existe.");
            }
            foreach (var c in _contactos)
            {
                if (c._codigoContacto == codigoContacto)
                {
                    _contactos.Remove(c);
                }
                break;
            }
        }
        public Contacto TraerContactoFrecuente()
        {
            int contadorLlamadas = 0;
            Contacto contactoFrecuente = null;
            if (_contactos.Count == 0)
            {
                throw new Exception("No tiene contactos registrados.");
            }
            foreach (var c in _contactos)
            {
                if (c._llamadasContacto > contadorLlamadas)
                {
                    contadorLlamadas = c._llamadasContacto;
                    contactoFrecuente = c;
                }
            }
            return contactoFrecuente;
        }

        public void VisualizarContactos()
        {
            if (ExistenContactos())
            {
                foreach (Contacto c in _contactos)
                {
                    if (c is ContactoEmpresa)
                    {
                        Console.WriteLine($"Razón Social: {((ContactoEmpresa)c)._razonSocialContacto}");
                    }
                    if (c is ContactoPersona)
                    {
                        Console.WriteLine($"Nombre y Apellido: {((ContactoPersona)c)._nombraContacto} {((ContactoPersona)c)._apellidoContacto}");
                    }
                }
            }
            else { throw new Exception("No tiene contactos registrados."); }
            Console.WriteLine("\nPresione una tecla para continuar.");
            Console.ReadKey();
        }
        private bool ContactoExiste(int codigoContacto)
        {
            bool existe = false;
            foreach (var c in _contactos)
            {
                if (c._codigoContacto == codigoContacto)
                {
                    existe = true;
                }
                break;
            }
            return existe;
        }
        private bool ExistenContactos()
        {
            bool hayContactos = true;
            if (_contactos.Count == 0)
            {
                hayContactos = false;
            }
            return hayContactos;

        }
    }
}
