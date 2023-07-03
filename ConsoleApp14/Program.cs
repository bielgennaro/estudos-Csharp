namespace ConsoleApp14;

internal class MaiorQue
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite três números: ");
        var n1 = int.Parse(Console.ReadLine());
        var n2 = int.Parse(Console.ReadLine());
        var n3 = int.Parse(Console.ReadLine());

        double resultado = Maior(n1, n2, n3);


        Console.WriteLine("Maior = " + resultado);
    }

    private static int Maior(int a, int b, int c)
    {
        int m;

        if (a > b && a > c)
            m = a;
        else if (b > c)
            m = b;
        else
            m = c;

        return m;
    }
}