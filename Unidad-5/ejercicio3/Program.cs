using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            //ingreso 20 edades
            //Promedio de los mayores de 18 solamente.
            int promedio, contadorDeMayores = 0, acumuladorDeMayores = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese la edad del invitado "+ (i+1) +" : ");
                int edad = int.Parse(Console.ReadLine());
                if (edad > 18){
                    contadorDeMayores ++;
                    acumuladorDeMayores += edad;
                }
            }
            promedio = acumuladorDeMayores / contadorDeMayores;
            Console.WriteLine("Vinieron a la fiesta "+ contadorDeMayores+" mayores. El promedio de edad es "+ promedio +".");
        }
    }
}
