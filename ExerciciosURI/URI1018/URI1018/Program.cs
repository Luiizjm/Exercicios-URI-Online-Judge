using System;

class URI
{

    static void Main(string[] args)
    {

        int nota1, nota2, nota5, nota10, nota20, nota50, nota100;

        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);

        nota100 = N / 100;
        N %= 100;

        nota50 = N / 50;
        N %= 50;

        nota20 = N / 20;
        N %= 20;

        nota10 = N / 10;
        N %= 10;

        nota5 = N / 5;
        N %= 5;

        nota2 = N / 2;
        N %= 2;

        nota1 = N;

        Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
        Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
        Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
        Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
        Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
        Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
        Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
    }

}