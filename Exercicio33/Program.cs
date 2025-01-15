//Escreva um programa que calcule e exiba a média da nota dos alunos de uma turma em uma prova. O número de
//alunos é desconhecido. Os dados de um aluno são: número de matrícula e a sua nota na prova em questão.

namespace Exercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            float notas, medias = 0;

            Console.Clear();

            Console.Write("Por favor, informe quantas notas de alunos serão digitadas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Clear();

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Write("Digite o número da matrícula do aluno: ");
                Console.ReadLine();

                Console.Write("Por favor, digite a nota do aluno: ");
                notas = float.Parse(Console.ReadLine()!);
                Console.WriteLine("");

                medias += notas;
            }

            medias = medias / quantidade;

            Console.WriteLine($"A média da prova dos alunos é: {medias:n1}");
        }
    }
}