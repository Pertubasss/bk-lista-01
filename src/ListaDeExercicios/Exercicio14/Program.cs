namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir a sequência de Fibonacci até um número informado.
            //Exemplo de entrada: Número = 50
            //Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

            Console.WriteLine(">>> Imprimir a sequência de Fibonacci até um número informado <<<\n");

            Console.Write("Digite um numero: ");

            int num = Convert.ToInt32(Console.ReadLine());

            CalcFibonacci(num);

            Console.ReadKey();
        }

        static void CalcFibonacci(int num)
        {
            int first = 0, second = 1;

            while (first <= num)
            {
                Console.WriteLine(first);

                int prox = first + second;

                first = second;
                second = prox;
            }
        }
    }
}