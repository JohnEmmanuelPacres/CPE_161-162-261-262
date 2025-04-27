namespace LabAct3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int n, sum = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            if (sum <= 0)
            {
                Console.WriteLine($"Not a natural number!!");
            }
            else
            {
                Console.Write("Natural numbers: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1} ");
                }
                Console.WriteLine(" ");
                Console.WriteLine($"Sum of first {n} natural numbers: {sum}");
            }

            Console.ReadLine();
        }
    }
}
