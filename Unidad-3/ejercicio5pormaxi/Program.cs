using System;

namespace ejercicio5pormaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            //Declaro
            int num1, num2, num3, num4;
            int comparacion = 100;
            int con = 0;
            //Pido los valores
            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            num4 = int.Parse(Console.ReadLine());
            //El lo que hizo es evaluar todo independientemente.
            if (num1 > comparacion){
                Console.Write(num1 + " ");
                con ++;
            }
            if (num2 > comparacion){
                Console.Write(num2 + " ");
                con ++;
            }
            if (num3 > comparacion){
                Console.Write(num3 + " ");
                con ++;
            }
            if (num4 > comparacion){
                Console.Write(num4 + " ");
                con ++;
            }
            if (con != 0)
                Console.WriteLine(" son mayores a "+ comparacion +".");
            Console.WriteLine("Fin del programa.");
        }
    }
}
