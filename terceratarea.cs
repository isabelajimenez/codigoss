using System;

namespace tercer_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            // ingreso de datos conocidos

            Console.WriteLine("Hola, por favor ingrese el valor de c: ");
            double cGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, por favor ingrese el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            // convertir de grados a radianes

            double c = cGrados * (Math.PI / 180.0);

            //calculos

            double y = z / (Math.Tan(c));
            double t = z / (Math.Sin(c));
            double a = 180 - 90 - cGrados;

            Console.WriteLine(" el valor de y es : " + y + ", el valor de t es: " + t + "y el valor del angulo a es: " + a);


        }
    }
}
