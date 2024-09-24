using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        int NumFuncionario = int.Parse(Console.ReadLine());
        int Horas = int.Parse(Console.ReadLine());
        double ValorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double Salario = Horas * ValorHora;

        Console.WriteLine("NUMBER = " + NumFuncionario);
        Console.WriteLine("SALARY = U$ " + Salario.ToString("F2", CultureInfo.InvariantCulture));

    }

}