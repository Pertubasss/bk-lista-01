namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o fatorial de um número e exibir o resultado.
            //Exemplo de entrada: Número = 5
            //Exemplo de saída: 5! = 120.

            Console.Write(">>> Calcular o fatorial de um número e exibir o resultado <<<\n");

            Console.Write("Digite um numero: ");

            int num = Convert.ToInt32(Console.ReadLine());
            int value = CalcFatorial(num);

            Console.Write($"O resultado do fatorial do numero {num} é: {value}");
        }

        static int CalcFatorial(int num)
        {
            int value = 1;

            for (int i = num; i >= 1; i--)
            {
                value *= i;
            }

            return value;
        }
    }
}
