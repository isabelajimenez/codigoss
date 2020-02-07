using System;

namespace politica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ingrese el numero de votos por el partido a : ");
          double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el numero de votos por el partido b : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el numero de votos en blanco : ");
            double blancos = double.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el numero de votos anulados : ");
            double anulados = double.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el numero de la poblacion : ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(" ingrese el porcentaje de los mayores de edad : ");
            double p = double.Parse(Console.ReadLine());

            double dife;
            
                if (a > b) dife=  a - b;
             else dife= b - a;
          
            double votostotales = a + b + blancos + anulados;

            bool totalvotos = n < votostotales ;
            bool diferencia = dife < votostotales * 0.10;
            bool votantes = votostotales < n * 0.03;
          

            if ((totalvotos || diferencia) && votantes)
            {
                Console.WriteLine(" realice de nuevo las elecciones");

                
            }
            else
            {
                
                if (a < b )  Console.WriteLine(" el partido ganador es el b");
                
                else  Console.WriteLine("el partido ganador es el a");
               


            }
            


        }
    }
}
