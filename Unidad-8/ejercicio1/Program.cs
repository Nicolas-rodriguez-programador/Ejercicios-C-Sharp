using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa 
            // que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int precioArticulo = 0, cantVendida = 0;
            pedirDatos(ref precioArticulo, ref cantVendida);
            Console.WriteLine("El total a pagar es: $ "+ producto(precioArticulo, cantVendida));
        
        }
        static void pedirDatos(ref int a, ref int b){
            Console.Write("Ingrese el precio del articulo: $ ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad vendida: ");
            b = int.Parse(Console.ReadLine());
        }
        static int producto(int a, int b){
            int producto = a * b;
            return producto;
        }
    }
}
