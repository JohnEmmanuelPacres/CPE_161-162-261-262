namespace LabAct1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try 
            {
                Console.Write("How many numbers would you like to store in an array? ");
                int[] arr;
                int i, n = int.Parse(Console.ReadLine());
                arr = new int[n];
                Console.WriteLine($"Input {n} elements in the array: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("Element {0}: ", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Original values of array: ");
                foreach (int a in arr)
                {
                    Console.Write($"{a} ");
                }

                Console.WriteLine(" ");
                Console.Write("Reverse order: ");
                for (i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{arr[i]} ");
                }

            }
            catch
            {
                    Console.WriteLine("Not a positive integer!!");
            }
            Console.ReadLine();
        }
    }
}
