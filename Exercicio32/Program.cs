//Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros números inteiros positivos
//ímpares a partir do número informado pelo usuário menor que 1O e maior que zero.

namespace Exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalSoma = 0;
            Console.Clear();

            Console.Write("Digite um número entre 1 e 9: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (numero > 0 && numero < 10) {
                for (int contador = numero; contador < 40 + numero; contador++) {
                    if (contador % 2 != 0) {
                        totalSoma = totalSoma + contador * contador;
                    }
                }
            } else {
                Console.WriteLine("O número digitado não está entre 1 e 10!");
            }

            Console.WriteLine($"A soma dos quadrados dos 20 primeiros números ímpares é: {totalSoma}");
        }
    }
}