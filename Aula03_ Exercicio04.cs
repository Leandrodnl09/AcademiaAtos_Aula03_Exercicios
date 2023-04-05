using System.Net;

namespace Aula03Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
            // Mostrar na tela qual dos professores tem o maior salário total.

            // variáveis que armazenam a quantidade de horas aula dadas pelos dois professores;
            int horasAula1, horasAula2;
            // variáveis que armazenam o valor por hora recebido pelos dois professores;
            double valorHora1, valorHora2;
            // variáveis que armazenam o salário total de cada professor;
            double salarioTotal1, salarioTotal2; 

            Console.WriteLine("Informe a quantidade de horas aula dadas pelo primeiro professor: ");
            horasAula1 = int.Parse(Console.ReadLine()); // lê a quantidade de horas aula dadas pelo primeiro professor;

            Console.WriteLine("Informe o valor por hora recebido pelo primeiro professor: ");
            valorHora1 = double.Parse(Console.ReadLine()); // lê o valor por hora recebido pelo primeiro professor;

            Console.WriteLine("Informe a quantidade de horas aula dadas pelo segundo professor: ");
            horasAula2 = int.Parse(Console.ReadLine()); // lê a quantidade de horas aula dadas pelo segundo professor;

            Console.WriteLine("Informe o valor por hora recebido pelo segundo professor: ");
            valorHora2 = double.Parse(Console.ReadLine()); // lê o valor por hora recebido pelo segundo professor;

            salarioTotal1 = horasAula1 * valorHora1; // calcula o salário total do primeiro professor;
            salarioTotal2 = horasAula2 * valorHora2; // calcula o salário total do segundo professor;

            if (salarioTotal1 > salarioTotal2)
            { // verifica qual professor tem o maior salário total;
                Console.WriteLine("O primeiro professor tem o maior salário total: R$" + salarioTotal1);
            }
            else if (salarioTotal2 > salarioTotal1)
            {
                Console.WriteLine("O segundo professor tem o maior salário total: R$" + salarioTotal2);
            }
            else
            {
                Console.WriteLine("Os dois professores têm o mesmo salário total: R$" + salarioTotal1);
            }
        }
    }
}