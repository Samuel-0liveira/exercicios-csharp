/*Uma agência de publicidade pediu à agência de modelos Luz & Beleza para encontrar uma modelo que tenha
idade entre 18 e 20 anos para participar de uma campanha publicitária milionária de produtos de beleza. Foram
inscritas 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações foram armazenadas em
2 vetores distintos. Faça um programa para imprima o vetor que contém os nomes das candidatas aptas a
concorrer a uma vaga para a campanha milionária
*/

namespace Exercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[20];
            string[] nomes = new string[20];

            Console.Clear();

            for (int contador = 0; contador < 20; contador++) {
                Console.Write("Olá, digite o nome da " + (contador + 1) + "º modelo: ");
                nomes[contador] = Console.ReadLine()!;
                Console.WriteLine("");

                Console.Write("Agora, digite a sua idade: ");
                idade[contador] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }

            Console.Clear();

            Console.WriteLine("Essas foram as modelos que se encaixam na faixa entre 18 e 20 anos: ");
            Console.WriteLine("");
            
            for (int contador = 0; contador < 20; contador++) {
                if (idade[contador] >= 18 && idade[contador] <= 20) {
                    Console.WriteLine(nomes[contador]);
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();
        }
    }
}