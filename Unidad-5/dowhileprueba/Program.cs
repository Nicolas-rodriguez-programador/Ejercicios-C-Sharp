using System;

namespace dowhileprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, contador = 0;
            do {
                Console.Write("Ingrese un número: ");
                i = int.Parse(Console.ReadLine());
                if (i != 0)                                     //Tengo que poner este if porque sino el '0' me incrementa en uno al contador.
                    contador ++;
            } while (i != 0);
            Console.WriteLine("Ingresaste: "+ contador +" números.");    
        }
    }
}
