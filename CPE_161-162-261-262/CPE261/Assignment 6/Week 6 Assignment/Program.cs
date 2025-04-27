using System;
using System.Numerics;

namespace Week_6_Assignment
{
    //class that output the binomial probability distribution
    class BinomialProbability
    {
        static void Main(string[] args)
        {
            try
            {
                Input binomial = new Input();
                binomial.GetInput();
                binomial.DisplayBinomial();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("\nProgram terminating...");
            }
        }
    }
    //base class
    class BinomialPD
    {
        protected double p, q;
        private protected int n, x;

        protected BigInteger Combination(int n, int x)
        {
            if (n < 0 || x < 0)
                throw new Exception("You input a negative number.");
            if (x > n) return 0;
            if (x == n) return 1;

            int delta, iMax;

            if (x < n - x) 
            {
                delta = n - x; iMax = x;
            }
            else           
            {
                delta = x; iMax = n - x;
            }

            BigInteger ans = delta + 1;
            for (int i = 2; i <= iMax; ++i)
                ans = (ans * (delta + i)) / i;

            return ans;
        }

        private double CalculateProbability()
        {
            BigInteger comb = Combination(n, x);
            double prob = (double) comb * Math.Pow(p, x) * Math.Pow(q, n - x);
            return prob;
        }

        protected void DisplayResult()
        {
            double ans = CalculateProbability();
            BigInteger comb = Combination(n, x);
            Console.WriteLine($"Combination: {comb}");
            Console.WriteLine($"P(X = {x}) = {ans:F4}");
            Console.WriteLine($"Probability: {ans * 100:F2}%");
        }
    }
    //derived class of BinomialPD
    class Input : BinomialPD
    {
        public void GetInput()
        {
            Console.Write("Enter number of trials (n): ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of successes (x): ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter number of probability (p): ");
            p = double.Parse(Console.ReadLine());
            q = 1 - p;
        }

        public void DisplayBinomial()
        {
            DisplayResult();
        }
    }
}