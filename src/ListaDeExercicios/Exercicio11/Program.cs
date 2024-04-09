namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar uma operação com base em dois valores inteiros A e B.

            //Exemplo de entrada: A = 3, B = 3
            //Exemplo de saída: A + B = 6.

            Console.WriteLine(">>> Realizar uma operação com base em dois valores inteiros A e B <<< \n");

            Console.Write("Digite o valor de A: ");
            int valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int valorB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nA soma de A+B é: {(valorA + valorB)}");
        }
    }
}
