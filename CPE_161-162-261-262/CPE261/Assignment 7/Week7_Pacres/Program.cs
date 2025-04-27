namespace Week7_Pacres
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                bool Retry = true;
                while (Retry)
                {
                    string[] arr = { "Student", "Worker" };
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {arr[i]}");
                    }

                    Console.Write("Enter choice: ");
                    char choice = char.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case '1':
                            Student student = new Student();
                            Console.Write("Enter student first name: ");
                            student.First_name = Console.ReadLine();
                            Console.Write("Enter student last name: ");
                            student.Last_name = Console.ReadLine();
                            Console.Write("Enter number of subjects: ");
                            student.Subjects = int.Parse(Console.ReadLine());

                            if (student.Subjects == 0)
                            {
                                throw new DivideByZeroException("Subject/s cannot be zero.");
                            }

                            for (int i = 0; i < student.Subjects; i++)
                            {
                                Console.Write($"Enter subject {i + 1} grade: ");
                                student.Marks += double.Parse(Console.ReadLine());
                            }

                            student.student_grades();
                            break;

                        case '2':
                            Worker worker = new Worker();
                            Console.Write("Enter worker first name: ");
                            worker.First_name = Console.ReadLine();
                            Console.Write("Enter worker last name: ");
                            worker.Last_name = Console.ReadLine();
                            Console.Write($"Enter {worker.First_name} wage: $");
                            worker.Wage = double.Parse(Console.ReadLine());
                            Console.Write($"Enter {worker.First_name} hours worked: ");
                            worker.Hours_worked = double.Parse(Console.ReadLine());

                            if (worker.Hours_worked == 0)
                            {
                                throw new DivideByZeroException("Hour/s cannot be zero.");
                            }

                            worker.hourly_wage();
                            break;
                        default:
                            throw new Exception("Invalid choice");
                    }

                    Console.Write("\nDo you want to continue [y/n]? ");
                    char affirm = char.Parse(Console.ReadLine());

                    if (affirm == 'y' || affirm == 'Y')
                    {
                        Retry = true;
                        Console.WriteLine(" ");
                    }
                    else if (affirm == 'n' || affirm == 'N')
                    {
                        Console.WriteLine("Thank you for using...");
                        Retry = false;
                    }
                    else
                    {
                        throw new Exception("Invalid choice.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nProcessing failed: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nProgram will terminate...");
            }    
        }
    }

    public class Human
    {
        private string first_name, last_name;
        
        public string First_name
        {
            get { return first_name; }
            set { first_name = value; }
        }

        public string Last_name
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public Human()
        {
            this.first_name = string.Empty;
            this.last_name = string.Empty;
        }

        public Human(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;   
        }
    }

    public class Student : Human
    {
        private double mark, subjects;
        public double Marks
        {
            get { return mark; }
            set { mark = value; }
        }

        public double Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public Student()
        {
            this.mark = 0;
            this.subjects = 0;
        }

        public Student(double marks, double subjects)
        {
            this.mark = marks;
            this.subjects = subjects;
        }

        public void student_grades()
        {
            double GPA = this.mark / this.subjects;
            Console.WriteLine("\nGRADES:");
            Console.WriteLine($"{Last_name}, {First_name} : {GPA:F2}");
        }
    }

    public class Worker : Human
    {
        private double wage, hours_worked;
        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public double Hours_worked
        {
            get { return hours_worked; }
            set { hours_worked = value; }
        }

        public Worker()
        {
            this.wage = 0;
            this.hours_worked = 0;
        }

        public Worker(double wage, double hours_worked)
        {
            this.wage = wage;
            this.hours_worked = hours_worked;
        }
        public void hourly_wage()
        {
            Console.WriteLine("\nHOURLY WAGE:");
            double rate = this.wage / this.hours_worked;
            Console.WriteLine($"{Last_name}, {First_name}: ${rate:F2}");
        }
    }
}