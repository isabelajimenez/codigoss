using System;

namespace desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese el valor de d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de y: ");
            double y = double.Parse(Console.ReadLine());

            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);
            double Ggrados = 180 - 90 - dGrados;
            double f = Ggrados * (Math.PI / 180);

       
            
            double a = f - b;
            double z = y / Math.Tan(a);




            Console.WriteLine("el valor de z es : " + z);
        }
    }
}
