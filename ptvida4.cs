﻿using System;

namespace desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, por favor ingrese el valor de w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine(" por favor ingrese el valor de c: ");
            double cGrados = double.Parse(Console.ReadLine());

            double c = cGrados * (Math.PI / 180.0);

            double z = Math.Sin(c) * t;
            double y = Math.Cos(c) * t;
            double f = Math.Acos(z / w);
            double g = Math.Tan(f) * z;
            double x = g - y;



            Console.WriteLine("el valor de x es : " + x);
        }
    }
}
