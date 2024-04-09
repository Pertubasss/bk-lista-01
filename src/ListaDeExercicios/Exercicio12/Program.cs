namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerar e escrever os números ímpares entre 100 e 200.
            //Exemplo de saída: 101, 103, 105, ..., 199.

            Console.WriteLine(">>> Imprimir todos os numeros impares entre 100-200 <<<\n");

            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}