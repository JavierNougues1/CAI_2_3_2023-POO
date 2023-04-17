using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    public class ContactoEmpresa : Contacto
    {
        public string _razonSocialContacto { get; set; }
        public DateTime _fechaConstitucionContacto { get; set; }  
        public ContactoEmpresa(int codigoContacto, string direccionContacto, int llamadasContacto, string razonSocialContacto, DateTime fechaConstitucionContacto) : base(codigoContacto, direccionContacto, llamadasContacto)
        {
            _codigoContacto = codigoContacto;
            _direccionContaco = direccionContacto;
            _llamadasContacto = llamadasContacto;
            _razonSocialContacto = razonSocialContacto;
            _fechaConstitucionContacto = fechaConstitucionContacto;
        }

        public override void Llamar()
        {
            _llamadasContacto++;
        }
        public int Antiguedad()
        {
            int antiguedad;
            TimeSpan antiguedadCalculada = DateTime.Today - _fechaConstitucionContacto;
            antiguedad = Convert.ToInt32(antiguedadCalculada);
            return antiguedad;
        }
    }
}
