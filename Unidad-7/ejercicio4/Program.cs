using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //- Número de Artículo (1 a 15)
            //- Cantidad Vendida 
            //
            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
            //int[] vectorArticulos = new int[15];
            int[] vectorAcumulador = new int[15];
            int cantidadVendida, articulo, mayor = -1, masVendido = -1;
            //cargo los articulos
            //for (int i = 0; i < 15; i++)
            //{
            //    vectorArticulos[i]= i+1;
            //}
            //cargo las ventas hasta que num articulo sea 0
            Console.Write("Ingrese el articulo vendido (1 al 15): ");
            articulo = int.Parse(Console.ReadLine());
            while ( articulo != 0 && articulo > 0 && articulo < 16){
                Console.Write("Ingrese la cantidad vendida: ");
                cantidadVendida = int.Parse(Console.ReadLine());
                vectorAcumulador[articulo-1] += cantidadVendida;
                //ingreso un nuevo articulo
                Console.Write("Ingrese el articulo vendido (1 al 15): ");
                articulo = int.Parse(Console.ReadLine());
            }
            //Calculo A
            for (int i = 0; i < 15; i++)
            {
                if ( vectorAcumulador[i] > mayor){
                    mayor = vectorAcumulador[i];
                    masVendido = i+1;
                }
            }
            Console.WriteLine("El articulo más vendido fue el "+ masVendido +".");
            //Calculo B
            for (int i = 0; i < 15; i++)
            {
                if ( vectorAcumulador[i] == 0 )
                    Console.WriteLine("El articulo "+ (i+1) +" no registra ventas.");
            }
            //Muestro C
            Console.WriteLine("La cantidad de articulos 10 que se vendieron es "+ vectorAcumulador[9] +".");
            //Fin
            Console.WriteLine("Fin del programa.");
        }
    }
}
