using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.
            
            float importe, importeFinal;
            Console.WriteLine("Ingrese el importe:");
            importe = float.Parse(Console.ReadLine());
            if (importe >= 5000){
                Console.WriteLine("Descuento del 18%.");
                importeFinal = importe;
                importe = importe * 0.18F;
                importeFinal -= importe;
                Console.WriteLine("El importe a pagar es $"+ importeFinal +".");
            }else if (importe >= 1000){
                Console.WriteLine("Descuento del 10%.");
                importeFinal = importe;
                importe = importe * 0.10F;
                importeFinal -= importe;
                Console.WriteLine("El importe a pagar es $"+ importeFinal +".");
            }
            else
                Console.WriteLine("No hay descuento. El monto a pagar es $"+ importe+".");
            
        }
    }
}
