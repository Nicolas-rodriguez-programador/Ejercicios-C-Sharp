using System;

namespace whileprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador = 0;
            Console.Write("Ingrese un numero: ");
            i = int.Parse(Console.ReadLine());
            while (i != 0){
                contador ++;
                Console.Write("Ingrese un numero: ");
                i = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingresaste "+ contador + " números.");
        }
    }
}
