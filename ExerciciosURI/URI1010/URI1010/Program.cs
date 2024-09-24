using System;
using System.Globalization;


class URI
{

    static void Main(string[] args)
    {

        string[] Peca1 = Console.ReadLine().Split(' ');
        int CodigoPeca1 = int.Parse(Peca1[0]);
        int QuantidadePeca1 = int.Parse(Peca1[1]);
        double ValorPeca1 = double.Parse(Peca1[2], CultureInfo.InvariantCulture);

        string[] Peca2 = Console.ReadLine().Split(' ');
        int CodigoPeca2 = int.Parse(Peca2[0]);
        int QuantidadePeca2 = int.Parse(Peca2[1]);
        double ValorPeca2 = double.Parse(Peca2[2], CultureInfo.InvariantCulture);

        double ValorTotal = ValorPeca1 * QuantidadePeca1 + ValorPeca2 * QuantidadePeca2;

        Console.WriteLine("VALOR A PAGAR: R$ " + ValorTotal.ToString("F2", CultureInfo.InvariantCulture));

    }

}