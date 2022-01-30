using System;

namespace vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: "+ (i+1) +": ");
                numero[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("El numero "+ (i+1) +" es "+ numero[i] +".");
            }
        }
    }
}
