using System.Globalization;

namespace ConsoleApp20;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
    }

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string GetNome()
    {
        return Nome;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int _quantidade)
    {
        _quantidade += _quantidade;
    }

    public void RemoverProduto(int _quantidae)
    {
        Quantidade -= Quantidade;
    }

    public override string ToString()
    {
        return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade +
               " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}