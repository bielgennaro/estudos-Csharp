namespace ConsoleApp4;

internal class Exercicio
{
    private static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 20;
        int codigo = 2020;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:\n {0}, cujo preço é $ {1} \n {2}, cujo preço é $ {3}", produto1, preco1, produto2, preco2);
        Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
        Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
        Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
    }
}