using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se 
            //notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int numero, i, contadorDeListas = 0, contadorDeNumerosDeCadaLista = 0;
            Console.WriteLine("En este programa deberá ingresar listas de números.");
            Console.WriteLine("Las mismas sólo deberán estar compuestas de números positivos.");
            
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0 ){
                while (numero >= 0){
                    contadorDeListas++;
                    i = contadorDeListas;
                    while (numero > 0){
                        contadorDeNumerosDeCadaLista++;
                        Console.Write("Ingrese un número: ");
                        numero = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("La lista "+ i +" está compuesta por "+ contadorDeNumerosDeCadaLista +" números.");
                    contadorDeNumerosDeCadaLista = 0;
                    Console.Write("Ingrese un número: ");
                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ha ingresado un número negativo, lo que finaliza la carga de listas.");
            }else
                Console.WriteLine("Ha ingresado un número negativo en el inicio del programa. Fin del programa.");
        Console.WriteLine("Ha finalizado el programa.");
        }
    }
}
