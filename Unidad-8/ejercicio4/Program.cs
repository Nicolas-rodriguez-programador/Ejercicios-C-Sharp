using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y 
            //  una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            //  a. 1 si el número es positivo.
            //  b. -1 si el número es negativo.
            //  c. 0 si el número es cero.
            int numero, queEs=0;
            Console.Write("Ingresa un número: ");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(ref queEs, numero);
            
            switch (queEs)
            {
                case 1:
                    Console.WriteLine("El número "+ numero +" es positivo.");
                    break;
                case 0:
                    Console.WriteLine("El número "+ numero +" es cero.");
                    break;
                default:
                    Console.WriteLine("El número "+ numero +" es negativo.");
                    break;
            }
            Console.WriteLine("Fin del programa.");
        
        }//Fin programa principal
        static void positivoNegativoCero(ref int a, int b){
            if( b > 0)
                a = 1;
            else if( b < 0)
                a = -1;
            else
                a = 0;
        }
    }
}
