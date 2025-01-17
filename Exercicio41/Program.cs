/*Faça um programa que dada a idade de um nadador,classifique-o em uma das seguintes categorias:
- Infantil A = 5 a 7 anos
- Infantil B = 8 a 11 anos
- Juvenil A = 12 a 13 anos
- Juvenil B = 14 a 17 anos
- Adultos = Maiores de 18 anos
*/

namespace Exercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            char encerrar = 'n';

            while (encerrar != 's') {
                Console.Clear();

                Console.Write("Olá, por favor, digite a idade do nadador para o classificarmos: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (idade >= 5 && idade < 7) {
                    Console.WriteLine("Categoria: Infantil A!");
                } else if (idade >= 8 && idade < 11) {
                    Console.WriteLine("Categoria: Infantil B!");
                } else if (idade >= 12 && idade < 13) {
                    Console.WriteLine("Categoria: Juvenil A!");
                } else if (idade >= 14 && idade < 17) {
                    Console.WriteLine("Categoria: Juvenil B!");
                } else if (idade >= 18) {
                    Console.WriteLine("Adulto!");
                } else {
                    Console.WriteLine("Nadador abaixo de 5 anos, não é possível classificar!");
                }

                Console.WriteLine("");

                Console.Write("Deseja encerrar o programa? [s / n]: ");
                encerrar = char.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("");
            Console.WriteLine("Encerrando.....");
            
            Console.ReadKey();
        }
    }
}