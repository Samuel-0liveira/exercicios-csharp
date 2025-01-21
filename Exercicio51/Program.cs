/*Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada um dos N alunos e calcular a média
aritmética das notas. Contar quantos alunos estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota
acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.
*/

using System.Runtime.InteropServices;

namespace Exercicio51
{
    class Program
    {
        static void Main(string[] args) 
        {
            int acimaDeSete, acimaDeCinco;
            acimaDeSete = acimaDeCinco = 0;
            float mediaAritmetica = 0;

            Console.Clear();

            Console.Write("Ola, digite quantas notas de alunos serão lidas: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            float[] notasAlunos = new float[quantidade];

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Clear();

                Console.Write("Digite a nota do " + (contador + 1) + "º aluno: ");
                notasAlunos[contador] = float.Parse(Console.ReadLine()!);

                if (notasAlunos[contador] > 7) {
                    acimaDeSete++;
                    acimaDeCinco++;
                } else if (notasAlunos[contador] > 5) {
                    acimaDeCinco++;
                }

                mediaAritmetica += notasAlunos[contador];
            }

            mediaAritmetica = mediaAritmetica / quantidade;

            Console.Clear();

            Console.WriteLine($"Essa é a média aritmética dos alunos: {mediaAritmetica:n1}\nQuantidade de alunos que tiraram notas acima de 7: {acimaDeSete}");

            if (acimaDeCinco == 0) {
                Console.WriteLine("Não há nenhum aluno com nota acima de 5");
            }

            Console.ReadKey();
        }
    }
}