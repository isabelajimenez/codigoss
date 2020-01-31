using System;

namespace desafiosalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola, por favor ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            double smmlv = 877803;

            
            if ( salario < smmlv*2)
            {
                Console.WriteLine("Usted es tarifa A, disfrute de sus beneficios");
            }
            else if (smmlv*2 <= salario && salario < smmlv*4)
            {
                Console.WriteLine("Usted es tarifa B, sobreviva");
            }
            else
            {
                Console.WriteLine("usted es tarifa C, comparta");
            }
        }
    }
}
