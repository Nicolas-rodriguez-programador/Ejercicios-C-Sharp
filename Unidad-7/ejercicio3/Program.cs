using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una 
            //cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 
            //Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadenaDeCaracteres = new char[50];
            char a, b;
            int i = 0;

            Console.WriteLine("Cargar frase (letra por letra): ");

            //cargo la cadena de caracteres
            Console.Write("Ingrese letra: ");
            a = char.Parse(Console.ReadLine());
            while ( a != '.' && i < 49){
                cadenaDeCaracteres[i] = a;
                i++;
                Console.Write("Ingrese letra: ");
                a = char.Parse(Console.ReadLine());
            }
            //Finalizo con '\0' el vector
            cadenaDeCaracteres[i]= '\0';
            //..........
            //Cargo a y b
            Console.Write("Ingrese letra A: ");
            a = char.Parse(Console.ReadLine());
            Console.Write("Ingrese letra B: ");
            b = char.Parse(Console.ReadLine());
            //Inicializo el indice nuevamente
            i = 0;
            while( cadenaDeCaracteres[i] != '\0' ){
                if (cadenaDeCaracteres[i] == a){
                    cadenaDeCaracteres[i] = b;
                    Console.Write(cadenaDeCaracteres[i]);
                }else
                    Console.Write(cadenaDeCaracteres[i]);
                i++;
            }
            Console.WriteLine("");
            Console.WriteLine("Fin del programa.");
        }
    }
}
