using System;
//2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, resultado;

            Console.WriteLine("Inserte un número para elevarlo al cuadrado: ");
            numero = double.Parse(Console.ReadLine());

            resultado = Math.Pow(numero, 3);

            Console.WriteLine(resultado + " es el resultado de elevar " + numero + " al cuadrado.");

        }
    }
}
