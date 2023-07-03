using System.Globalization;

namespace ConsoleApp18;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangulo x, y;
        y = new Triangulo();
        x = new Triangulo();

        Console.WriteLine("Entre com as medidas do triângulo X: ");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com as medidas do triângulo Y: ");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var areaX = x.Area();
        var areaY = y.Area();

        Console.WriteLine("Area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Area de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

        if (areaX > areaY)
            Console.WriteLine("Maior area: X");
        else
            Console.WriteLine("Maior area: Y");
    }
}