using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1);
                if (i < 9)
                    Console.Write(", ");
            }
            Console.Write(".");
        }
    }
}
