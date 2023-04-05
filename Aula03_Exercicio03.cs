namespace Aula03_Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média,
            // e escrever na tela os que são superiores à média.

            // Lê quatro valores;
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            double valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor:");
            double valor4 = double.Parse(Console.ReadLine());

            // Calcula a média;
            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            // Escreve na tela os valores que são superiores à média;
            if (valor1 > media)
            {
                Console.WriteLine($"O valor {valor1} é superior à média ({media}).");
            }

            if (valor2 > media)
            {
                Console.WriteLine($"O valor {valor2} é superior à média ({media}).");
            }

            if (valor3 > media)
            {
                Console.WriteLine($"O valor {valor3} é superior à média ({media}).");
            }

            if (valor4 > media)
            {
                Console.WriteLine($"O valor {valor4} é superior à média ({media}).");
            }
        }
    }
}