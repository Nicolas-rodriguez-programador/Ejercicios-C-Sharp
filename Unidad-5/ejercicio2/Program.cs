using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor 
            //por pantalla.
            int mayor = -1;
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el "+ (i+1) +" número: ");
                int numero = int.Parse(Console.ReadLine());
                if ( mayor < numero ){
                    mayor = numero;
                }
            }
            Console.WriteLine("El mayor de los números ingresados es: "+ mayor +".");
        }
    }
}
