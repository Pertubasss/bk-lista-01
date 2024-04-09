namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.
            //Exemplo de saída: 1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, ...

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //i = 1;

            //do
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;

            //} while (i <= 100);

            Console.ReadKey();
        }
    }
}
