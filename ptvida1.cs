using System;

namespace desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos

            Console.WriteLine("hola, por favor ingrese el valor de b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine(" Ahora porfavor ingrese el valor de z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine(" Para finalizar ingrese el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            //conversion de los angulos a radianes

            double b = bGrados * (Math.PI / 180.0);

            //Calculo de los valores

            
            
            double a = Math.Atan(y / z);
            double f = a + b;
            
            double g = z * Math.Tan(f);
            double x = g - y;

            Console.WriteLine(" El valor de x es: " + x);
        }
    }
}
