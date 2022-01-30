using System;

namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            int num;
            Console.WriteLine("Ingrese un número entero:");
            num = int.Parse(Console.ReadLine());
            if (num > 10){
                Console.WriteLine(num + " es mayor que 10.");
            }else{
                Console.WriteLine(num + " no es mayor que 10.");
            }
        }
    }
}
