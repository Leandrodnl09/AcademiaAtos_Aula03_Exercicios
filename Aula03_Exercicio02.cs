namespace Aula03_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar.

            Console.Write("Digite um número inteiro: "); // Exibe uma mensagem para o usuário informar um número inteiro
            int num = int.Parse(Console.ReadLine()); // Lê a entrada do usuário como uma string e converte para um número inteiro

            if (num % 2 == 0)
            { // Verifica se o número é par, ou seja, se o resto da divisão por 2 é zero
                Console.WriteLine("{0} é um número par.", num); // Exibe uma mensagem informando que o número é par
            }
            else
            { // Caso contrário, ou seja, se o número é ímpar
                Console.WriteLine("{0} é um número ímpar.", num); // Exibe uma mensagem informando que o número é ímpar
            }
        }
    }
}