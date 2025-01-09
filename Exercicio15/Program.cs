/*Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota 
da recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
aluno.
*/

using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            PedirNotas();
            Console.ReadKey();
        }

        static void PedirNotas()
        {
            Console.Clear();

            float[] nota = new float[4];

            for(int n = 0; n < 4; n++)
            {
                Console.Write("Digite a " + (n + 1) + "° nota do aluno: ");
                nota[n] = float.Parse(Console.ReadLine()!);
                Console.WriteLine("");
            }

            float media = (nota[0] + nota[1] + nota[2] + nota[3]) / 4;

            if (media >= 7) {
                Console.WriteLine($"A média do aluno foi de: {media:n1}\nParabéns, ele(a) foi aprovado(a)!");
            } else {
                PedirRecuperacao(media);
            }
        }

        static void PedirRecuperacao(float primeiraMedia)
        {
            Console.Write($"A média do aluno foi de: {primeiraMedia:n1}\nPor favor, informe a nota da recuperação: ");
            float notaRecuperação = float.Parse(Console.ReadLine()!);

            float mediaRecuperação = (primeiraMedia + notaRecuperação) / 2;

            Console.Clear();

            if (mediaRecuperação >= 7) {
                Console.WriteLine($"A nova média do aluno foi de: {mediaRecuperação:n1}\nParabéns, ele(a) foi aprovado(a) pela recuperação!");
            } else {
                Console.WriteLine($"A nova média do aluno foi de: {mediaRecuperação:n1}\nInfelizmente a nota necessária para aprovação não foi alcançada!");
            }
        }
    }
}