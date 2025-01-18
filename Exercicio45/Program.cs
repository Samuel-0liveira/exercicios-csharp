//Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que foi realizada a leitura.

namespace Exercicio45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite quantos números terão na sequência: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int[] valores = new int[quantidade];

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Write("Digite o " + (contador + 1) +"º número: ");
                valores[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.WriteLine("Os valores lidos, em ordem inversa ficariam dessa forma: ");
            Array.Reverse(valores);

            for (int contador = 0; contador < quantidade; contador++) {
                Console.Write(valores[contador] + ", ");
            }

            Console.ReadKey();
        }
    }
}