using System;

namespace progression
{   
    class ArithmeticProgression
    {
        private double a0;
        private double b;
        private uint n;

        public double Nmember()
        {
            return a0 + b * (n - 1);
        }

        public double Nsum()
        {
            return (a0 + Nmember()) * n / 2;
        }

        public void SetInitial(double init)
        {
            a0 = init;
        }

        public void SetDiff(double diff)
        {
            b = diff;
        }

        public void SetN(uint number)
        {
            if (n != 0)
                n = number;
            else
            {
                Console.WriteLine("n should be more than 0");
                n = 1;
            }
        }

        public double GetInitial()
        {
            return a0;
        }

        public double GetDiff()
        {
            return b;
        }

        public double GetN()
        {
            return n;
        }
    }
    class CreateProgression
    {
        static void Main(string[] args)
        {
            try
            {
                ArithmeticProgression prog = CreateArithmeticProgression();
                Console.WriteLine("Searched term of progression is {0}", prog.Nmember());
                Console.WriteLine("Sum of {0} terms of the progression is {0}", prog.GetN(), prog.Nsum());
            }
            catch (OverflowException)
            {
                Console.WriteLine("n should be positive");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers");
            }
           
        }

        private static ArithmeticProgression CreateArithmeticProgression()
        {
            ArithmeticProgression prog = new ArithmeticProgression();
            Console.WriteLine("Enter initial term of progression: ");
            prog.SetInitial(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter difference of progression: ");
            prog.SetDiff(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter number of searching term of the progression");
            prog.SetN(uint.Parse(Console.ReadLine()));

            return prog;
        }
    }
}
