using static System.Net.Mime.MediaTypeNames;

namespace Aula03_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            // Área do triangulo = (base * altura) / 2;
            // Teste se a base ou a altura digitada não foi igual a zero.

            // declaração das variáveis para armazenar a base, altura e área do triângulo;
            double baseTriangulo, alturaTriangulo, areaTriangulo;

            // solicita ao usuário que informe a base do triângulo e armazena na variável baseTriangulo;
            Console.Write("Digite a base do triângulo: ");
            baseTriangulo = double.Parse(Console.ReadLine());

            // solicita ao usuário que informe a altura do triângulo e armazena na variável alturaTriangulo;
            Console.Write("Digite a altura do triângulo: ");
            alturaTriangulo = double.Parse(Console.ReadLine());

            // verifica se a base e a altura são diferentes de zero, para evitar divisão por zero e outras inconsistências;
            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                // calcula a área do triângulo usando a fórmula dada e armazena na variável areaTriangulo;
                areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

                // exibe a mensagem com a área do triângulo;
                Console.WriteLine($"A área do triângulo é: {areaTriangulo}");
            }
            else
            {
                // caso a base ou a altura sejam iguais a zero, exibe uma mensagem de erro;
                Console.WriteLine("A base ou a altura não podem ser iguais a zero.");
            }
        }
    }
}