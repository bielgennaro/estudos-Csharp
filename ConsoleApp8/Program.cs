namespace ConsoleApp8;

internal class EntradaDeDados
{
    private static void Main(string[] args)
    {
        var frase = Console.ReadLine();
        var x = Console.ReadLine();
        var y = Console.ReadLine();
        var z = Console.ReadLine();

        var vet = Console.ReadLine().Split(' ');
        var a = vet[0];
        var b = vet[1];
        var c = vet[2];

        Console.WriteLine("Você digitou: ");
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}