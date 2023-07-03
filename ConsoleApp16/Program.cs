namespace ConsoleApp16;

internal class For
{
    private static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros você vai digitar?");
        var n = int.Parse(Console.ReadLine());

        var soma = 0;

        for (var i = 1; i <= n; i++)
        {
            Console.Write("Valor: #{0}: ", i);
            var valor = int.Parse(Console.ReadLine());
            soma += valor;
        }

        Console.WriteLine("Soma = " + soma);
    }
}