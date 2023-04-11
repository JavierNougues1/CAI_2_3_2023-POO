using System;

namespace CAI_2_3_2023_POO_Agenda_Intento2
{
    public class Contacto
    {
        public int _codigoContacto { get; set; }
        public string _nombreContacto { get; set; }
        public string _apelidoContacto { get; set; }
        public int _telefonoContacto { get; set; }
        public string _direccionContacto { get; set; }
        public DateTime _fechaNacimiento { get; set; }
        public int _llamadas { get; set; }

        public Contacto(int codigoContacto, string nombreContacto, string apelidoContacto, int telefonoContacto, string direccionContacto, DateTime fechaNacimiento, int llamadas)
        {
            _codigoContacto = codigoContacto;
            _nombreContacto = nombreContacto;
            _apelidoContacto = apelidoContacto;
            _telefonoContacto = telefonoContacto;
            _direccionContacto = direccionContacto;
            _fechaNacimiento = fechaNacimiento;
            _llamadas = llamadas;
        }
        public int Edad()
        {
            int edad;
            TimeSpan calculo = (DateTime.Now - _fechaNacimiento);
            edad = Convert.ToInt32(calculo);
            return edad;
        }
        public void Llamar()
        {
            _llamadas += 1;
        }
    }
}