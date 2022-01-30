using System;
//5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.


namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota_1, nota_2, nota_3, promedio;

            Console.WriteLine("Inserte la primer nota: ");
            nota_1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la segunda nota: ");
            nota_2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Inserte la tercer nota: ");
            nota_3 = float.Parse(Console.ReadLine());

            promedio = (nota_1 + nota_2 + nota_3) / 3;
            Console.WriteLine("El promedio del alumno es de: " + promedio + "/10.");
        }
    }
}
