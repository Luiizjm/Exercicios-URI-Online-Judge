using System;

class URI
{

    static void Main(string[] args)
    {
        int idade_dias = int.Parse(Console.ReadLine());

        int anos = idade_dias / 365;
        int resto_anos = idade_dias % 365;
       
        int meses = resto_anos / 30;
        int resto_meses = resto_anos % 30;  

        int dias = resto_meses;

        Console.WriteLine(anos + " ano(s)");
        Console.WriteLine(meses + " mes(es");
        Console.WriteLine(dias + " dia(s)");
    }

}