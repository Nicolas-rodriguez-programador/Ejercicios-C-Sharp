using System;

namespace forprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitud = 10;
            float notas = 0, promedio;

            for (int i = 0; i < longitud; i++)
            {
                Console.Write("Ingrese la nota "+ (i +1) +": ");
                float  numero = float.Parse(Console.ReadLine());
                if (numero >= 0 && numero <=10){
                    notas += numero;
                }else{
                    i = 10;
                    notas = -1;
                }
            }
            if (notas == -1){
                Console.WriteLine("Has ingresado una nota invalida.");
                Console.WriteLine("Finaliza la carga.");
            }else{
                promedio = notas / longitud;
                Console.WriteLine("El promedio de las notas es: "+ promedio +".");
            }
        }
    }
}
