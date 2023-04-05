namespace Aula03_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            // O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
            // exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.


            // Recebe a frase e a palavra de pesquisa do usuário
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra para pesquisar:");
            string palavra = Console.ReadLine();

            // Verifica se a palavra aparece na frase
            bool palavraEncontrada = frase.Contains(palavra);

            // Exibe mensagem informando se a palavra foi encontrada ou não
            if (palavraEncontrada)
            {
                Console.WriteLine("A palavra \"" + palavra + "\" encontra-se na frase.");
            }
            else
            {
                Console.WriteLine("A palavra \"" + palavra + "\" não se encontra na frase.");
            }
        }
    }
}