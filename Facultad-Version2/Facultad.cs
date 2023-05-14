using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades; 

namespace Facultad_Version2
{
    internal class Facultad
    {
        //Atributos
        private string _nombre;
        private int _catidadSedes;
        private List<Empleado> _empleados;
        private List<Alumno> _alumnos;

        //Constructor
        public Facultad(string nombre, int cantSedes)
        {
            _nombre = nombre;
            _catidadSedes = cantSedes;
            _empleados = new List<Empleado>();
            _alumnos = new List<Alumno>();
        }

        //Propiedades
        public int CantidadSedes { get { return _catidadSedes; }set { _catidadSedes = value;} }
        public string Nombre { get { return _nombre; }set { _nombre = value; } }
        
        //Metodos
        public void AgregarAlumno(Alumno alumnoNuevo) 
        {
            _alumnos.Add(alumnoNuevo);            
        }

        public void AgregarEmpleado(Empleado empleadoNuevo) 
        {
            _empleados.Add(empleadoNuevo);
        }

        public void EliminarAlumno(int codigoAlumno)
        {
            if (_alumnos.Any())
            {
                foreach (var a in _alumnos)
                {
                    if (a.Codigo == codigoAlumno)
                    {
                        _alumnos.Remove(a);
                    }
                    break;
                }
            }
        }

        public void EliminarEmpleado(int legajo)
        {
            if (_empleados.Any())
            {
                foreach (var e in _empleados)
                {
                    if (e.Legajo == legajo)
                    {
                        _empleados.Remove(e);
                    }
                    break;
                }
            }
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            if (_empleados.Any())
            {
                for(int i = 0; i < _empleados.Count; i++ )
                {
                    if (_empleados[i].Legajo == empleado.Legajo)
                    {
                        _empleados[i] = empleado;
                    }
                    break;
                }
            }
        }

        public List<Alumno> TraerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            if (_alumnos.Any())
            {
                alumnos = _alumnos;
            }
            return alumnos;
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            Empleado empleado = null;
            if (_empleados.Any())
            {
                foreach (var e in _empleados)
                {
                    if (e.Legajo == legajo)
                    {
                        empleado = e;
                    }
                    break;
                }
            }
            return empleado;
        }

        public List<Empleado> TraerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            if (_empleados.Any())
            {
                empleados = _empleados;
            }
            return empleados;
        }

        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> empleados= new List<Empleado>();
            if (_empleados.Any())
            {
                foreach (var e in _empleados)
                {
                    if (e.Nombre == nombre)
                    {
                        empleados.Add(e);
                    }
                }
            }
            return empleados;
        }
    }
}
