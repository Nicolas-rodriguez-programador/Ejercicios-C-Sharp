using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del 
            //segundo con el tercero.
            int num1, num2, num3;
            Console.WriteLine("Vamos a pedirle 3 numeros. Luego veremos si la suma del primero con el segundo es mayor al producto del segundo con el tercero.");
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if((num1 + num2) > (num2 * num3))
                Console.WriteLine("Si, es mayor.");
            else
                Console.WriteLine("No, no es mayor.");
        }
    }
}
