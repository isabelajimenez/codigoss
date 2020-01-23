using System;

namespace segunda_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // ingreso de datos conocidos

                Console.WriteLine("Hola, por favor ingrese el valor de t: ");
                double t = double.Parse(Console.ReadLine());
                Console.WriteLine("Ahora, por favor ingrese el valor de a: ");
                double aGrados = double.Parse(Console.ReadLine());

            
            // convertir a radianes

            double a = aGrados * (Math.PI / 180.0);
            // calculos necesarios

            
                double z = (Math.Cos(a)) * t;
                double y = (Math.Sin(a)) * t;
                double c = 180 - 90 - aGrados;
                    // resultado final

              Console.WriteLine("Estos son tus resultados: En primer lugar el valor de z es : " + z + ",en segundo lugar el valor de y es : " + y + " y en tercer lugar el valor de c es : " + c);

            

        }
    }
}
