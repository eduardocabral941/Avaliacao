namespace Pergunta03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma palavra para inverter: ");
            string original = Console.ReadLine();
            string reversed = "";
            for (int i = original.Length - 1; i >= 0; i--)
            {
                reversed += original[i];
            }
            Console.WriteLine(reversed);
            Console.ReadKey();
        }
    }
}
