﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double pi = 3.14159;

        string[] entrada = Console.ReadLine().Split(' ');
        double A = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double B = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double C = double.Parse(entrada[2], CultureInfo.InvariantCulture);

        double triangulo = (A * C) / 2;
        double circulo = pi * Math.Pow(C, 2);
        double trapezio = (A + B) * C / 2;
        double quadrado = Math.Pow(B, 2);
        double retangulo = A * B;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

}