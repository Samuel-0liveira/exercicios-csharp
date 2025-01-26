/*Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método 
recebe o valor da base e da altura de um triângulo.
Fórmulas: hipotenusa2 = base2 + altura2
           base x altura
área = ----------------------
                2
*/

namespace Exercicio62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Por favor, digite a base do triângulo: ");
            float baseTriangulo = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            Console.Write("Agora, digite a altura do triângulo: ");
            float alturaTriangulo = float.Parse(Console.ReadLine()!);
            Console.WriteLine("");

            double area = Hipotenusa(baseTriangulo, alturaTriangulo);

            Console.WriteLine($"O valor da hipotenusa é: {area:n1}");
            Console.ReadKey();
        }

        static double Hipotenusa(float baseT, float alturaT)
        {
            double hipotenusa = 0;

            baseT *= baseT;
            alturaT *= alturaT;

            hipotenusa = baseT + alturaT;

            hipotenusa = Math.Sqrt(hipotenusa);

            return hipotenusa;
        }
    }
}