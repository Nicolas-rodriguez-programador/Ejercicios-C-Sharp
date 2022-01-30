using System;
//3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float km, velocidad, horas, minutos, segundos;
            int hh, mm, ss;
            //
            //pido datos
            Console.WriteLine("Ingrese la distancia (expresada en Km): ");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad promedio de su vehiculo (expresada en Km/h): ");
            velocidad = float.Parse(Console.ReadLine());
            //
            //calculos
            horas = km / velocidad;
            minutos = (km / velocidad) * 60;
            segundos = ((km / velocidad) * 60) * 60;
            //
            //muestro resultados
            Console.WriteLine("El tiempo que tardará en llegar son unas " + horas +" horas.");
            Console.WriteLine("Expresado solo en minutos, son un total de " + minutos +".");
            Console.WriteLine("Y expresado sólo en segundos, son unos " + segundos +".");
            //
            //calculos para mostrar el formato hh:mm:ss
            hh = (int)horas;
            if ((horas - hh) != 0){
                minutos = (horas - hh) *60;
                mm = (int)minutos;
                if((minutos - mm)!=0){
                    segundos = (minutos - mm) *60;
                    ss =(int)segundos;
                }else{
                    ss = 00;
                }
            }else{
                mm = 00;
                ss = 00;
            }
            
            Console.WriteLine("El tiempo que tardará en recorrer "+ km +" kilómetros viajando a una velocidad promedio de " + velocidad + " Km/h, es: "+ hh + ":" + mm + ":" + ss + ".");
        }
    }
}
