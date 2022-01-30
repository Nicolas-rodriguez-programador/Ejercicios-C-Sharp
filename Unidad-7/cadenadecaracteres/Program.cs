using System;

namespace cadenadecaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // La cadena de caracteres se diferencia a un string y a los vectores de caracteres.
            //Los tres son diferentes conceptualmente...
            //La string, si bien se compone de una cadena de caracteres o un vector de caracteres, es un tipo de dato particular,
            //El vector de caracteres es una "coleccion" si se quiere, de chars y
            //La cadena de caracteres es un vector que puede formar una palabra, frase o cadena de caracteres especifica.
            //
            //Las cadenas de caracteres se cortan con el comando BARRA CERO ' \0 '
            //
            //Cadena de caracteres
            //H|O|L|A| |M|U|N|D|O|!| |\0|
            //Se manipula con el \0 lo que significa que puedo no mostrarlos si asi lo deseo
            //
            //Vector de caracteres
            //C|D|E| | | |F| |G| | |
            //No posee final, por lo tanto se termina mostrando todo si o si
            //
            //String
            // "Hola Mundo!"

            //Cargar mi nombre con una Cadena de Caracteres

            char[] caracteresParaElNombre = new char [13];
            char[] caracteresParaElApellido = new char [13];
            char letra;
            int i;
            Console.WriteLine("En este programa vas a tener que escribir tu nombre y tu apellido.");
            Console.WriteLine("Cuando termines de ingresar el nombre coloca un '.'.");
            Console.WriteLine("Lo mismo para el apellido.");
            
            //NOMBRE
            i = 0;
            Console.Write("Escribe la letra "+ (i+1) +" de tu nombre: ");
            letra= char.Parse(Console.ReadLine());
            if (letra != '.' && i<12){
                while ( letra != '.' && i<12){
                    caracteresParaElNombre[i] = letra;
                    i++;
                    Console.Write("Escribe la letra "+ (i+1) +" de tu nombre: ");
                    letra = char.Parse(Console.ReadLine());
                }
                if(letra == '.'){
                    if ( i < 12)
                        caracteresParaElNombre[i+1]= '\0';
                    else
                        caracteresParaElNombre[i]= '\0';
                }
                //APELLIDO
                i = 0;
                Console.Write("Escribe la letra "+ (i+1) +" de tu apellido: ");
                letra= char.Parse(Console.ReadLine());
                if( letra != '.' && i<12){
                    while ( letra != '.' && i<12){
                        caracteresParaElApellido[i] = letra;
                        i++;
                        Console.Write("Escribe la letra "+ (i+1) +" de tu nombre: ");
                        letra = char.Parse(Console.ReadLine());
                    }
                }
                    if(letra == '.'){
                        if(i < 12)
                            caracteresParaElApellido[i+1]= '\0';
                        else
                            caracteresParaElApellido[i]= '\0';
                    }
                //MUESTRO
                Console.Write("Tu nombre completo es: ");
                i = 0;
                while(caracteresParaElNombre[i] != '\0' ){
                    Console.Write(caracteresParaElNombre[i]);
                    i++;
                }
                    Console.Write(" ");
                i = 0;
                while(caracteresParaElApellido[i] != '\0' ){
                    Console.Write(caracteresParaElApellido[i]);
                    i++;
                }
                Console.Write(".");
            }else
                Console.WriteLine("Finalizó el programa.");

        }
    }
}
