using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            float importe, litrosVendidos;
            //Pido valores
            Console.Write("Ingrese el importe de la compra: ");
            importe = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de litros vendidos: ");
            litrosVendidos = float.Parse(Console.ReadLine());
            //Evaluo que descuento corresponde
            if (litrosVendidos > 500){
                Console.WriteLine("Corresponde un descuento del 25%.");
                importe *= 0.75F;
            }else if (litrosVendidos > 300){
                Console.WriteLine("Corresponde un descuento del 15%.");
                importe *= 0.85F;
            }else if (litrosVendidos > 100){
                Console.WriteLine("Corresponde un descuento del 10%.");
                importe *= 0.9F;
            }else
                Console.WriteLine("No hay descuento");
            //Muestro el importe a pagar
            Console.WriteLine("El importe total a pagar es $: "+ importe +".");
        }
    }
}
