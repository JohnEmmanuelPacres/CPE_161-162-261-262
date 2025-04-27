namespace LabAct2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers would you like to store in an array? ");
            int[] arr;
            int i, n = int.Parse(Console.ReadLine()), sum = 0;

            if (n <= 0)
            {
                Console.WriteLine("Not a positive integer!!");
            }
            else
            {
                Console.Write($"Input {n} elements in the array: ");
                string input = Console.ReadLine();
                string[] arrInput = input.Split(' ');
                arr = new int[n];
                for (i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(arrInput[i]);
                    sum += arr[i];
                }
                Console.WriteLine($"Sum = {sum}");
                double average = (double)sum / n;
                Console.WriteLine("Average = {0:F2}", average);
            }

            Console.ReadLine();
        }
    }
}