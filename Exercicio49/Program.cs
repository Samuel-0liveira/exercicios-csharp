//Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50). Determine e imprima quantas vezes
//que V1 e V2 possuem valores idênticos nas mesmas posições.

namespace Exercicio49
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;

            do {
                Console.Clear();
                Console.Write("Olá, digite quantos valores serão comparados (máximo 50): ");
                quantidade = Convert.ToInt32(Console.ReadLine());
            } while (quantidade > 50);

            int[] v1 = new int[quantidade];
            int[] v2 = new int[quantidade];

            for (int contador = 0; contador < quantidade; contador++) {
               Console.Clear();

               Console.Write("Digite o " +(contador + 1)+ "º valor do vetor 1: ");
               v1[contador] = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("");

               Console.Write("Digite o " +(contador + 1)+ "º valor do vetor 2: ");
               v2[contador] = Convert.ToInt32(Console.ReadLine());
            }

            int repeticao = 0;

            for (int contador = 0; contador < quantidade; contador++) {
                if (v1[contador] == v2[contador]) {
                    repeticao++;
                }
            }

            Console.Clear();
            Console.WriteLine($"A quantidade de vezes em que os valores se repetem na mesma posição é: {repeticao}");
            Console.ReadKey();
        }
    }
}