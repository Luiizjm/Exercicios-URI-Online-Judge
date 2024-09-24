using System;

class URI
{

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double pesoA = 3.5;
        double pesoB = 7.5;

        double MEDIA = (A * pesoA + B * pesoB) / (pesoA + pesoB);

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F5"));

    }

}