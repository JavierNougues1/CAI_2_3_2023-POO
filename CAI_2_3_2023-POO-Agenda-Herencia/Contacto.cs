using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Agenda_Herencia
{
    public abstract class Contacto
    {
        public int _codigoContacto {  get; set; }
        public string _direccionContaco { get; set; }
        public int _llamadasContacto { get; set; }

        public Contacto(int codigoContacto, string direccionContacto, int llamadasContacto)
        {
            _codigoContacto = codigoContacto;
            _direccionContaco = direccionContacto;
            _llamadasContacto = llamadasContacto;
        }

        public abstract void Llamar();
    }
}
