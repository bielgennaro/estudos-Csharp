namespace ConsoleApp7;

internal class OperadorAritmetico
{
    private static void Main(string[] args)
    {
        var n1 = 3 + 4 * 2;
        var n2 = (3 + 4) * 2;
        var n3 = 17 % 3;
        var n4 = (double)10 / 8;

        double a = 1.0, b = -3.0, c = -4.0;

        var delta = Math.Pow(b, 2.0) - 4.0 * a * c;

        var x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(delta);
        Console.WriteLine(x1);
    }
}