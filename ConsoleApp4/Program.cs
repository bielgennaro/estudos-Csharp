namespace ConsoleApp4;

internal class Exercicio
{
    private static void Main(string[] args)
    {
        var produto1 = "Computador";
        var produto2 = "Mesa de escritório";

        byte idade = 20;
        var codigo = 2020;
        var genero = 'M';

        var preco1 = 2100.0;
        var preco2 = 650.50;
        var medida = 53.234567;

        Console.WriteLine("Produtos:\n {0}, cujo preço é $ {1} \n {2}, cujo preço é $ {3}", produto1, preco1, produto2,
            preco2);
        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
    }
}