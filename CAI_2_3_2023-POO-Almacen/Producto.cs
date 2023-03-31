using System;
using System.Collections.Generic;

namespace CAI_2_3_2023_POO_Almacen
{
    public class Producto
    {
        public string _nombreProducto { get; set; }
        public int _cantidadProducto { get; set; }
        private string _descProducto { get; set; }
        public Producto() { }

        public List<Producto> productos = new List<Producto>();

        public static object CargarProducto()
        {
            Producto nuevoProducto = new Producto();
            while(true)
            {
                Console.Clear();
                int opcMenu = Validacion.OpcionMenu("Menu de Carga de Productos \n------------------- \n1- Cargar Nuevo Producto \n0- Volver al Menu Principal ",0,1);
                switch(opcMenu)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        nuevoProducto.DatosProductos();
                        nuevoProducto.RegistrarProducto(nuevoProducto);
                        continue;
                }
                break;
            }

            return nuevoProducto;
        }

        private void DatosProductos()
        {
            Console.Clear();
            int prod = Validacion.OpcionMenu("Seleccione el producto a cargar: \n1- Arvejas \n2- Lentejas \n3- Garbanzos \n4- Fideos", 1, 4);
            switch (prod)
            {
                case 1: _nombreProducto = "Arvejas";
                    break;
                case 2: _nombreProducto = "Lentejas";
                    break;
                case 3: _nombreProducto = "Garbanzos";
                    break;
                case 4: _nombreProducto = "Fideos";
                    break;
            }
            Console.Clear();
            _cantidadProducto = Validacion.ValidarInt("Ingrese la cantidad del producto:");
            Console.Clear();
            _descProducto = Validacion.ValidarString("Ingrese una descripción del producto:");
        }
        private void RegistrarProducto(Producto nuevoProducto)
        {
            Console.Clear();
            productos.Add(nuevoProducto);
            Console.WriteLine($"Producto cargado con éxito! \n------------------------------ \nDetalle: \nProducto: {_nombreProducto} \nCantidad: {_cantidadProducto} \nDescripción: {_descProducto} \nPresione cualquier tecla para continuar.");
            Console.ReadKey();
        }
    }
}