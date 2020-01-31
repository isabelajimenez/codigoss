using System;

namespace cuotamoneyonoseque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese su salario: ");
        double salario = double.Parse(Console.ReadLine());

            double smmlv = 877803;


            if (salario < smmlv * 2)
            {
                double cuota =  3400;
                Console.WriteLine("Usted es tarifa A, disfrute de sus beneficios, y su cuota moderadora es: "+ cuota);
            }
            else if (smmlv * 2 <= salario && salario < smmlv * 5)
            {
                double cuota = 13500;
                Console.WriteLine("Usted es tarifa B, sobreviva, y su cuota moderadora es: " + cuota);
            }
            else
            {
                double cuota = 35600;
                Console.WriteLine("usted es tarifa C, comparta, y su cuota moderadora es: " + cuota);
               
            }
        }
    }
    
}
