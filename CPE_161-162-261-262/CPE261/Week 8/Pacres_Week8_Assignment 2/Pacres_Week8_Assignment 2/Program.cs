using System.Data.Common;

namespace Pacres_Week8_Assignment_2
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
                    Console.Write("Where are you right now? ");
                    string cathome = Console.ReadLine();
                    Console.Write("Oh, it's a cat, can you name the cat? ");
                    string catname = Console.ReadLine();
                    Console.Write("What do you think is the cat's favorite food? ");
                    string catfood = Console.ReadLine();
                    Console.Write("What do you think is the cat's favorite drink? ");
                    string catdrink = Console.ReadLine();
                    Console.WriteLine("How fast is the cat? ");
                    Console.Write("Enter displacement: ");
                    double catdisp = double.Parse(Console.ReadLine());
                    Console.Write("Enter time: ");
                    double cattime = double.Parse(Console.ReadLine());
                    if (cattime == 0)
                    {
                        throw new DivideByZeroException("Time cannot be zero.");
                    }

                    Console.Write("\nIt seems your house has a mouse, what do you think the mouse name? ");
                    string mousename = Console.ReadLine();
                    Console.Write("What do you think is the mouse's favorite food? ");
                    string mousefood = Console.ReadLine();
                    Console.Write("What do you think is the mouse's favorite drink? ");
                    string mousedrink = Console.ReadLine();
                    Console.WriteLine("How fast is the mouse? ");
                    Console.Write("Enter displacement: ");
                    double mousedisp = double.Parse(Console.ReadLine());
                    Console.Write("Enter time: ");
                    double mousetime = double.Parse(Console.ReadLine());
                    if (mousetime == 0)
                    {
                        throw new DivideByZeroException("Time cannot be zero.");
                    }

                    Cat cat = new Cat(catname, cathome, catfood, catdrink, cattime, catdisp);
                    Mouse mouse = new Mouse(mousename, mousefood, mousedrink, mousedisp, mousetime);

                    Console.WriteLine($"\n***** The Story of {char.ToUpper(catname[0]) + catname.Substring(1)} the cat vs. " +
                        $"{char.ToUpper(mousename[0]) + mousename.Substring(1)} the mouse *****");
                    Console.Write($"\nOne day, in {char.ToUpper(cathome[0]) + cathome.Substring(1)}, there was a cat. ");
                    cat.DisplayName(char.ToUpper(catname[0]) + catname.Substring(1));
                    cat.ICanEat(char.ToUpper(catname[0]) + catname.Substring(1), catfood);
                    cat.ICanDrink(catdrink);
                    double catvelocity = cat.GetVelocity(cattime, catdisp);
                    cat.Run(char.ToUpper(catname[0]) + catname.Substring(1), catvelocity);
                    Console.WriteLine($"Moments later, {char.ToUpper(catname[0]) + catname.Substring(1)} " +
                        $"found a mouse and chase after it.");
                    mouse.DisplayName(char.ToUpper(mousename[0]) + mousename.Substring(1));
                    mouse.ICanEat(char.ToUpper(mousename[0]) + mousename.Substring(1), mousefood);
                    mouse.ICanDrink(mousedrink);
                    double mousevelocity = mouse.GetVelocity(mousetime, mousedisp);
                    mouse.Run(char.ToUpper(mousename[0]) + mousename.Substring(1), mousevelocity);

                    if (catvelocity > mousevelocity)
                    {
                        Console.WriteLine($"{char.ToUpper(catname[0]) + catname.Substring(1)} was faster, " +
                            $"{char.ToUpper(mousename[0]) + mousename.Substring(1)} was caught and eaten.");
                        cat.Back(char.ToUpper(cathome[0]) + cathome.Substring(1));
                        Console.WriteLine("\nTHE END.\n");
                    }
                    else if (catvelocity < mousevelocity)
                    {
                        Console.WriteLine($"{char.ToUpper(mousename[0]) + mousename.Substring(1)} was faster, " +
                            $"{char.ToUpper(catname[0]) + catname.Substring(1)} got tired and fell into a trap.");
                        Console.WriteLine($"A Chinese siomai vendor found " +
                            $"{char.ToUpper(catname[0]) + catname.Substring(1)}'s unconscious body and was turned into siomai.");
                        mouse.Back(char.ToUpper(cathome[0]) + cathome.Substring(1));
                        Console.WriteLine("\nTHE END.\n");
                    }
                    else
                    {
                        Console.WriteLine($"{char.ToUpper(mousename[0]) + mousename.Substring(1)} " +
                            $"and {char.ToUpper(catname[0]) + catname.Substring(1)} ran endlessly until both of them got tired.");
                        Console.WriteLine($"Eventually, a Chinese kid caught them and they were turned into Chinese delicacy.");
                        Console.WriteLine("\nTHE END.\n");
                    }

                    Console.Write("\nDo you want to make another story [y/n]? ");
                    char choice = char.Parse(Console.ReadLine());
                     if (choice == 'y' || choice == 'Y')
                    {
                        retry = true;
                        Console.WriteLine(" ");
                    }
                     else if (choice == 'n' || choice == 'N')
                    {
                        Console.WriteLine("Thank you for using the program.");
                        retry = false;
                    }
                     else
                    {
                        throw new Exception("Invalid choice.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Program closing...");
            }

            Console.ReadKey();
        }
    }

    interface ICanMove
    {
        void Run(string name, double velocity);
        void Back(string home);
        double GetVelocity(double time, double displacement);
    }

    interface ICanEat
    {
        void Eat();
    }

    interface ICanDrink
    {
        void Drink();
    }

    abstract class Animal : ICanMove
    {
        public void Run(string name, double velocity)
        {
            Console.WriteLine($"{name} can run up to {velocity}. ");
        }
        public abstract void Back(string home);
        public abstract double GetVelocity(double time, double displacement);
    }

    class Cat : Animal
    {
        private string name, home, food, drink;
        private double displacement, time;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Food
        {
            get { return food; }
            set { food = value; }
        }

        public string Drink
        {
            get { return drink; }
            set { drink = value; }
        }

        public string Home
        {
            get { return home; }
            set { home = value; }
        }

        public double Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public double Time
        {
            get { return time; }
            set { time = value; }
        }
        public Cat(string name, string home, string food, string drink, double time, double displacement)
        {
            this.name = name;
            this.home = home;
            this.food = food;
            this.drink = drink;
            this.time = time;
            this.displacement = displacement;
        }

        public void DisplayName(string name)
        {
            Console.WriteLine($"The cat's name is {name}. ");
        }
        public void ICanEat(string name, string food)
        {
            Console.Write($"{name} loves to eat {food} ");
        }

        public void ICanDrink(string drink)
        {
            Console.Write($"and loves to drink {drink}. ");
        }
        public override double GetVelocity(double time, double displacement)
        {
            double velocity = displacement / time;
            return velocity;
        }
        public void Run(string name, double velocity)
        {
            Console.WriteLine($"{name} can run up to {velocity:F2} m/s.");
        }

        public override void Back(string home)
        {
            Console.WriteLine($"The cat returned to {home} and slept. ");
        }
    }

    class Mouse : Animal
    {
        private string name, food, drink;
        private double time, displacement;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Food
        {
            get { return name; }
            set { food = value; }
        }

        public string Drink
        {
            get { return name; }
            set { drink = value; }
        }
        public double Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public double Time
        {
            get { return time; }
            set { time = value; }
        }

        public Mouse(string name, string food, string drink, double displacement, double time)
        {
            this.name = name;
            this.food = food;
            this.drink = drink;
            this.displacement = displacement;
            this.time = time;
        }

        public void DisplayName(string name)
        {
            Console.Write($"The mouse's name is {name}. ");
        }

        public void ICanEat(string name, string food)
        {
            Console.Write($"{name} loves to eat {food} ");
        }

        public void ICanDrink(string drink)
        {
            Console.Write($"and loves to drink {drink}. ");
        }
        public override double GetVelocity(double time, double displacement)
        {
            double velocity = displacement / time;
            return velocity;
        }

        public void Run(string name, double velocity)
        {
            Console.WriteLine($"{name} can run up to {velocity:F2} m/s.");
        }

        public override void Back(string home)
        {
            Console.WriteLine($"The mouse returned to {home} and slept. ");
        }
    }
}