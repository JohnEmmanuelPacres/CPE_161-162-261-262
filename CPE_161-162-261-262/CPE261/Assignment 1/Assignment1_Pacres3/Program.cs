namespace Assignment1_Pacres3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());
            radius = Math.Pow(radius, 2);
            double area = double.Pi * radius;
            Console.WriteLine("Area of Circle: {0:F4}", area);
            Console.ReadLine();
        }
    }
}
