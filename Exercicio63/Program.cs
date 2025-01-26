//Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA . O
//método deverá receber um número inteiro (n) e deverá retornar a mensagem "PAR" ou "ÍMPAR".

namespace Exercicio63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            string retorno = Verificar(numero);

            Console.WriteLine($"{retorno}");
            Console.ReadKey();
        }

        static string Verificar(int n) 
        {
            string resultado = "";

            if (n % 2 == 0) {
                resultado = "PAR";
            } else {
                resultado = "ÍMPAR";
            }

            return resultado;
        }
    }
}