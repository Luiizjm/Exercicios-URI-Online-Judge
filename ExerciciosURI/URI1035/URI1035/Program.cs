using System;

class URI
{

    static void Main(string[] args)
    {

        string[] n = Console.ReadLine().Split(' ');

        int A = int.Parse(n[0]);
        int B = int.Parse(n[1]);
        int C = int.Parse(n[2]);
        int D = int.Parse(n[3]);

        if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}