using System;

namespace progression
{   
    class ArithmeticProgression
    {
        private double a0;
        private double b;

        public double Nmember(uint n)
        {
            return a0 + b * (n - 1);
        }

        public double Nsum(uint n)
        {
            return (a0 + Nmember(n)) * n / 2;
        }

        public void SetInitial(double init)
        {
            a0 = init;
        }

        public void SetDiff(double diff)
        {
            b = diff;
        }

        public double GetInitial()
        {
            return a0;
        }

        public double GetDiff()
        {
            return b;
        }
    }
    class CreateProgression
    {
        static void Main(string[] args)
        {
            ArithmeticProgression prog = CreateArithmeticProgression();
            Console.WriteLine("Enter number of searching term ");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("{0} term of the progression is {1}", n, prog.Nmember(n));
            Console.WriteLine("Sum of {0} terms of the progression is {1}", n, prog.Nsum(n));
        }

        private static ArithmeticProgression CreateArithmeticProgression()
        {
            ArithmeticProgression prog = new ArithmeticProgression();
            Console.WriteLine("Enter initial term of progression: ");
            prog.SetInitial(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter difference of progression: ");
            prog.SetDiff(double.Parse(Console.ReadLine()));

            return prog;
        }
    }
}
