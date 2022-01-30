using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //paso 0: declarar variables con tipo de dato: int, float, char, string, bool, etc
            int numero1, numero2, resultado;

            //paso 1: pedir valores
            Console.WriteLine("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());            //Int.Parse lo que hace es que el ReadLine solo lea numero enteros

            Console.WriteLine("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            //paso 2: realizar calculo
            resultado = numero1 + numero2;

            //paso 3: imprimir resultado
            Console.WriteLine("La sumatoria es: " + resultado);
        }
    }
}
