﻿using System;

class URI
{
    static void Main(string[] args)
    {

        int X = int.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());

        double total = X / Y;

        Console.WriteLine(total.ToString("F3") + " km/l");

    }

}