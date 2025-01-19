//Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses vetores. Ou seja, realizar
//a soma de todos dos resultados da multiplicação de x[i] por y[i]

namespace Exercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite quantos elementos terão nos vetores: ");
            int elementos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[] vetorX = new int[elementos];
            int[] vetorY = new int[elementos];
            int[] multiplicacoes = new int[elementos];
            int produtoEscalar = 0;


            for (int contador = 0; contador < elementos; contador++) {
                Console.Clear();

                Console.Write("Digite o " + (contador + 1) + "° número do vetor x: ");
                vetorX[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.Write("Digite o " + (contador + 1) + "° número do vetor y: ");
                vetorY[contador] = Convert.ToInt32(Console.ReadLine());
            }

            for (int contador = 0; contador < elementos; contador++) {
                multiplicacoes[contador] = vetorX[contador] * vetorY[contador];
                produtoEscalar += multiplicacoes[contador];
            }

            Console.Clear();
            Console.WriteLine($"O produto escalar dos vetores é: {produtoEscalar}");
            Console.ReadKey();
        }
    }
}