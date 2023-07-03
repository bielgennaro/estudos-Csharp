using System.Globalization;

namespace ConsoleApp19;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1, pessoa2, funcionario1, funcionario2;
        pessoa1 = new Pessoa();
        pessoa2 = new Pessoa();
        funcionario1 = new Pessoa();
        funcionario2 = new Pessoa();


        Console.WriteLine("Dados da primeira pessoa: ");
        Console.Write("Nome: ");
        pessoa1.nome = Console.ReadLine();
        Console.Write("Idade: ");
        pessoa1.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa: ");
        Console.Write("Nome: ");
        pessoa2.nome = Console.ReadLine();
        Console.Write("Idade: ");
        pessoa2.idade = int.Parse(Console.ReadLine());

        if (pessoa1.idade > pessoa2.idade)
            Console.WriteLine($"{pessoa1.nome} é mais velha", pessoa1.nome);
        else
            Console.WriteLine($"{pessoa2.nome} é mais velha", pessoa2.nome);

        Console.WriteLine("Dados do primeiro funcionário: ");
        Console.Write("Nome: ");
        funcionario1.nome = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Dados do segundo funcionário: ");
        Console.Write("Nome: ");
        funcionario2.nome = Console.ReadLine();
        Console.Write("Salário: ");
        funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var MediaSalario = new List<double> { funcionario1.salario, funcionario2.salario };
        var media = MediaSalario.Average();

        Console.WriteLine("Salário médio = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
    }
}