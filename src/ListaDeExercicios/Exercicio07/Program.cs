namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Verificar se a soma de A + B é menor que C.
             * Exemplo de entrada: A = 5, B = 3, C = 10
             * Exemplo de saída: A + B é menor que C.
             */

            int A, B, C;

            Console.WriteLine("Entre com valor inteiro para A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com valor inteiro para B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com valor inteiro para C:");
            C = Convert.ToInt32(Console.ReadLine());

            int somaAeB = A + B;

            string saida = "A + B é menor que C";

            //if (somaAeB > C)
            //{
            //    saida = "A + B é maior que C";
            //}

            saida = somaAeB > C ? "A + B é maior que C" : saida;

            Console.WriteLine(saida);

        }
    }
}
