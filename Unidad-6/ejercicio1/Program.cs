using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            // ingresar 10 num con FOR
            // mostrar cuantos son primos
            int cantidadPrimos = 0;
            for (int i = 0; i < 10; i++)
            {
                int contador = 0;
                //Pido el numero a analizar
                Console.Write("Ingrese un número: "+ (i+1) +": ");
                int numero = int.Parse(Console.ReadLine());

                for (int x = 1; x <= numero; x++)
                {
                    if( (numero % x) == 0)
                        contador++;
                }
                if (contador == 2)
                    cantidadPrimos++;
            }
            Console.WriteLine("La cantidad de números primos es: "+ cantidadPrimos+".");
        }
    }
}
