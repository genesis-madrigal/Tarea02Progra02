using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Desarrolle un algoritmo que calcule el promedio final para un estudiante del curso de Programación 1. Deberá leer los siguientes datos para
cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3. El programa deberá calcular
el porcentaje de quices (25%), porcentaje de tareas (30%), y el porcentaje de exámenes (45%). El algoritmo tiene que calcular el promedio final
y reportar el carnet, nombre, porcentaje de quices, porcentaje de tareas, porcentaje de exámenes, promedio final y condición del estudiante.
La condición del estudiante esta con base a: Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50
y menor que 70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”. 9. 
*/

namespace PromediosProgramacion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenido a su Calculadora de Promedios para Programacion 1");
            
            //Captura de datos

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite su carnet: ");
            Console.ForegroundColor = ConsoleColor.White;
            string CarnetEstudiante = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite su nombre completo: ");
            Console.ForegroundColor = ConsoleColor.White;
            string NombreEstudiante = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su primer quiz: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaQuiz1 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su segundo quiz: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaQuiz2 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su tercer quiz: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaQuiz3 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su primer tarea: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaTarea1 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su segunda tarea: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaTarea2 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su tercera tarea: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaTarea3 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su primer examen: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaExamen1 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su segundo examen: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaExamen2 = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nDigite la nota de su tercer examen: ");
            Console.ForegroundColor = ConsoleColor.White;
            float NotaExamen3 = float.Parse(Console.ReadLine());

            //Proceso

            float PorcentajeQuices = (NotaQuiz1 + NotaQuiz2 + NotaQuiz3) * 25 / 300;

            float PorcentajeTareas = (NotaTarea1 + NotaTarea2 + NotaTarea3) * 30 / 300;

            float PorcentajeExamenes = (NotaExamen1 + NotaExamen2 + NotaExamen3) * 45 / 300;

            float PromedioFinal = PorcentajeExamenes + PorcentajeQuices + PorcentajeTareas;

            //Salida de datos

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" \nCarnet del estudiante: {CarnetEstudiante}.");
            Console.WriteLine($" \nNombre del estudiante: {NombreEstudiante}.");
            Console.WriteLine($" \nPorcentaje de quizes obtenido: {PorcentajeQuices}.");
            Console.WriteLine($" \nPorcentaje de tareas obtenido: {PorcentajeTareas}.");
            Console.WriteLine($" \nPorcentaje de exámenes obtenido: {PorcentajeExamenes}."); 
            Console.WriteLine($" \nEl promedio final del estudiante es: {PromedioFinal}.");

            if (PromedioFinal >= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" \nLa condición del estudiante es: Aprobado");
            }

            else if (PromedioFinal >= 50 && PromedioFinal < 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" \nLa condición del estudiante es: Aplazado");
            }

            else if (PromedioFinal < 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(" \nLa condición del estudiante es: Reprobado");
            }

            Console.ReadLine();

        }
    }
}
