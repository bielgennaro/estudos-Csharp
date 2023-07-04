using System.Globalization;

namespace ConsoleApp22;

internal class Program
{
    private static double Pi = 3.14;

    private static void Main(string[] args)
    {
        Console.WriteLine("Entre o valor do raio: ");
        var raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var circ = Circunferencia(raio);
        var volume = Volume(raio);

        Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * Math.Pow(r, 3.0);
        }
    }
}