using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.
            // Informar el promedio teniendo en cuenta sólo los números primos.
            int numero, promedioPrimos, acumuladorPrimos = 0, contadorPrimos = 0;
            
            Console.WriteLine("Vamos a ingresar números. El ingreso corta con un '0'.");
            Console.WriteLine("Al finalizar se mostrará el promedio total teniendo en cuenta sólo los números primos ingresados.");
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());
            while ( numero != 0)
            {
                if ( esPrimo(numero) == 1){
                    cargaDePrimos(ref acumuladorPrimos, ref contadorPrimos, numero);
                }
                Console.Write("Ingrese otro número: ");
                numero = int.Parse(Console.ReadLine());    
            }
            if (acumuladorPrimos != 0 && contadorPrimos != 0){
                promedioPrimos = calculoPromedioPrimos( acumuladorPrimos, contadorPrimos);
                Console.WriteLine("El promedio, teniendo en cuenta sólo los números primos es: "+ promedioPrimos +".");
            }else
                Console.WriteLine("No existieron números primos en la carga y usted finalizó la carga.");
            Console.WriteLine("Fin del programa.");
        }
        static int esPrimo( int a ){
            int contador = 0, i = a;
            
            while( ( contador<2 ) && ( i>0 ) ){        
                if ( ( a % i ) == 0 ){            
                    contador++;
                }
                i--;
            }
            if ((i == 0) && (contador == 2))
                return 1;
            else
                return 0;
        }
        static void cargaDePrimos(ref int a, ref int b, int numero){
            a += numero;
            b ++;
        }
        static int calculoPromedioPrimos(int acumuladorPrimos, int contadorPrimos){
            int promedio =  acumuladorPrimos * contadorPrimos;
            return promedio;
        }
    }
}
