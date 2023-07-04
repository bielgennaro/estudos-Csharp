using System.Globalization;

namespace ConsoleApp21;

public class Program
{
    private static void Main(string[] args)
    {
        var ret = new Retangulo();

        Console.WriteLine("Insira a largura e a altura do retângulo: ");
        ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("AREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("PERIMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.Write("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
    }
}