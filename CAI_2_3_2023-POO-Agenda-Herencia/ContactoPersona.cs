using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    internal class ContactoPersona : Contacto
    {
        public string _nombraContacto { get; set; }
        public string _apellidoContacto { get; set; }
        public DateTime _fechaNacContacto { get; set; }
        public ContactoPersona(int codigoContacto, string direccionContacto, int llamadasContacto, string nombreContacto, string apellidoContacto, DateTime fechaNacContacto) : base(codigoContacto, direccionContacto, llamadasContacto)
        { 
            _codigoContacto = codigoContacto;
            _direccionContaco = direccionContacto;
            _llamadasContacto = llamadasContacto;
            _nombraContacto = nombreContacto;
            _apellidoContacto = apellidoContacto;
            _fechaNacContacto = fechaNacContacto;
        }

        public override void Llamar()
        {
            _llamadasContacto++;
        }
        public int Edad()
        {
            int edad;
            TimeSpan edadCalculada = DateTime.Today - _fechaNacContacto;
            edad = Convert.ToInt32(edadCalculada);
            return edad;
        }
    }
}
