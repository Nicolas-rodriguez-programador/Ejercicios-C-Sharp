using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio.
            //Mostrar por pantalla los valores que son mayores al promedio.

            int[] vectorNumeros = new int[10];
            int longitud = 10, acumulador = 0;
            float promedio;
            //Ingreso
            Console.WriteLine("Ingrese 10 números: ");
            for (int i = 0; i < longitud; i++)
            {
                Console.Write("Ingrese el número "+ i +" (dentro del vector): ");
                vectorNumeros[i] = int.Parse(Console.ReadLine());
            }
            //Acumulo (podria haberlo hecho todo junto pero la consigna me pedia eso)
            for (int i = 0; i < longitud; i++)
            {
                acumulador += vectorNumeros[i];
            }
            //Calculo el promedio
            promedio = acumulador / 10;
            Console.WriteLine("El promedio es: "+ promedio +".");
            //Imprimo los mayores al promedio
            for (int i = 0; i < longitud; i++)
            {
                if( vectorNumeros[i] > promedio)
                    Console.WriteLine("El valor "+ vectorNumeros[i]+ " es mayor al promedio ("+ promedio +").");
            }

        }
    }
}
