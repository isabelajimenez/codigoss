using System;

namespace tareaproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese su tipo de contrato, 1 para independiente y 2 para dependiente: ");
            double contrato = double.Parse(Console.ReadLine());

            double smmlv = 877803;
            double ARL = 0, EPS = 0, pension = 0, prima = 0, salariofinal = 0, salarioanual = 0;
            double cotizacion = 0.4 * salario;
         
            if (cotizacion < smmlv) cotizacion = smmlv;     
            switch (contrato)
            {
                case 1:
                    Console.WriteLine(" por favor ingrese el nivel de su riesgo laboral: ");
                    double riesgo = double.Parse(Console.ReadLine());
                     pension = 0.16 * cotizacion ;
                     EPS = 0.125 * cotizacion ;
                    salariofinal = salario - pension - EPS - ARL;
                    salarioanual = salariofinal * 12;
                    switch (riesgo)
                    {
                     case 1:
                            ARL = ( cotizacion * 0.522) / 100;                         
                            Console.WriteLine("su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                            break;
                        case 2:
                            ARL = (cotizacion * 1.044) / 100;
                            
                            Console.WriteLine("su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                            break;
                        case 3:
                             ARL = (cotizacion * 2.436) / 100;                           
                            Console.WriteLine("su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                            break;
                        case 4:
                             ARL = (cotizacion * 4.350) / 100;                           
                            Console.WriteLine("su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                            break;
                        default:
                             ARL = (cotizacion * 6.960) / 100;                          
                            Console.WriteLine("su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                            break;
                    }
                    break;
                case 2 :
                     EPS = (cotizacion * 4) / 100;
                     pension = (cotizacion * 4) / 100;
                    prima = salario;
                    salariofinal = salario - pension - EPS - ARL;
                    salarioanual = (salariofinal * 12) + prima;
                    Console.WriteLine(" su salario mensual seria: " + salariofinal + " y su salario anual seria: " + salarioanual);
                    break;
            }          
        }
    }
}
  
        
    

