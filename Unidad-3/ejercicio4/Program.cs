using System;

namespace ejercicio4
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
                        //Si todos son distintos empieza la busqueda del menor
                        if (num1 < num2){
                            if (num1 < num3){
                                if (num1 < num4){
                                    menor = num1;
                                    Console.WriteLine("Num1 es el menor: " + menor + ".");
                                }else{
                                    menor = num4;
                                    Console.WriteLine("Num4 es el menor: " + menor + ".");
                                }
                            }else if (num3 < num4){
                                menor = num3;
                                Console.WriteLine("Num3 es el menor: " + menor + ".");
                                }
                            else{
                                menor = num4;
                                Console.WriteLine("Num4 es el menor: " + menor + ".");
                            }
                        }else if (num2 < num3){
                            if (num2 < num4){
                                menor = num2;
                                Console.WriteLine("Num2 es el menor: " + menor + ".");
                            }
                            else{ 
                                menor = num4;
                                Console.WriteLine("Num4 es el menor: " + menor + ".");
                            }
                        }else if (num3 < num4){
                            menor = num3;
                            Console.WriteLine("Num3 es el menor: " + menor + ".");
                            }
                        else{
                            menor = num4;
                            Console.WriteLine("Num4 es el menor: " + menor + ".");
                        } 
                    }
                }
            }
        }    
    }
}
