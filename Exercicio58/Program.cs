//Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir
//também o maior. A quantidade de números lidos será definida pelo usuário.

namespace Exercicio58
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = 0;
            float media = 0;

            Console.Clear();

            Console.Write("Digite quantos números serão lidos: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[] valores = new int[quantidade];

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Clear();

                Console.Write("Digite o " + (contador + 1) + "º valor do vetor: ");
                valores[contador] = Convert.ToInt32(Console.ReadLine());

                if (valores[contador] >= maior) {
                    maior = valores[contador];
                }

                media += valores[contador];
            }

            media /= quantidade;

            Console.Clear();
            Console.WriteLine($"A média dos valores é: {media:n1}\nO maior valor lido foi: {maior}");
            Console.ReadKey();
        }
    }
}