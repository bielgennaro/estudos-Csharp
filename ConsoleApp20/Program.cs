using System.Globalization;

namespace ConsoleApp20;

internal class Program
{
    private static void Main(string[] args)
    {
        var p = new Produto();

        Console.WriteLine("Entre os dados do produto: ");
        Console.Write("Nome:");
        p.Nome = Console.ReadLine();

        Console.WriteLine("Digite o preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados do produto: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
        var qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);

        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removidos do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProduto(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
    }
}