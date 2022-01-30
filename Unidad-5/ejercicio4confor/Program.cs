using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: 
            //un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
            //
            //Declaro
            int contador = 0;
            //Pido el numero a analizar
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            //FOR
            for (int i = 1; i <= numero; i++)
            {
                if( (numero % i) == 0)
                    contador++;
            }
            if (contador == 2)
                Console.WriteLine("El número "+ numero +" es primo.");
            else
                Console.WriteLine("El numero "+ numero +" no es primo.");
        }
    }
}