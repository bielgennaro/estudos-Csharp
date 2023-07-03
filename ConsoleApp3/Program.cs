using System.Globalization;

namespace ConsoleApp3;

internal class SaidaDeDados
{
    private static void Main(string[] args)
    {
        var nome = "Gabriel";
        var idade = 20;
        var saldo = 10.35784;

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //placeholder
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //interpolação
        Console.WriteLine(nome + "tem" + idade + "anos" + "e tem saldo igual a" +
                          saldo.ToString("F2", CultureInfo.InvariantCulture) + "reais"); //concatenação;
    }
}