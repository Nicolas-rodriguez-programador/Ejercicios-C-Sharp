using System;
//4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float facturado, salario;
            float salarioFijo = 15000;
            float comision = 0.05F;
            
            Console.WriteLine("Inserte el monto facturado por el empleado: ");
            facturado = float.Parse(Console.ReadLine());
            
            //Esto se puede optimizar:
            //salario = 15000 + ( (facturado * 5) / 100 );
            //Asi:
            salario = salarioFijo + facturado * comision;
            //Al 0,05 le añado el F para que el compilador entienda que es un float y no un double.
            Console.WriteLine("Usted, habiendo facturado: $" + facturado + ", con un sueldo fijo de: $" + salarioFijo + " y una comisión del " + comision + " %, cobrará este mes: $" + salario + ".");
            
        }
    }
}
