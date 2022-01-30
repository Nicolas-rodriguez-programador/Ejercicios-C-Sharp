using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            //Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            int numero, actual;
            int numeroDeGrupo = 0;
            int contadorGruposOrdenados = 0;
            double MayorPorcentajeImpares = 0;
            bool banderaGrupos = false;

            for (int i = 1; i <= 5; i++)
            {
                int contadorImpares = 0, contadorIntegrantes = 0;
                double porcentaje;
                bool cumple = false, noCumple = false;

                Console.WriteLine("Se comenzará con la lista "+( i )+".");
                Console.Write("Ingresa un número: ");
                numero = int.Parse(Console.ReadLine());
                actual = numero;

                while ( numero != 0 )
                {
                    //Corroborando que actual sea mayor o igual al numero
                    if( actual >= numero)
                        cumple = true;
                    else{
                        cumple = false;
                        if (cumple == false)
                            noCumple = true;
                    }
                    //Sumando impares
                    if ( (numero / 2) != 0)
                        contadorImpares++;
                    //Contando los integrantes totales
                    contadorIntegrantes++;

                    actual = numero;
                    Console.Write("Ingresa un número: ");
                    numero = int.Parse(Console.ReadLine());
                }
                //Grupo ordenado. Sube si todos los numeros fueron de Mayor a Menor
                if (( contadorIntegrantes != 0 )&&( noCumple == false))
                        contadorGruposOrdenados++;
                //Calculo el mayor porcentaje de impares    
                if (banderaGrupos == false){
                    if (contadorIntegrantes > 0){    
                        banderaGrupos = true;
                        if (contadorImpares > 0)
                            porcentaje = (contadorImpares * 100) / contadorIntegrantes;
                        else
                            porcentaje = 0;
                        MayorPorcentajeImpares = porcentaje;
                        numeroDeGrupo = i;
                    }else{
                        banderaGrupos = true;
                        numeroDeGrupo = 0;
                    }
                }else{
                    if (contadorIntegrantes > 0 && contadorImpares != 0)
                            porcentaje = (contadorImpares * 100) / contadorIntegrantes;
                        else
                            porcentaje = 0;
                    if (porcentaje > MayorPorcentajeImpares ){
                        MayorPorcentajeImpares = porcentaje;
                        numeroDeGrupo = i;
                    }
                }
            }
            Console.WriteLine("La cantidad de grupos ordenados de Mayor a Menor es "+ contadorGruposOrdenados +".");
            if (numeroDeGrupo != 0)
                Console.WriteLine("El grupo con mayor porcentaje de números impares es el "+ numeroDeGrupo +".");
            else
                Console.WriteLine("No existe el grupo con mayor porcentaje de números impares, porque no tenian impares dentro o porque estaban vacios.");
            Console.WriteLine("El programa ha finalizado.");   
        }
    }
}
