/*Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente
entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir
mensagem de erro.
Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9
*/

namespace Exercicio59
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Clear();

            char[] letras = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y','z'];

            bool ordemCerta = false;
            int posicaoUm, posicaoDois, distancia;
            posicaoUm = posicaoDois = distancia = 0;
            char caractereUm, caractereDois;
            caractereUm = caractereDois = ' ';

            while (ordemCerta == false) {
                Console.Clear();
                Console.Write("Digite a primeira letra(por ordem, ela deve anteceder a segunda digitada): ");
                caractereUm = char.Parse(Console.ReadLine()!.ToLower());
                Console.WriteLine("");

                Console.Write("Agora, digite a segunda letra: ");
                caractereDois = char.Parse(Console.ReadLine()!.ToLower());
                Console.WriteLine("");

                for (int contador = 0; contador < letras.Length; contador++) {
                    if (caractereUm.Equals(letras[contador])) {
                        posicaoUm = contador;
                    }

                    if (caractereDois.Equals(letras[contador])) {
                        posicaoDois = contador;
                    }
                }

                if (posicaoDois > posicaoUm) {
                    ordemCerta = true;
                } else {
                    ordemCerta = false;
                    Console.WriteLine("Erro, as letras informadas não estão em ordem alfabética!");
                    Console.ReadKey();
                }
            }

            distancia = posicaoDois - posicaoUm - 1;

            Console.WriteLine($"Existem {distancia} letras entre {caractereUm} e {caractereDois}.");
            Console.ReadLine();   
        }
    }
}