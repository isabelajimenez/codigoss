using System;

namespace primera_tarea
{
    class Program
    {
        
            static void Main(string[] args)
            {
                // ingreso de datos conocidos

                Console.WriteLine("Hola, por favor ingrese el valor de t: ");
                double t = double.Parse(Console.ReadLine());
                Console.WriteLine("Ahora, por favor ingrese el valor de a: ");
                double a = double.Parse(Console.ReadLine());

            // calculos necesarios

            double z = t * Math.Sin(a);

                // resultado final

                Console.WriteLine("Estos son tus resultados: En primer lugar el valor de z es : " + z + ",en segundo lugar el valor de y es : " + y + " y en tercer lugar el valor de c es : " + c);

            }
        
    }
}
