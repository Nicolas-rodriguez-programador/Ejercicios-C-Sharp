using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma 
            //decreciente .
            int num1, num2, num3, num4;
            Console.WriteLine("Vamos a pedirle 3 numeros. Luego veremos si la suma del primero con el segundo es mayor al producto del segundo con el tercero.");
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el cuarto número: ");
            num4 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3 && num1 > num4){
                if (num2 > num3 && num2 > num4){
                    if (num3 > num4)
                        Console.WriteLine("Están ordenados en forma decreciente.");
                    else
                        Console.WriteLine("No están ordenados en forma decreciente.");
                }else
                    Console.WriteLine("No están ordenados en forma decreciente.");
            }else
                Console.WriteLine("No están ordenados en forma decreciente.");
        }
    }
}
