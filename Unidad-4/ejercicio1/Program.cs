using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            //
            //Declaro
            float num1, num2;
            //Pido valores para num1 y num2
            Console.Write("Ingrese num1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese num2: ");
            num2 = float.Parse(Console.ReadLine());
            //Evaluo condicionales
            if (num1 > num2){
                Console.WriteLine("Se realizó una resta.");
                num1 -= num2;
            }else if (num1 == num2){
                Console.WriteLine("Se realizó una suma.");
                num1 += num2;
            }else{
                Console.WriteLine("Se realizó una multiplicación.");
                num1 = num1 * num2;
            }
            Console.Write("El resultado es: "+ num1);
        }
    }
}
