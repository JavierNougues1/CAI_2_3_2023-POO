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

        public void AgregarJugador(Jugador nuevoJugador)
        {
            Console.Clear();
            int opcMenu = Validacion.OpcionMenu("1- Agregar jugador.\n2- Volver al menú principal.", 1, 2);
            switch (opcMenu)
            {
                case 1:
                    Console.Clear();
                    PedirDatosJugador(nuevoJugador);
                    if (!ValidarJugadorNoExista(nuevoJugador))
                    {
                        RegistrarNuevoJugador(nuevoJugador);
                        MostrarJugadorRegistrado(nuevoJugador);
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
        }

        private void PedirDatosJugador(Jugador nuevoJugador)
        {
            Console.Clear();
            Console.WriteLine("Registro de Jugadores");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
            nuevoJugador._DNI = Validacion.PedirInt("Ingrese el DNI del jugador que desea registrar:");
            nuevoJugador._nombreJugador = Validacion.PedirString("Ingrese el nombre del jugador que desea registrar:");
            nuevoJugador._fechaNacimientoJugador = DateTime.Parse( Validacion.PedirString("Ingrese la fecha de nacimiento del jugador que desea resgistrar:"));
            nuevoJugador._clubJugador = Validacion.PedirString("Ingrese el club del jugador que desea registrar:");
            nuevoJugador._salarioJugador = Validacion.PedirInt("Ingrese el salario del jugador que desea registrar:");     
        }

        private bool ValidarJugadorNoExista(Jugador nuevoJugador)
        {
            bool existe = false;
            foreach (var jugador in jugadores)
            {
                if (jugador._DNI == nuevoJugador._DNI)
                {
                    existe = true;
                }
            }
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i]._DNI == nuevoJugador._DNI)
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


        private void MostrarJugadorRegistrado(Jugador nuevoJugador)
        {
            Console.Clear();
            Console.WriteLine($"El jugador con el siguiente detalle se ha agregado satisfactoriamente: \n" +
                $"DNI: {nuevoJugador._DNI} \n" + 
                $"Nombre: {nuevoJugador._nombreJugador}\n" +
                $"Fecha de nacimiento: {nuevoJugador._fechaNacimientoJugador} \n" +
                $"Club: {nuevoJugador._clubJugador} \n" +
                $"Salario: ${nuevoJugador._salarioJugador}\n"  +
                $"-------------------------------------------------------------------------------------------\n" + 
                $"Presione una tecla para continuar.");
            Console.ReadKey();
        }

        public void BuscarJugador(Jugador buscarJugador)
        {
            Console.Clear();
            int opcMenu = Validacion.OpcionMenu("1- Buscar jugador.\n2- Volver al menú principal.", 1, 2);
            switch (opcMenu)
            {
                case 1:
                    Console.Clear();
                    int dni = Validacion.PedirInt("Por favor, ingrese el DNI del jugador que desea buscar:");
                    for (int i = 0; i < jugadores.Count; i++)
                    {
                        if (jugadores[i]._DNI == dni)
                        {
                            Console.Clear();
                            Console.WriteLine($"El jugador con el siguiente detalle se ha encontrado: \n" +
                            $"DNI: {jugadores[i]._DNI} \n" +
                            $"Nombre: {jugadores[i]._nombreJugador}\n" +
                            $"Fecha de nacimiento: {jugadores[i]._fechaNacimientoJugador} \n" +
                            $"Club: {jugadores[i]._clubJugador} \n" +
                            $"Salario: {jugadores[i]._salarioJugador}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"No existe un jugador con el DNI: {dni}.");
                        }
                    }
                    if (jugadores.Count == 0)
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
            
        }
    }
}
