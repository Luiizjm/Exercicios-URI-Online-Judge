﻿using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string Nome = Console.ReadLine();
        double SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double Vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Total = SalarioFixo + (Vendas * 0.15);

        Console.WriteLine("TOTAL = " + Total.ToString("F2"));

    }

}