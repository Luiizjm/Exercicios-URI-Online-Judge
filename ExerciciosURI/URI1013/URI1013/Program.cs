using System;

class URI
{

    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int A = int.Parse(entrada[0]);
        int B = int.Parse(entrada[1]);
        int S = int.Parse(entrada[2]);

        int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
        int Maior = (MaiorAB + S + Math.Abs(MaiorAB - S)) / 2;

        Console.WriteLine(Maior + " eh o maior");
    }

}