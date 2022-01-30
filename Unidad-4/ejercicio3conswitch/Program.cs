using System;

namespace ejercicio3conswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            //
            // --------      i5 (1)	    i7 (2)	    i9 (3)
            //8 RAM (1)	    USD 800	    USD 900	    USD 1200
            //16 RAM (2)	USD 900	    USD 1000	USD 1400
            //32 RAM (3)	USD 1000	USD 1400	USD 2000
            //
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo 
            //cual tiene un costo  adicional de USD 300.
            //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para 
            //extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.
            //
            //Declaro
            int procesador, ram, disco;
            float precio;
            float unoUno = 800;
            float unoDos = 900;
            float unoTres = 1000;
            float dosUno = 900;
            float dosDos = 1000;
            float dosTres = 1400;
            float tresUno = 1200;
            float tresDos = 1400;
            float tresTres = 2000;
            float extra = 300;
            //
            //Pido datos, me aseguraré que no pongan números invalidos
            Console.WriteLine("Inserte uno de los tres números válidos para decirnos qué opción de procesador desea en su computadora.");
            Console.WriteLine("Recuerde que solo tiene tres opciones: (1) (2) y (3) para elegir. Si escribe otra opción no podremos continuar.");
            Console.Write("Inserte opción: ");
            procesador = int.Parse(Console.ReadLine());
            //
            //Pregunto si esta bien colocada la opcion 1, 2 o 3 sino corta
            if ((procesador == 1) || (procesador == 2) || (procesador == 3)){
                Console.WriteLine("Inserte uno de los tres números válidos para decirnos qué opción de memoria RAM desea en su computadora.");
                Console.WriteLine("Recuerde que solo tiene tres opciones: (1) (2) y (3) para elegir. Si escribe otra opción no podremos continuar.");
                Console.Write("Inserte opción: ");
                ram = int.Parse(Console.ReadLine());
                //
                //Pregunto si esta bien colocada la opcion 1, 2 o 3 sino corta
                if ((ram == 1) || (ram == 2) || (ram == 3)){
                    Console.Write("Ingrese '1' si desea extender su Disco Rigido o '0' si desea el Disco Rigido standard.");
                    Console.Write("Inserte opción: ");
                    disco = int.Parse(Console.ReadLine());
                    //
                    //Compruebo que no metan un numero que no es
                    if ((disco == 1) || (disco == 0)){
                        //
                        //Calculo costos
                        //
                        switch (procesador)
                        {
                            case 1:
                                switch (ram)
                                {
                                    case 1:
                                        precio = unoUno;
                                        break;
                                    case 2:
                                        precio = unoDos;
                                        break;
                                    default:
                                        precio = unoTres;
                                        break;
                                }
                                break;
                            case 2:
                                switch (ram)
                                {
                                    case 1:
                                        precio = dosUno;
                                        break;
                                    case 2:
                                        precio = dosDos;
                                        break;
                                    default:
                                        precio = dosTres;
                                        break;
                                }
                                break;
                            default:
                                switch (ram)
                                {
                                    case 1:
                                        precio = tresUno;
                                        break;
                                    case 2:
                                        precio = tresDos;
                                        break;
                                    default:
                                        precio = tresTres;
                                        break;
                                }
                            
                                break;
                        }
                        //Evaluo si hay o no modificacion en el disco
                        if (disco == 1){
                            precio += extra;
                            Console.WriteLine("El precio de su computadora es: $"+ precio +".");
                        }else
                            Console.WriteLine("El precio de su computadora es: $"+ precio +".");
                        //    
                    }else{
                        Console.WriteLine("Disponemos de la opción '"+ procesador +"' para su procesador y de la opción '"+ ram +"' para su memoria RAM, pero la opción '"+ disco +"' que insertó para mejorar su Disco Rígido no existe en nuestro stock.");
                        Console.WriteLine("Muchas gracias.");
                    }
                }else{
                    Console.WriteLine("Disponemos de la opción '"+ procesador +"' para su procesador, pero la opción '"+ ram +"' que usted ha ingresado para su memoria RAM no existe en nuestro stock.");
                    Console.WriteLine("Muchas gracias.");
                }
            }else{
                Console.WriteLine("La opción '"+ procesador +"' que usted ha ingresado para elegir su procesador no existe en nuestro stock.");
                Console.WriteLine("Muchas gracias.");
            }
        }
    }
}
