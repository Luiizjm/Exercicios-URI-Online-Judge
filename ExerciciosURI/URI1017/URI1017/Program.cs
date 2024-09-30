using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int tempo, velocidade;
        double litros = 12;

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());

        litros = (double) (velocidade / litros) * tempo;

        Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
    }

}