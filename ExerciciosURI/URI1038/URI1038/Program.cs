using System;

class URI
{

    static void Main(string[] args)
    {
        double result = 0;

        string[] entrada = Console.ReadLine().Split(' ');

        int op = int.Parse(entrada[0]);
        int quant = int.Parse(entrada[1]);

        switch(op)
        {
            case 1:
                result = 4.00 * quant;
                Console.WriteLine("Total: R$ " + result.ToString("F2"));
                break;
            case 2:
                result = 4.50 * quant;
                Console.WriteLine("Total: R$ " + result.ToString("F2"));
                break;
            case 3:
                result = 5.00 * quant;
                Console.WriteLine("Total: R$ " + result.ToString("F2"));
                break;
            case 4:
                result = 2.00 * quant;
                Console.WriteLine("Total: R$ " + result.ToString("F2"));
                break;
            case 5:
                result = 1.50 * quant;
                Console.WriteLine("Total: R$ " + result.ToString("F2"));
                break;
            default:
                Console.WriteLine("Valor Invalido!");
                break;
        }
    }
}