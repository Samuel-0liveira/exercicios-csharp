/*Faça um programa para pagamento de comissão de vendedores de peças,levando-se em consideração que sua
comissão será de 5% do total da venda e que você tem os seguintes dados:
- Identificação do vendedor
- Código da peça
- Preço unitário da peça
- Quantidade vendida
*/

using System;
using System.Globalization;
using System.Reflection;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            InserirInformacoes();
            Console.ReadKey();
        }

        public static void InserirInformacoes()
        {
            Console.Clear();

            Console.Write("Digite o nome do vendedor para identificação: ");
            string nomeDoVendedor = Console.ReadLine()!;
            Console.WriteLine("");

            Console.Write("Informe o código da peça: ");
            int codigoPeca = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite o preço da peça por unidade: ");
            var valorPeca = double.Parse(Console.ReadLine()!);
            Console.WriteLine("");
             
            Console.Write("Por fim, informe a quantidade vendida: ");
            int quantidadeVendida = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            CalculoDeComissao(nomeDoVendedor, codigoPeca, valorPeca, quantidadeVendida);
        }

        public static void CalculoDeComissao(string nome, int codigo, double valor, int venda)
        {   
            Console.Clear();

            double valorTotalVenda = valor * venda;
        
            double comissao = valorTotalVenda  * 0.05;

            Console.WriteLine($"Nome do vendedor: {nome} \nCódigo da peça: {codigo} \nValor total de vendas da peça: {valorTotalVenda.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} \nValor da comissão: {comissao.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
        }
    }
}