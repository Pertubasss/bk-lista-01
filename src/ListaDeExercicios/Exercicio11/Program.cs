namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar uma operação com base em dois valores inteiros A e B.
             * Exemplo de entrada: A = 3, B = 3
             * Exemplo de saída: A + B = 6.
             */
            int A, B;

            Console.WriteLine("Entre com um número:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com um segundo número:");
            B = Convert.ToInt32(Console.ReadLine());

            var soma = (A + B);

            Console.WriteLine($"Resultado da soma é {soma}");
        }
    }
}
