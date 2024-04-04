namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ordenar três valores inteiros e diferentes em ordem decrescente.
             * Exemplo de entrada: 5, 10, 3
             * Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.
             */

            int pos1, pos2, pos3;

            Console.WriteLine("Entre com o primeiro número : ");
            pos1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o segundo número : ");
            pos2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro número : ");
            pos3 = Convert.ToInt32(Console.ReadLine());

            int temporario;
            if (pos1 < pos2)// se pos1 é menor que pos 2
            {
                temporario = pos2;// guarda temporariamente o valor da pos2 
                pos2 = pos1;
                pos1 = temporario;
            }

            if (pos1 < pos3)
            {
                temporario = pos3;
                pos3 = pos1;
                pos1 = temporario;
            }

            if (pos2 < pos3)
            {
                temporario = pos3;
                pos3 = pos2;
                pos2 = temporario;
            }

            string resultado = $"{pos1} , {pos2} , {pos3}";
            Console.WriteLine($"Ordenação decrescente {resultado}");
        }
    }
}
