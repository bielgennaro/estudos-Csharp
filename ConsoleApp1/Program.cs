namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        var completo = false;
        byte n1 = 254;
        var n2 = 1000;
        var n3 = 2147483647;
        long n4 = 2147483648;
        var letra = '\u032b';
        var n5 = 4.5f;
        var nome = "Gabriel";
        object obj1 = "Manu";
        var dec = decimal.MaxValue;

        Console.WriteLine(dec);
        Console.WriteLine(obj1);
        Console.WriteLine(nome);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(n3);
        Console.WriteLine(n4);
        Console.WriteLine(n5);
        Console.WriteLine(letra);
        Console.WriteLine(completo);
    }
}