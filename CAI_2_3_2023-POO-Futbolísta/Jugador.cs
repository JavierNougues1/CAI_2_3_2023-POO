using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Futbolísta
{
    internal class Jugador
    {
        private int _DNI { get; set; }
        private string _nombreJugador { get; set; }
        private DateTime _fechaNacimientoJugador { get; set; }
        private string _clubJugador { get; set; }
        private int _salarioJugador {get; set; }

        List<Jugador> jugadores = new List<Jugador>();
        public Jugador() { }
        public Jugador(string linea)
        {
            var datos = linea.Split('|');
            _DNI = int.Parse(datos[0]);
            _nombreJugador = datos[1];
            _fechaNacimientoJugador = DateTime.Parse(datos[2]);
            _clubJugador = datos[3];
            _salarioJugador = int.Parse(datos[4]);
        }

        public static Jugador AgregarJugador()
        {
            Jugador nuevoJugador = new Jugador();
            Console.Clear();
            int opcMenu = Validacion.OpcionMenu("1- Agregar jugador.\n2- Volver al menú principal. \n0- Salir", 1, 2);
            switch (opcMenu)
            {
                case 1:
                    Console.Clear();
                    nuevoJugador.PedirDatosJugador();
                    if (!nuevoJugador.ValidarJugadorNoExista())
                    {
                        nuevoJugador.RegistrarNuevoJugador(nuevoJugador);
                        nuevoJugador.MostrarJugadorRegistrado();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Ya existe un jugador registrado bajo el DNI: {nuevoJugador._DNI}.");
                        Console.WriteLine("Presione una tecla para continuar.");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            return nuevoJugador;
        }

        private void PedirDatosJugador()
        {
            Console.Clear();
            Console.WriteLine("Registro de Jugadores");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            _DNI = Validacion.PedirInt("Ingrese el DNI del jugador que desea registrar:");
            _nombreJugador = Validacion.PedirString("Ingrese el nombre del jugador que desea registrar:");
            _fechaNacimientoJugador = DateTime.Parse( Validacion.PedirString("Ingrese la fecha de nacimiento del jugador que desea resgistrar:"));
            _clubJugador = Validacion.PedirString("Ingrese el club del jugador que desea registrar:");
            _salarioJugador = Validacion.PedirInt("Ingrese el salario del jugador que desea registrar:");     
        }   

        private bool ValidarJugadorNoExista()
        {
            bool existe = false;
            foreach (var jugador in jugadores)
            {
                if (jugador._DNI == _DNI)
                {
                    existe = true;
                }
            }
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i]._DNI == _DNI)
                {
                    existe = true;
                }
            }
            return existe;
        }

        private void RegistrarNuevoJugador(Jugador nuevoJugador)
        {
            jugadores.Add(nuevoJugador);
        }


        private void MostrarJugadorRegistrado()
        {
            Console.Clear();
            Console.WriteLine($"El jugador con el siguiente detalle se ha agregado satisfactoriamente: \n" +
                $"DNI: {_DNI} \n" + 
                $"Nombre: {_nombreJugador}\n" +
                $"Fecha de nacimiento: {_fechaNacimientoJugador} \n" +
                $"Club: {_clubJugador} \n" +
                $"Salario: ${_salarioJugador}\n"  +
                $"-------------------------------------------------------------------------------------------\n" + 
                $"Presione una tecla para continuar.");
            Console.ReadKey();
        }

        public static Jugador BuscarJugador()
        {
            Jugador buscarJugador = new Jugador();
            Console.Clear();
            int opcMenu = Validacion.OpcionMenu("1- Buscar jugador.\n2- Volver al menú principal.", 1, 2);
            switch (opcMenu)
            {
                case 1:
                    Console.Clear();
                    int dni = Validacion.PedirInt("Por favor, ingrese el DNI del jugador que desea buscar:");
                    for (int i = 0; i < buscarJugador.jugadores.Count; i++)
                    {
                        if (buscarJugador.jugadores[i]._DNI == dni)
                        {
                            Console.Clear();
                            Console.WriteLine($"El jugador con el siguiente detalle se ha encontrado: \n" +
                            $"DNI: {buscarJugador.jugadores[i]._DNI} \n" +
                            $"Nombre: {buscarJugador.jugadores[i]._nombreJugador}\n" +
                            $"Fecha de nacimiento: {buscarJugador.jugadores[i]._fechaNacimientoJugador} \n" +
                            $"Club: {buscarJugador.jugadores[i]._clubJugador} \n" +
                            $"Salario: {buscarJugador.jugadores[i]._salarioJugador}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"No existe un jugador con el DNI: {dni}.");
                        }
                    }
                    if (buscarJugador.jugadores.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"No hay jugadores registrados, por lo que no existe un jugador con el DNI: {dni}.");
                    }
                    break;
                case 2:
                    break;
                default:
                    break;
            }
            return buscarJugador;
        }
        public static Jugador DesplegarJugador()
        {
            Jugador desplegarJugador = new Jugador();
            foreach (var jugador in desplegarJugador.jugadores)
            {
                Console.Clear();
                Console.WriteLine("Lista de jugadores registrados:");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write($"DNI: {jugador._DNI} Nombre: {jugador._nombreJugador} Fecha de Nacimiento: {jugador._fechaNacimientoJugador} Club: {jugador._clubJugador} Salario: ${jugador._salarioJugador}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
            if (desplegarJugador.jugadores.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("No hay jugadores registrados.");
            }
            return desplegarJugador;
        }
    }
}
