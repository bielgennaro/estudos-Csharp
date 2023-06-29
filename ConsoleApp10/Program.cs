using System.Globalization;

namespace ConsoleApp10
{
    internal class Exercicio
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com um preço de produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura");
            string[] vet2 = Console.ReadLine().Split(' ');
            string nome2 = vet2[0];
            int idade = int.Parse(vet2[1]);
            double altura = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);
            Console.WriteLine("Você tem {0} quartos na sua casa", quarto);
            Console.WriteLine("O preço digitado foi: {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O seu último nome é? {0} e você tem {1} anos e {2} metros?", nome2, idade,
                altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}