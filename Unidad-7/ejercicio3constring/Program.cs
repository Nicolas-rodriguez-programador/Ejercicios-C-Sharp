using System;

namespace ejercicio3constring
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una STRING y dos caracteres sueltos (tres ingresos). 
            // Se deberan modificar las letras. 
            //Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
        
            string frase;
            char[] vectorLetras = new char[2];

            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a modificar: ");
            vectorLetras[0] = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra que modifica: ");
            vectorLetras[1] = char.Parse(Console.ReadLine());

            frase = frase.Replace(vectorLetras[0], vectorLetras[1]);
            Console.WriteLine("La frase quedó: '"+ frase +"'.");
        }
    }
}
