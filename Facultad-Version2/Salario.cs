using System;

namespace Facultad_Version2
{
    internal class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public Salario(double bruto, string codigoTransferencia, double descuentos, DateTime fecha)
        {
            _bruto = bruto;
            _codigoTransferencia = codigoTransferencia;
            _descuentos = descuentos;
            _fecha = fecha;
        }

        public double Bruto { get { return _bruto; }set { _bruto = value; } }
        public string CodigoTransferencia { get {  return _codigoTransferencia; }set { _codigoTransferencia = value;} }
        public double Descuentos { get {  return _descuentos; }set { _descuentos = value; } }
        public DateTime Fecha { get { return _fecha; }set { _fecha = value; } }

        public double GetSalarioNeto()
        {
            //Supongo que para el neto le saco el 20%.
            return Bruto * 0.8;
        }
    }
}