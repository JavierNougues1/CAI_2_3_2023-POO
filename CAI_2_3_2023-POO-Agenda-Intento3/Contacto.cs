using System;

namespace CAI_2_3_2023_POO_Agenda_Intento3
{
    internal class Contacto
    {
        public int _codContacto { get; set; }
        public string _nombreContacto { get; set; }
        public string _apellidoContacto { get; set; }
        public string _telefonoContacto { get; set; }
        public string _direccionContacto { get; set; }
        public DateTime _fechaNacContacto { get; set; }
        public int _llamadasContacto { get; set; }

        public Contacto(int codContacto, string nombreContacto, string apellidoContacto, string telefonoContacto, string direccionContacto, DateTime fechaNacContacto, int llamadasContacto)
        {
            _codContacto = codContacto;
            _nombreContacto = nombreContacto;
            _apellidoContacto = apellidoContacto;
            _telefonoContacto = telefonoContacto;
            _direccionContacto = direccionContacto;
            _fechaNacContacto = fechaNacContacto;
            _llamadasContacto = llamadasContacto;


        }
    }
}