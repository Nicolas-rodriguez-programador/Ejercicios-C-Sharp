﻿using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.
            int num;
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());
            if (num == 0){
                Console.WriteLine("Cero.");
            }else if (num < 0){
                Console.WriteLine("Negativo.");
            }else{
                Console.WriteLine("Positivo.");
            }
        }
    }
}
