namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        bool completo = false;
        byte n1 = 254;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648;
        char letra = '\u032b';
        float n5 = 4.5f;
        string nome = "Gabriel";
        object obj1 = "Manu";

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