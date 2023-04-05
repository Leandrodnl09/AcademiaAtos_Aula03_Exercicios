namespace Aula03_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            // O programa deve mostrar os dados do atleta mais novo e mais alto.


            // Declaração de variáveis para armazenar os dados dos atletas
            string nome1, nome2;
            int idade1, idade2;
            double altura1, altura2;

            // Solicita os dados do primeiro atleta
            Console.WriteLine("Digite o nome do primeiro atleta:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite a idade do primeiro atleta:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do primeiro atleta (em metros):");
            altura1 = double.Parse(Console.ReadLine());

            // Solicita os dados do segundo atleta
            Console.WriteLine("Digite o nome do segundo atleta:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a idade do segundo atleta:");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do segundo atleta (em metros):");
            altura2 = double.Parse(Console.ReadLine());

            // Verifica qual atleta é mais novo
            if (idade1 < idade2)
            {
                Console.WriteLine("O atleta mais novo é: " + nome1);
            }
            else
            {
                Console.WriteLine("O atleta mais novo é: " + nome2);
            }

            // Verifica qual atleta é mais alto
            if (altura1 > altura2)
            {
                Console.WriteLine("O atleta mais alto é: " + nome1);
            }
            else
            {
                Console.WriteLine("O atleta mais alto é: " + nome2);
            }
        }
    }
}