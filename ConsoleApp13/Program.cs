namespace ConsoleApp13;

internal class Escopos
{
    private static void Main(string[] args)
    {
        var preco = double.Parse(Console.ReadLine());
        var desconto = 0.0;

        if (preco > 100.0) desconto = preco * 0.1;

        Console.WriteLine(desconto);
    }
}