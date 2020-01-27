using System;

namespace desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese el valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de x: ");
            double x = double.Parse(Console.ReadLine());

            double d = dGrados * (Math.PI / 180.0);


            double g = Math.Cos(d) * w;
            double y = g - x;



            Console.WriteLine("el valor de y es : " + y);
        }
    }
}
