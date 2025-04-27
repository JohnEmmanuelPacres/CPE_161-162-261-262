using System.Numerics;

namespace Pacres_Week_4_Lab_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Area of Circle", "Volume of Cube", "Perimeter of Triangle", "Surface Area of Rectangle" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {arr[i]}");
            }
            
            try
            {
                Console.Write("\nEnter choice: ");
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case '1':
                        try
                        {
                            AreaCircle CircleArea = new AreaCircle();
                            Console.Write("Press 1 if radius, 2 if diameter: ");
                            char subChoice = char.Parse(Console.ReadLine());
                            if (subChoice == '1')
                            {
                                Console.Write("Enter circle's radius: ");
                                CircleArea.Rad = double.Parse(Console.ReadLine());
                                CircleArea.areaCircle_rad();
                            }
                            else if (subChoice == '2')
                            {
                                Console.Write("Enter circle's diameter: ");
                                CircleArea.Diameter = double.Parse(Console.ReadLine());
                                CircleArea.areaCircle_dia();
                            }
                            else
                            {
                                throw new IOException();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write($"\nYour input has triggered an error. Error: {ex.Message}");
                        }
                        break;

                    case '2':
                        VolumeCube CubeVolume = new VolumeCube();
                        Console.Write("Enter cube's side: ");
                        CubeVolume.Side = double.Parse(Console.ReadLine());
                        CubeVolume.volumeCube();
                        break;

                    case '3':
                        try
                        {
                            PerimeterTriangle TrianglePerimeter = new PerimeterTriangle();
                            string[] triangle = { "Equilateral", "Scalene", "Isosceles" };
                            for (int i = 0; i < triangle.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {triangle[i]}");
                            }
                            Console.Write("Choose a triangle: ");
                            char subChoice2 = char.Parse(Console.ReadLine());

                            if (subChoice2 == '1')
                            {
                                Console.Write("Enter triangle sides: ");
                                TrianglePerimeter.Side = double.Parse(Console.ReadLine());
                                TrianglePerimeter.perimeterTriangle_equilateral();
                            }
                            else if (subChoice2 == '2')
                            {
                                Console.Write("Enter triangle side 1: ");
                                TrianglePerimeter.Side1 = double.Parse(Console.ReadLine());
                                Console.Write("Enter triangle side 2: ");
                                TrianglePerimeter.Side2 = double.Parse(Console.ReadLine());
                                Console.Write("Enter triangle side 3: ");
                                TrianglePerimeter.Side3 = double.Parse(Console.ReadLine());

                                if (TrianglePerimeter.Side1 + TrianglePerimeter.Side2 <= TrianglePerimeter.Side3)
                                {
                                    Console.WriteLine("\nMake sure side 1 + side 2 > side 3.");
                                }
                                else if (TrianglePerimeter.Side1 + TrianglePerimeter.Side3 <= TrianglePerimeter.Side2)
                                {
                                    Console.WriteLine("\nMake sure side 1 + side 3 > side 2."); ;
                                }
                                else if (TrianglePerimeter.Side2 + TrianglePerimeter.Side3 <= TrianglePerimeter.Side1)
                                {
                                    Console.WriteLine("\nMake sure side 2 + side 3 > side 1");
                                }
                                else
                                {
                                    TrianglePerimeter.perimeterTriangle_scalene();
                                }
                            }
                            else if (subChoice2 == '3')
                            {
                                Console.Write("Enter triangle side 1: ");
                                TrianglePerimeter.Side1 = double.Parse(Console.ReadLine());
                                Console.Write("Enter triangle side 2: ");
                                TrianglePerimeter.Side2 = double.Parse(Console.ReadLine());
                                if (TrianglePerimeter.Side2 >= TrianglePerimeter.Side1 * 2)
                                {
                                    Console.WriteLine("\nMake sure side 2 < twice of side 1.");
                                }
                                else
                                {
                                    TrianglePerimeter.perimeterTriangle_isosceles();
                                }
                            }
                            else
                            {
                                throw new IOException();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Write($"\nYour input has triggered an error. Error: {ex.Message}");
                        }
                        break;

                    case '4':
                        SurfaceAreaRec RecArea = new SurfaceAreaRec();
                        Console.Write("Enter rectangle's length: ");
                        RecArea.Length = double.Parse(Console.ReadLine());
                        Console.Write("Enter rectangle's width: ");
                        RecArea.Width = double.Parse(Console.ReadLine());
                        RecArea.surfaceAreaRectangle();
                        break;

                    default:
                        throw new IOException();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nYour input has triggered an error. Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nProgram is terminating...");
            }

            Console.ReadKey();
        }
    }

    //AreaCircle class
    public class AreaCircle
    {
        //field
        private double rad, diameter, area;
       
        public double Rad 
        { 
            get 
            { 
                return this.rad; 
            } 
            set 
            { 
                this.rad = value; 
            } 
        }

        public double Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;
            }
        }
        //constructor
        public AreaCircle()
        {
            this.rad = 2.0;
        }

        public AreaCircle(double rad, double area, double diameter)
        {
            this.rad = rad;
            this.diameter = diameter;
            this.area = area;
        }
        //method
        public void areaCircle_rad()
        {
            rad = Math.Pow(this.rad, 2);
            area = this.rad * double.Pi;
            Console.WriteLine("\nThe Area of the Circle is {0:F2}.", area);
        }

        public void areaCircle_dia()
        {
            diameter = Math.Pow(this.diameter, 2);
            area = 0.25 * double.Pi * this.diameter;
            Console.WriteLine("\nThe Area of the Circle is {0:F2}.", area);
        }
    }

    //VolumeCube class
    public class VolumeCube
    {
        private double side, volume;

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }
        //constructor
        public VolumeCube()
        {
            this.side = 2.0;
        }

        public VolumeCube(double side, double volume)
        {
            this.side = side;
            this.volume = volume;    
        }
        //method
        public void volumeCube()
        {
            volume = Math.Pow(this.side, 3);
            Console.WriteLine("\nThe volume of the cube is {0:F2}.", volume);
        }
    }

    //PerimeterTriangle class
    public class PerimeterTriangle
    {
        private double side, side1, side2, side3, perimeter;

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }

        public double Side1
        {
            get
            {
                return this.side1;
            }
            set
            {
                this.side1 = value;
            }
        }

        public double Side2
        {
            get
            {
                return this.side2;
            }
            set
            {
                this.side2 = value;
            }
        }

        public double Side3
        {
            get
            {
                return this.side3;
            }
            set
            {
                this.side3 = value;
            }
        }
        //constructor
        public PerimeterTriangle()
        {
            this.side = 2.0;
            this.side1 = 3.0;
            this.side2 = 4.0;
            this.side3 = 5.0;
        }
        public PerimeterTriangle(double side, double side1, double side2, double side3, double perimeter)
        {
            this.side = side;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.perimeter = perimeter;
        }
        //method
        public void perimeterTriangle_equilateral()
        {
            double perimeter = 3 * this.side;
            Console.WriteLine("\nThe perimeter of the triangle is {0:F2}.", perimeter);
        }

        public void perimeterTriangle_scalene()
        {
            double perimeter = this.side1 + this.side2 + this.side3;
            Console.WriteLine("\nThe perimeter of the triangle is {0:F2}.", perimeter);
        }

        public void perimeterTriangle_isosceles()
        {
            double perimeter = 2 * this.side1 + this.side2;
            Console.WriteLine("\nThe perimeter of the triangle is {0:F2}.", perimeter);
        }
    }

    //SurfaceAreaRec class
    public class SurfaceAreaRec
    {
        private double length, width, area;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        //constructor
        public SurfaceAreaRec()
        {
            this.length = 2.0;
            this.width = 2.0;
        }

        public SurfaceAreaRec(double length, double width, double area)
        {
            this.length = length;
            this.width = width;
            this.area = area;
        }
        //method
        public void surfaceAreaRectangle()
        {
            area = this.length * this.width;
            Console.WriteLine($"\nThe surface area of the rectangle is {area:F2}.");
        }
    }
}