using System.Globalization;

namespace ConsoleApp2;

internal class SaidaDeDados
{
    private static void Main(string[] args)
    {
        var genero = 'M';
        var idade = 32;
        var nome = "Gabriel";
        var saldo = 10.35784;

        Console.WriteLine("Bom dia");
        Console.WriteLine("Boa tarde");
        Console.WriteLine("Boa noite");
        Console.WriteLine("--------------------");

        Console.WriteLine(genero);
        Console.WriteLine(idade);
        Console.WriteLine(nome);
        Console.WriteLine(saldo);
        Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
    }
}