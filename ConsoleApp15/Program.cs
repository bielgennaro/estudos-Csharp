using System.Globalization;

namespace ConsoleApp15;

internal class While
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        var x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while (x >= 0.0)
        {
            var raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("Você digitou um número inválido!");
    }
}