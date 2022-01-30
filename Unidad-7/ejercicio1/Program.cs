using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] vectorNumeros = new int [10];
            int max = 0, posicionMax = 0;
            bool yaEstaInicializado = false;

            //Cargo números
            Console.WriteLine("Escriba 10 números: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el número "+ (i)+" (dentro del vector): ");
                vectorNumeros[i] = int.Parse(Console.ReadLine());
            }
            //Busco máximo y su posición
            for (int i = 0; i < 10; i++)
            {
                if (yaEstaInicializado == false){
                    yaEstaInicializado = true;
                    max = vectorNumeros[i];
                    posicionMax = i;
                }
                else{
                    if( vectorNumeros[i] > max ){
                        max = vectorNumeros[i];
                        posicionMax = i;
                    }
                }

            }
            //Imprimo por pantalla
            Console.WriteLine("El número máximo es "+ max +" y se encuentra en la posición "+ posicionMax +" del vector.");
        }
    }
}
