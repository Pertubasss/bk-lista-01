namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média ponderada de duas provas realizadas por um aluno.

            //Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
            //Fórmula: Média ponderada = (Nota da primeira prova* Peso da primeira prova) +(Nota da segunda prova* Peso da segunda prova)
            //Exemplo de saída: A média ponderada do aluno é 7.6.

            Console.WriteLine(">>> Calcular a média ponderada de duas provas realizadas por um aluno <<<\n");

            Console.Write("Digite a nota da primeira prova: ");
            decimal notaProva1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            decimal pesoProva1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            decimal notaProva2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a peso da segunda prova: ");
            decimal pesoProva2 = Convert.ToDecimal(Console.ReadLine());

            decimal media = CalcularMedia(pesoProva1, notaProva1, pesoProva2, notaProva2);

            Console.WriteLine($"A média ponderada é: {media:F2}");
        }

        static decimal CalcularMedia(decimal pesoProva1, decimal notaProva1, decimal pesoProva2, decimal notaProva2)
        {
            return (notaProva1 * pesoProva1) + (notaProva2 * pesoProva2);
        }

    }
}