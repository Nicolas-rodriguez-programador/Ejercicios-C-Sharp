using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para 
            //ingresar 20 números y mostrar por pantalla cuántos son pares.    
            
            Console.Write("Escriba un número entero: ");
            int n = int.Parse(Console.ReadLine());

            if ( par(n) == 1 )
                Console.WriteLine(n +" es par.");
            else
                Console.WriteLine(n +" es impar.");
        }
        //Funcion para calcular pares
        static int par ( int a ){
            if ( (a % 2) == 0 )
                return 1;
            else
                return 0;
        }
    }
}
