using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
            //Declaro
            int num1, num2, num3, num4;
            int comparacion = 100;
            //Pido los valores
            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número:");
            num4 = int.Parse(Console.ReadLine());
            //Cuales son mayores a 100
            if (num1 > comparacion){
                if (num2 > comparacion){
                    if (num3 > comparacion){
                        if (num4 > comparacion){
                            Console.WriteLine("Num1 ("+ num1 +"), Num2 ("+ num2 +"), Num3 ("+ num3 +") y Num4 ("+ num4 +"), todos son mayores a "+ comparacion +".");
                        }else
                            Console.WriteLine("Num1 ("+ num1 +"), Num2 ("+ num2 +") y Num3 ("+ num3 +") son mayores a "+ comparacion +".");
                    }else if (num4 > comparacion){
                        Console.WriteLine("Num1 ("+ num1 +"), Num2 ("+ num2 +") y Num4 ("+ num4 +"), todos son mayores a "+ comparacion +".");
                    }else
                        Console.WriteLine("Num1 ("+ num1 +") y Num2 ("+ num2 +") son mayores a "+ comparacion +".");
                }else if (num3 > comparacion){
                    if (num4 > comparacion){
                        Console.WriteLine("Num1 ("+ num1 +"), Num3 ("+ num3 +") y Num4 ("+ num4 +"), son mayores a "+ comparacion +".");
                    }else
                        Console.WriteLine("Num1 ("+ num1 +") y Num3 ("+ num3 +"), son mayores a "+ comparacion +".");
                }else if (num4 > comparacion){
                    Console.WriteLine("Num1 ("+ num1 +") y Num4 ("+ num4 +"), son mayores a "+ comparacion +".");
                }else
                    Console.WriteLine("Solo Num1 ("+ num1 +") es mayor a "+ comparacion +"."); 
            }else if (num2 > comparacion){
                if (num3 > comparacion){
                    if (num4 > comparacion){
                        Console.WriteLine("Num2 ("+ num2 +"), Num3 ("+ num3 +") y Num4 ("+ num4 +"), son mayores a "+ comparacion +".");
                    }else
                        Console.WriteLine("Num2 ("+ num2 +") y Num3 ("+ num3 +") son mayores a "+ comparacion +".");
                }else if (num4 > comparacion){
                    Console.WriteLine("Num2 ("+ num2 +") y Num4 ("+ num4 +"), son mayores a "+ comparacion +".");
                }else
                    Console.WriteLine("Solo Num2 ("+ num2 +") es mayor a "+ comparacion +".");
            }else if (num3 > comparacion){
                if (num4 > comparacion){
                    Console.WriteLine("Num3("+ num3 +") y Num4 ("+ num4 +") ,son mayores a "+ comparacion +".");
                }else
                    Console.WriteLine("Solo Num3 ("+ num3 +") es mayor a "+ comparacion +".");
            }else if (num4 > comparacion){
                Console.WriteLine("Solo Num4 ("+ num4 +") es mayor a "+ comparacion +".");
            }else
                Console.WriteLine("Ninguno es mayor a "+ comparacion +".");
        }
    }             
}
