namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Identificar se um número é par ou ímpar.

            //Exemplo de entrada: Número = 7
            //Exemplo de saída: O número é ímpar.


            Console.WriteLine(">>> Identificar se o numero é par ou impar <<<\n");
            Console.Write("Digite o numero desejado: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nO numero digitado é PAR");
            }
            else
            {
                Console.WriteLine("\nO numero digitado é ÍMPAR");
            }
        }
    }
}