namespace Pergunta02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para verficar se ele pertence ou não a sequência de Fibonacci");
            int n = int.Parse(Console.ReadLine());

            List<int> fibSeq = new List<int> { 0, 1 };
            while (fibSeq[fibSeq.Count - 1] < n)
            {
                fibSeq.Add(fibSeq[fibSeq.Count - 1] + fibSeq[fibSeq.Count - 2]);
            }
            if (fibSeq.Contains(n))
            {
                Console.WriteLine($"O número ({n}) pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número ({n}) não pertence à sequência de Fibonacci.");
            }

            Console.ReadKey();
        }
    }
}