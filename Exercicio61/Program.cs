//Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve
//receber o valor do salário e o índice de reajuste.

using System.Globalization;

namespace Exercicio61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite o salário do colaborador R$: ");
            decimal salario = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            decimal salarioNovo = Reajuste(salario, 0.075m);

            Console.WriteLine($"O salário com o reajuste atual (2025) de 7,5% é de: {salarioNovo.ToString("C", CultureInfo.CreateSpecificCulture("pt-Br"))}");
        }

        static decimal Reajuste(decimal salario, decimal indice)
        {
            decimal diferenca = salario * indice;

            decimal novoSalario = salario + diferenca;

            return novoSalario;
        }
    }
}