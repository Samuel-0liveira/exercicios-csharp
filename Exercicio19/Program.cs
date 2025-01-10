/*Escreva um programa que leia três valores para os lados de um triângulo (variáveis A, B e C). Verificar se cada
lado é menor que a soma dos outros dois lados. Se sim, saber se A==B e se B==C, sendo verdade o triângulo é
eqüilátero; Se não, verificar de A==B ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso
contrário, o triângulo será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a
ocorrência.
*/

using System;

namespace Exercicio19;

class Program
{
    static void Main(string[] args)
    {
        PedirValorDosLados();
        Console.ReadKey();
    }

    static void PedirValorDosLados()
    {
        Console.Clear();

        Console.Write("Olá, digite a medida de um dos lados do triângulo: ");
        int ladoA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Agora, digite a medida de outro lado do triângulo: ");
        int ladoB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        Console.Write("Por fim, o último lado: ");
        int ladoC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");

        if (ladoA == 0 || ladoB == 0 || ladoC == 0)
        {
            Console.WriteLine("Não é possível formar um triângulo com o valor 0");
        } else if ((ladoA < ladoB + ladoC) || (ladoB < ladoC + ladoA) || (ladoC < ladoA + ladoB)) {

            Console.WriteLine("As medidas passadas caracterizam um triângulo, verificando qual o tipo...");
            Console.WriteLine("");

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("O triângulo é: Equilátero!");
            } else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) {
                Console.WriteLine("O triângulo é: Isósceles!");
            } else {
                Console.WriteLine("O triângulo é: Escaleno!");
            }
        } else {
            Console.WriteLine("As medidas passadas não caracterizam um triângulo!");
        }
    }
}