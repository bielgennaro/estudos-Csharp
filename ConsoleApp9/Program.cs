using System.Globalization;

namespace ConsoleApp9;

internal class LeituraDeDados
{
    private static void Main(string[] args)
    {
        var n1 = int.Parse(Console.ReadLine());
        var ch = char.Parse(Console.ReadLine());
        var n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var vet = Console.ReadLine().Split(' ');
        var nome = vet[0];
        var sexo = char.Parse(vet[1]);
        var idade = int.Parse(vet[2]);
        var altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        Console.WriteLine("Voce digitou: ");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
    }
}