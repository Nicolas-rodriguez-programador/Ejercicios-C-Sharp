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
            int contador, i;
            //Pido el numero a analizar
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            // i va a ser mi indice y va a ir decreciendo hasta llegar a 1.
            i = numero;
            contador = 0;
            //El contador lo que hace es registrar cuántos restos son iguales a 0. Si supera el 2, significa que el número analizado no es primo.
            while( ( contador<2 ) && ( i>0 ) ){         
                if ( ( numero % i ) == 0 ){             
                    contador++;
                }
                i--;
            }
            //Pregunto por ambas condiciones porque si yo saco el i==0 el contador va a quedar en '2' y mi i quizas no queda en 0... eso va a
            //provocar que todos los numeros sean entendidos como primos.
            if ((i == 0) && (contador == 2))
                Console.WriteLine("El número "+ numero +" es primo.");
            else
                Console.WriteLine("El numero "+ numero +" no es primo.");
        }
    }
}
