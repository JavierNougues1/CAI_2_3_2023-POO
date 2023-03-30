using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CAI_2_3_2023_POO_Almacen
{
    internal class Stock
    {
        private string _nombreProducto { get; set; }
        public static object VisualizarStock() 
        {
            
            Stock stock = new Stock();
            Console.Clear();
            int opcMenu = Validacion.OpcionMenu("Seleccione la acción a relizar: \n0- Volver al Menú Principal \n1- Ver Stock",0,1);
            switch (opcMenu)
            {
                case 0: break;
                case 1:
                    int opcMenu1 = Validacion.OpcionMenu("Seleccione el producto a visualizar. \n1- Arvejas \n2- Lentejas \n3- Garbanzos \n4- Fideos", 1, 4);
                    switch (opcMenu1)
                    {
                        case 1:
                            stock._nombreProducto = "Arvejas";
                            stock.VisualizarCantidad(stock._nombreProducto);
                            break;
                        case 2:
                            stock._nombreProducto = "Lentejas";
                            stock.VisualizarCantidad(stock._nombreProducto);
                            break;
                        case 3:
                            stock._nombreProducto = "Garbanzos";
                            stock.VisualizarCantidad(stock._nombreProducto);
                            break;
                        case 4:
                            stock._nombreProducto = "Fideos";
                            stock.VisualizarCantidad(stock._nombreProducto);
                            break;
                    }
                    break;
            }
            
            return stock;
        }
        private void VisualizarCantidad(string prod)
        { 
            Producto producto1 = new Producto();
            int cant = 0;
            foreach (var producto in producto1.productos)
            {
                if (producto._nombreProducto == prod)
                {
                    cant += producto._cantidadProducto;
                    Console.WriteLine($"Producto: {prod} -> Cantidad: {cant}. \n--------------------- \nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("No cuenta con productos registrados. \n--------------------- \nPresione una tecla para continuar.");
                    Console.ReadKey();
                }
            }
            if (producto1.productos.Count == 0)
            {
                Console.WriteLine("No cuenta con productos registrados. \n--------------------- \nPresione una tecla para continuar.");
                Console.ReadKey();
            }
        }
    }
}
