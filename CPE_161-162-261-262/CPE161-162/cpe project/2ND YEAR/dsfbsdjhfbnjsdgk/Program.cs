namespace dsfbsdjhfbnjsdgk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ans, num1, num2, result = 0;
            char opp;

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation: ");
            opp = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            bool ValidOpp = true;

            switch (opp)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num2 * num1;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: indeterminate");
                        ValidOpp = false;
                    }
                    else
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid opperation");
                    ValidOpp = false;
                    break;
            }

            if (ValidOpp)
            {
                Console.WriteLine("Answer: {0:F2}", result);
            }

            Console.ReadLine();
        }
    }
}
