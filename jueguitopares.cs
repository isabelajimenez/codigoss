using System;

namespace unodetantos
{
    class Program
    {
        static void Main(string[] args)
    {
         Random aleatorio = new Random();
           string continuar = "s", continuar3 = "c";
           int i = 0;
           double dado = 0, total = 0;
           bool condicion10 = false;
          while (i <= 2 && continuar3 == "c")
          {
               dado = int.Parse(Console.ReadLine());
               // dado = aleatorio.Next(1, 13);
                total += dado;
                Console.WriteLine("este fue su dado: " + dado);
                Console.WriteLine("este es su puntaje: " + total);
                Console.WriteLine("desea continuar? (c/n): ");
                continuar3 = Console.ReadLine();
                i++;
          }
            continuar = "s";

            while (continuar == "s")
           {              
              dado = int.Parse(Console.ReadLine());
             // dado = aleatorio.Next(1, 13);
              total += dado;
              Console.WriteLine("este fue su dado: " + dado);
              Console.WriteLine("este es su puntaje: " + total);

                if (dado % 2 == 0)
                {                    
                  if (total >= 100) Console.WriteLine("Usted ha ganado");                       
                  if ( dado == 12) condicion10 = true; 
                   else if (( dado == 10) && (condicion10 == true))
                   {
                        Console.WriteLine("Usted ha ganado");
                        continuar = "n";
                   }                                                                          
                  else
                    {
                        Console.WriteLine("desea continuar? (s/n): ");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Usted ha perdido");
                    continuar = "n";
                }     
           }
        }
    }
}
