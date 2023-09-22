using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*hacer un algoritmo de una tienda que vende camisas, si la persona  se lleva una camisa se lo lleva a precio de costo, 
si la persona se lleva entre 2 y 5 camisas se le hace un descuento del 15%
si la persona se lleva mas de 5 el descuento es de 20%
El sistema debe solictar la cantidad de camisas y el precio de las camisas*/

namespace Tarea2Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Digite la cantidad de camisas: ");
            Console.ForegroundColor = ConsoleColor.White;
            int cantidadcamisas = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Digite el precio por unidad de las camisas por favor: ");
            Console.ForegroundColor = ConsoleColor.White;
            float precioxcamisa = float.Parse(Console.ReadLine());

            if (cantidadcamisas == 1)
            {
                float montofinal = precioxcamisa * cantidadcamisas;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" \n El monto a pagar por las camisas es de {montofinal}.");
            }
            else if (cantidadcamisas > 1 && cantidadcamisas <= 5)
            {
                precioxcamisa = precioxcamisa * 0.85f;
                float montofinal = precioxcamisa * cantidadcamisas;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" \n El monto a pagar por las camisas es de {montofinal} luego de aplicar un descuento del 15%.");
                
            }    
            else if (cantidadcamisas > 5)
            {
                precioxcamisa = precioxcamisa * 0.80f;
                float montofinal = precioxcamisa * cantidadcamisas;

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($" \n El monto a pagar por las camisas es de {montofinal} luego de aplicar un descuento del 20%. ");
                
            }

            Console.ReadLine();

        }
    }
}
