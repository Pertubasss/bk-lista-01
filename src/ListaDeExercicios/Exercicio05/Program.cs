namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Calcular a média ponderada de duas provas realizadas por um aluno.

Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
Fórmula: Média ponderada = (Nota da primeira prova * Peso da primeira prova) + (Nota da segunda prova * Peso da segunda prova)
Exemplo de saída: A média ponderada do aluno é 7.6.
*/
            decimal notaPrimeiraProva, pesoPrimeiraProva, notaSegundaProva, pesoSegundaProva;

            Console.WriteLine("Entre com a nota da primeira prova:");
            notaPrimeiraProva = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Entre com o peso da primeira prova:");
            pesoPrimeiraProva = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Entre com a nota da segunda prova:");
            notaSegundaProva = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Entre com o peso da primeira prova:");
            pesoSegundaProva = Convert.ToDecimal(Console.ReadLine());

            var mediaPonderada = (notaPrimeiraProva * pesoPrimeiraProva) + (notaSegundaProva * pesoSegundaProva);

            Console.WriteLine($"A media ponderada do aluno é {mediaPonderada}");
        }
    }
}
