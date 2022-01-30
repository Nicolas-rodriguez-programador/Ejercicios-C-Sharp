using System;

namespace switcha
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            char op;
            Console.Write("Inserte a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Inserte b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Inserte operador: ");
            op = char.Parse(Console.ReadLine());
            
            switch (op)
            {
                case '+':
                    Console.WriteLine("El resultado de " + a +" + "+ b +" = "+ (a+b));
                    break;
                case '-':
                    Console.WriteLine("El resultado de " + a +" - "+ b +" = "+ (a-b));
                    break;
                case '*':
                    Console.WriteLine("El resultado de " + a +" * "+ b +" = "+ (a*b));
                    break;
                case '/':
                    Console.WriteLine("El resultado de " + a +" / "+ b +" = "+ (a/b));
                    break;
                default:
                    Console.WriteLine("No existe tal operador.");
                    break;
            }
        }
    }
}
