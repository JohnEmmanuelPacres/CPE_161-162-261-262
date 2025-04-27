namespace LabAct3_loopAndarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any integer: ");
            int i, sum = 0, n = int.Parse(Console.ReadLine());
            double power;
            bool natural = true;

            while (natural)
            {
                if (n <= 0)
                {
                    Console.WriteLine("Not a natural number!!");
                    natural = false;
                }
                else
                {
                    for (i = 0; i <= n; i++)
                    {
                        power = Math.Pow(i, 2);
                        sum = (int)((double)sum + power);
                    }

                    Console.Write($"Squares of the first {n} natural numbers: ");
                    int[] squares = new int[n];
                    for (i = 0; i < n; i++)
                    {
                        squares[i] = (i + 1) * (i + 1);
                    }

                    for (i = 0; i < n; i++)
                    {
                        Console.Write($"{squares[i]} ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine($"Sum of the squares of the first {n} natural numbers: {sum}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
