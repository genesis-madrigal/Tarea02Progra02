using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Un vendedor ofrece su producto de la siguiente manera: Si le compran 10 productos o menos, el precio por producto es de $20. 
Si le compran más de 10 artículos, el precio es de $15 por artículo. Realice un algoritmo y diagrama de flujo que con solo proporcionarle
la cantidad de artículos dé como resultado el precio y el total.
*/


namespace TiendaVendedor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Bienvenido a la Distrubuidora de Productos");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDigite la cantidad de productos que desea adquirir: ");
            int CantidadProductos = int.Parse(Console.ReadLine());

            if (CantidadProductos <= 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int PrecioxProducto = 20;
                int PrecioaPagar = PrecioxProducto * CantidadProductos;
                Console.WriteLine($"El precio a pagar por la cantidad de productos seleccionada es: {PrecioaPagar}.");
            }
            else if (CantidadProductos > 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                int PrecioxProducto = 15;
                int PrecioaPagar = PrecioxProducto * CantidadProductos;
                Console.WriteLine($"\nEl precio a pagar por la cantidad de productos seleccionada es{PrecioaPagar}.");
            }


            Console.ReadLine();

        }
    }
}
