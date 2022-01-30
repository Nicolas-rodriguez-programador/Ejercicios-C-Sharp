using System;

namespace andyor
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPERADORADORES BOOLEANOS
            int a;
            int b = 4; 
            int c = 10;
            Console.Write("Ingrese el primer número: ");
            a = int.Parse(Console.ReadLine());
            //OPERADOR AND &&
            if (a != b){
                if ((a > b) && (a > c)){
                    Console.WriteLine("El número insertado: "+ a +" es mayor que "+ b +" y que "+ c +".");
                }else{
                    Console.WriteLine("El número insertado: "+ a + " no cumple con alguno de los requisitos anteriores.");
                }
                //OPERADOR OR ||
                if ((a > b) || (a > c)){
                    Console.WriteLine("El número insertado: "+ a +" es mayor que "+ b +" o que "+ c +".");
                }else{
                    Console.WriteLine("El número insertado: "+ a + " no cumple con alguno de los requisitos anteriores.");
                }
            }else
                if (a > c)
                    Console.WriteLine("Los dos son mayores que "+ c +".");
                else
                    Console.WriteLine("Los dos son menores que "+ c +".");
        }
    }
}
