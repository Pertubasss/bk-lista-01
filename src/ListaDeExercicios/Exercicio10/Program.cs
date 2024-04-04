namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Identificar se um número é par ou ímpar.
             * Exemplo de entrada: Número = 7
             * Exemplo de saída: O número é ímpar.
             */

            int numero;

            bool par = false;
            bool impar = false;

            Console.WriteLine("Entre com um número:");
            numero = Convert.ToInt32(Console.ReadLine());

            par = numero % 2 == 0;
            impar = numero % 2 == 1;

            if (par)
            {
                Console.WriteLine("O número é par");
                return;
            }

            if (impar)
            {
                Console.WriteLine("O número é impar");
                return;
            }

        }
    }
}
