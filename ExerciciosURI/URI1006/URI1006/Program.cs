using System;

class URI
{

    static void Main(string[] args)
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());

        double pesoA = 2;
        double pesoB = 3;
        double pesoC = 5;

        double MEDIA = (A * pesoA + B * pesoB + C * pesoC) / (pesoA + pesoB + pesoC);

        Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));


    }

}