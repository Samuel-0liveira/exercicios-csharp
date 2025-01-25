/*Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado
VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.
            Quadrantes
                X1
                |
        2º      |         1º
                |
y ------------------------------
                |
                |
        3º      |        4º
*/

namespace Exercicio60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Olá, digite o valor de x: ");
            int valorX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Agora, digite o valor de y: ");
            int valorY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int respostaQuadrante = VerificarQuadrante(valorX, valorY);

            Console.WriteLine($"As coordenadas passadas representam o quadrante: {respostaQuadrante}");
            Console.ReadKey();
        }

        static int VerificarQuadrante(int x, int y)
        {
            int quadrante = 0;
            
            if (x > 0 && y > 0) {
                quadrante = 1;
            } else if (x > 0 && y < 0) {
                quadrante = 2;
            } else if (x < 0 && y < 0) {
                quadrante = 3;
            } else if (x < 0 && y > 0) {
                quadrante = 4;
            } else {
                quadrante = 0;
            }

            return quadrante;
        }
    }
}