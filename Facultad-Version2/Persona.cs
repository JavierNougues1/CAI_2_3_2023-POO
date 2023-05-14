using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad_Version2
{
    internal abstract class Persona
    {
        //Atributos
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;

        //Constructor
        public Persona(string apellido, string nombre)
        {
            _apellido = apellido;
            _nombre = nombre;
        }

        //Propiedades
        public string Apellido { get { return _apellido; } set { _apellido = value; } } 
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int Edad { get { return (DateTime.Now - _fechaNac).Days/365; } }

        //Metodos
        public abstract string GetCredencial();
        public abstract string GetNombreCompleto();
    }
}
