using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaVersionProfe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            int cantidad = 0;
            int opcion = 0;

            do
            {

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                Console.WriteLine("4. Salir");
                Console.WriteLine("*****************");
                Console.WriteLine("Digite su opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1();  break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Console.WriteLine("Gracias");
                        
                        
                        break;

                    default: 
                        Console.Clear();
                        Console.WriteLine("Opcion digitada es incorrecta");
                        Console.ReadLine();
                        break;
                }

            } while (opcion!=4);

            Console.ReadLine();
        }

        //metodos, ac[a encapsulo c[odigo y puedo llamar al metodo
        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1 - Camisas");
            int cantidad = 0;
            float precio = 0;

            Console.WriteLine("Digite la cantidad"); cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite lel precio"); precio = float.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");
            }

            if (cantidad >= 2 && cantidad <= 5)
            {
                Console.WriteLine($"El precio de las camisas es de {(cantidad * precio) * 0.85f} con descuento de 15%");
            }

            if (cantidad > 5)
            {
                Console.WriteLine($"El precio de las camisas es de {(cantidad * precio) * 0.80f} con descuento de 20%");
            }

            Console.ReadLine();
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2 - Estudiantes");

            int cantidad;
            bool flag = true;

            while (flag)
            {

                Console.WriteLine("Digite la cantidad de estudiantes por ingresar: ");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 0)
                {
                    string[] carnetEstudiante = new string[cantidad];
                    string[] nombreEstudiante = new string[cantidad];
                    double[] porcentajeQuizes = new double[cantidad];
                    double[] porcentajeTareas = new double[cantidad];
                    double[] porcentajeExamenes = new double[cantidad];
                    double[] promedioFinal = new double[cantidad];

                    Console.WriteLine($"La cantidad de estudiantes a ingresar es de {cantidad}");

                    double quiz1;
                    double quiz2;
                    double quiz3;
                    double tarea1;
                    double tarea2;
                    double tarea3;
                    double examen1;
                    double examen2;
                    double examen3;

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Clear(); //limpia la pantalla
                        Console.Write("Digite el carnet del estudiante: ");
                        carnetEstudiante[i] = Console.ReadLine();

                        Console.Write("Digite el nombre del estudiante: ");
                        nombreEstudiante[i] = Console.ReadLine();

                        //quizes

                        Console.Write("Digite la nota del primer quiz: ");
                        quiz1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota del segundo quiz: ");
                        quiz2 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota del tercer quiz: ");
                        quiz3 = double.Parse(Console.ReadLine());

                        porcentajeQuizes[i] = (quiz1 + quiz2 + quiz3) * 25 / 300;

                        //tareas

                        Console.Write("Digite la nota de la primera tarea: ");
                        tarea1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota de la segunda tarea: ");
                        tarea2 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota de la tercera tarea: ");
                        tarea3 = double.Parse(Console.ReadLine());

                        porcentajeTareas[i] = (tarea1 + tarea2 + tarea3) * 30 / 300;

                        //examenes

                        Console.Write("Digite la nota del primer quiz: ");
                        examen1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota del segundo quiz: ");
                        examen2 = double.Parse(Console.ReadLine());

                        Console.Write("Digite la nota del tercer quiz: ");
                        examen3 = double.Parse(Console.ReadLine());

                        porcentajeExamenes[i] = (examen1 + examen2 + examen3) * 45 / 300;

                        promedioFinal[i] = (porcentajeExamenes[i] + porcentajeQuizes[i] + porcentajeTareas[i]);

                        Console.WriteLine($" \nCarnet del estudiante: {carnetEstudiante[i]}.");
                        Console.WriteLine($" \nNombre del estudiante: {nombreEstudiante[i]}.");
                        Console.WriteLine($" \nPorcentaje de quizes obtenido: {porcentajeQuizes[i]}.");
                        Console.WriteLine($" \nPorcentaje de tareas obtenido: {porcentajeTareas[i]}.");
                        Console.WriteLine($" \nPorcentaje de exámenes obtenido: {porcentajeExamenes[i]}.");
                        Console.WriteLine($" \nEl promedio final del estudiante es: {promedioFinal[i]}.");

                        Console.ReadLine();

                        
                    }

                    flag = false;
                    Console.Clear();

                } else 
                {
                    Console.WriteLine("La cantidad de estudiantes debe ser mayor a 0. Intente de nuevo.");
                }

            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3 - Vendedor");
        }

     
    }
}
