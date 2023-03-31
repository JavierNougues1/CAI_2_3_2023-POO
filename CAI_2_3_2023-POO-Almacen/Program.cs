using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Almacen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos al 'Sistema de Gestión de Almacenes'");
                int opcMenu = Validacion.OpcionMenu("Seleccione la acción que desea realizar: \n1- Visualizar stock \n2- Cargar producto \n3- Salir", 0, 3);
                switch (opcMenu)
                {
                    case 1:
                        var visualizarStock = Stock.VisualizarStock();
                        continue;
                    case 2:
                        var cargarProducto = Producto.CargarProducto();
                        continue;
                    case 3:
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
