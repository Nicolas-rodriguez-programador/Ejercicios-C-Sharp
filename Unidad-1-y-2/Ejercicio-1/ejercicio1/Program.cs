using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;

            Console.WriteLine("Inserte a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte b: ");
            b = int.Parse(Console.ReadLine());
            r = a + b;
            Console.WriteLine("La suma es: "+ r);
        }
    }
}
