using System;

namespace pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, velocidad, horas, minutos, segundos;
            //intentare mostrar el formato hh:mm:ss
            int hh, mm, ss;
            
            Console.WriteLine("Ingrese la distancia (expresada en Km): ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio de su vehiculo (expresada en Km/h): ");
            velocidad = float.Parse(Console.ReadLine());
            
            //calculos pertinentes
            horas = km / velocidad;
            minutos = km % velocidad;
            segundos = minutos / 1;

            //Paso los numeros de flotante a enteros
            hh = (int)horas;
            mm = (int)minutos;
            ss = (int)segundos;

            Console.WriteLine("El tiempo que tardará en llegar son: "+ hh + ":" + mm + ":" + ss + ".");

        }
    }
}
