using System;

namespace ejercicio4pormaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            //Declaro
            int num1, num2, num3, num4, menor;
            //Pido los valores asegurandome que sean distintos
            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2){
                Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
            }else{
                Console.WriteLine("Ingrese el tercer número:");
                num3 = int.Parse(Console.ReadLine());
                if (num3 == num1)
                    Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
                else if (num3 == num2)
                    Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
                else{
                    Console.WriteLine("Ingrese el cuarto número:");
                    num4 = int.Parse(Console.ReadLine());
                    if (num4 == num1)
                        Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
                    else if (num4 == num2)
                        Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
                    else if (num4 == num3)
                        Console.WriteLine("Ha ingresado dos números iguales. No se puede continuar.");
                    else{
                        //CALCULAR MENORES O MAYORES
                        if (num1 < num2)
                            menor = num1;
                        else
                            menor = num2;
                        if (num3 < menor)
                            menor = num3;
                        if (num4 < menor)
                            menor = num4;
                        Console.WriteLine("El número más pequeño es el "+ menor+ ".");
                    }
                }
            }
        }
    }
}