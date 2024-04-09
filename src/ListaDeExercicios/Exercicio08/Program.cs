namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ordenar três valores inteiros e diferentes em ordem decrescente.

            //Exemplo de entrada: 5, 10, 3
            //Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.

            Console.WriteLine(">>> Ordenar de em ordem decrescente <<<\n");

            int[] numeros = new int[3];

            Console.Write("Digite o primeiro numero: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());

            //int[] numeross = {num1, num2, num3};

            Array.Sort(numeros);
            Array.Reverse(numeros);

            Console.WriteLine("\nOs numeros digitados em ordem decrescente são:");

            foreach (int num in numeros)
            {
                Console.WriteLine($"{num}");
            }
        }
    }
}
