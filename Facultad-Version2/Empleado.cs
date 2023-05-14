using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad_Version2
{
    internal abstract class Empleado : Persona
    {
        //Atributos
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salarios;

        //Constructor
        public Empleado(string apellido, DateTime fechaNac, string nombre, DateTime fechaIngreso, int legajo) : base(apellido, nombre)
        {
            _fechaNac = fechaNac;
            _fechaIngreso = fechaIngreso;
            _legajo = legajo;
            _salarios = new List<Salario>();
        }

        //Propiedades
        public int Antiguedad { get { return (DateTime.Now - _fechaIngreso).Days / 365; } }
        public DateTime FechaIngreso { get { return _fechaIngreso; } set { _fechaIngreso = value; } }
        public DateTime FechaNacimiento { get { return _fechaNac; } }
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public List<Salario> Salarios { get { return _salarios; } }
        //public Salario UltimoSalario { }

        //Metodos
        public void AgregarSalario(Salario salario)
        {
            Salarios.Add(new Salario(salario.Bruto, salario.CodigoTransferencia, salario.Descuentos, salario.Fecha));
        }

        //public bool Equals(object objeto){}

        public override string GetCredencial()
        {
            //"Empleado [Legajo] - [Apellido], [Nombre]"
            throw new NotImplementedException();
        }
        public override string GetNombreCompleto()
        {
        //Docente: "Docente [Apellido], [Nombre]"
        //Directivo: "Directivo [Apellido], [Nombre]"
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }


    }
}
