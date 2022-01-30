using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números 
            //impares.
            //Declaro
            int longitud = 8, mayorPar = -2147483648, minimoImpar = 2147483647;
            bool primerPar = false, primerImpar = false;
            //Lo resuelvo con un FOR
            for (int i = 0; i < longitud; i++)
            {
                Console.Write("Ingrese el "+( i+1 )+" numero: ");
                int numero = int.Parse(Console.ReadLine());
                if ( (numero % 2) == 0)
                {
                    if (primerPar == false){
                        primerPar = true;
                        mayorPar = numero;
                    }else{
                        if(numero > mayorPar)
                            mayorPar = numero;
                    }
                }else{
                    if (primerImpar == false){
                        primerImpar = true;
                        minimoImpar = numero;
                    }else{ 
                        if (numero < minimoImpar)
                        minimoImpar = numero;
                    }
                }
            }
            Console.WriteLine("El mayor de los pares ingresados fue "+ mayorPar +" y el menor de los impares fue "+ minimoImpar + ".");
        }
    }
}
