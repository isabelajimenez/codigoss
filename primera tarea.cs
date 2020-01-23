using System;

namespace primera_tarea
{
    class Program
    {
       
    
        static void Main(string[] args)
        {
            // ingreso de datos conocidos

            Console.WriteLine("Hola, por favor ingrese el valor de y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, por favor ingrese el valor de z: ");
            double z = double.Parse(Console.ReadLine());

            // calculos necesarios
            double t = Math.Sqrt((z * z) + (y * y));
            double a = (Math.Atan(y/z))/ (Math.PI / 180.0);
            double c = 180 - 90 - a;

            // resultado final
            
            Console.WriteLine ("Estos son tus resultados: En primer lugar el valor de t es : " + t + ",en segundo lugar el valor del angulo a es : " + a + " y en tercer lugar el valor del angulo c es : " + c);

        }
    
    }
}
