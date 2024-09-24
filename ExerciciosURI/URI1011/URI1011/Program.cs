using System;

class URI
{

    static void Main(string[] args)
    {

        double pi = 3.14159;
        double raio = double.Parse(Console.ReadLine());

        double Volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = " + Volume.ToString("F3"));

    }

}