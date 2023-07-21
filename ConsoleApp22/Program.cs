using System.Globalization;

namespace ConsoleApp22;

internal class Program
{
    private static void Main(string[] args)
    {
        var calc = new Calculadora();

        Console.WriteLine("Entre o valor do raio: ");
        var raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var circ = calc.Circunferencia(raio);
        var volume = calc.Volume(raio);

        Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
}