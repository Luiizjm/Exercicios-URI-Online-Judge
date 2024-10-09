using System;

class URI
{

    static void Main(string[] args)
    {
        int horas, minutos, segundos;
        int resto_horas;

        int entrada_seg = int.Parse(Console.ReadLine());

        horas = entrada_seg / 3600;
        resto_horas = entrada_seg % 3600;

        minutos = resto_horas / 60;
        segundos = resto_horas % 60;

        Console.WriteLine(horas + ":" + minutos + ":" + segundos);
    }

}
