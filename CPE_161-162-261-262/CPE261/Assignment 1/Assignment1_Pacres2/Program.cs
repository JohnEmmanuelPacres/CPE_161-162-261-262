namespace Assignment1_Pacres2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            double sum = 0.00;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter 3 numbers: ");
                number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }
            double average = sum / 3;
            Console.WriteLine("The average is {0:F2}", average);
            Console.ReadLine();
        }
    }
}
