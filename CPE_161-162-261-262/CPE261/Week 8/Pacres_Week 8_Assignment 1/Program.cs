namespace Pacres_Week_8_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool retry = true;

                while (retry)
                {
                    Console.Write("Enter a value for height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Enter a value for width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter a value for radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    string[] shapes = { "Rectangle", "Triangle", "Circle" };

                    Rectangle rectArea = new Rectangle(height, width);
                    Triangle triaArea = new Triangle(height, width);
                    Circle circArea = new Circle(radius);

                    double rectangleValue = rectArea.CalculateSurface();
                    double triangleValue = triaArea.CalculateSurface();
                    double circleValue = circArea.CalculateSurface();

                    double[] shapesValue = new double[]
                    {
                rectangleValue, triangleValue, circleValue
                    };

                    Console.WriteLine("\nAREAS:");
                    for (int i = 0; i < shapes.Length; i++)
                    {
                        Console.WriteLine($"Area of {shapes[i]} = {shapesValue[i]:F2}");
                    }

                    Console.Write("\nDo you want to try again [y/n]? ");
                    char choice = char.Parse(Console.ReadLine());
                    if (choice == 'y'|| choice == 'Y')
                    {
                        retry = true;
                        Console.WriteLine(" ");
                    }
                    else if (choice == 'n' || choice == 'N')
                    {
                        retry = false;
                    }
                    else
                    {
                        throw new Exception("Wrong choice.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Program terminating...");
            }
        }
    }

    abstract class Shape
    {
        private double height, width;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Shape()
        {
            this.height = 0;
            this.width = 0;
        }

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public abstract double CalculateSurface();
    }

    class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Width = width;
            this.Height = height;
        }

    public override double CalculateSurface()
        {
            return Width * Height;
        }
    }

    class Triangle : Shape
    {
        public Triangle(double height, double width)
        {
            this.Width=width;
            this.Height=height;
        }
        public override double CalculateSurface()
        {
            return (Height * Width) / 2;
        }
    }

    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}