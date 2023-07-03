namespace ConsoleApp12;

internal class IfeElse
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com um número inteiro: ");
        var x = int.Parse(Console.ReadLine());

        if (x % 2 == 0)
            Console.WriteLine("Par");
        else
            Console.WriteLine("Impar");
    }
}