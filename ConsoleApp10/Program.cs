using System.Globalization;

namespace ConsoleApp10;

internal class Exercicio
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo: ");
        var vet = Console.ReadLine().Split(' ');
        var nome = vet[0];

        Console.WriteLine("Quantos quartos tem na sua casa?");
        var quarto = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com um preço de produto");
        var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com seu último nome, idade e altura");
        var vet2 = Console.ReadLine().Split(' ');
        var nome2 = vet2[0];
        var idade = int.Parse(vet2[1]);
        var altura = double.Parse(vet2[2], CultureInfo.InvariantCulture);

        Console.WriteLine("---------------------------");
        Console.WriteLine("Seu nome é: ");
        Console.WriteLine(nome);
        Console.WriteLine("Você tem {0} quartos na sua casa", quarto);
        Console.WriteLine("O preço digitado foi: {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("O seu último nome é? {0} e você tem {1} anos e {2} metros?", nome2, idade,
            altura.ToString("F2", CultureInfo.InvariantCulture));
    }
}