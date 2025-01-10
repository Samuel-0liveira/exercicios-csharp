/*Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor maior que zero para cada
variável (se o valor digitado não é válido, mostrar mensagem e ler novamente). Exibe o menor valor lido
multiplicado pelo maior e o maior valor dividido pelo menor
*/

using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            VerificacaoDeValores();
            Console.ReadKey();
        }

        static void VerificacaoDeValores()
        {
            Console.Clear();

            int[] valores = new int[3];
            
            for(int contador = 0; contador < 3; contador++)
            {
                Console.Write("Por favor digite o "+ (contador + 1) +"° número: ");
                valores[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (valores[contador] <= 0) {
                    Console.Write("Valor inválido, por favor, digite um número maior que 0!");
                    Console.ReadKey();
                    contador--;
                    Console.Clear();
                }
            }

            int maior, menor;
            maior = menor = 0;

            if (valores[0] >= valores[1] && valores[0] >= valores[2]) 
            {
                maior = valores[0];

                if (valores[1] < valores[2])
                {
                    menor = valores[1];
                } else {
                    menor = valores[2];
                }
            } else if (valores[1] >= valores[0] && valores[1] >= valores[2]) {

                maior = valores[1];

                if (valores[0] < valores[2])
                {
                    menor = valores[0];
                } else {
                    menor = valores[2];
                }
            } else if (valores[2] >= valores[0] && valores[2] >= valores[1]) {

                maior = valores[2];

                if (valores[0] < valores[1])
                {
                    menor = valores[0];
                } else {
                    menor = valores[1];
                }
            }

            int multiplicacao = menor * maior;
            int divisao = maior / menor;

            Console.WriteLine($"O menor valor digitado multiplicado pelo maior é: {multiplicacao}\nO maior valor digitado dividido pelo menor valor é: {divisao}");
        }
    }
}