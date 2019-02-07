using System;

namespace BisectionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BisectionPt1 pt1 = new BisectionPt1();
            Console.WriteLine(pt1.FindRoot(6, 7, 0.000001, 100));

            BisectionPt2 pt2 = new BisectionPt2();
            Console.WriteLine(pt2.FindRoot(0, 1, 0.000001, 100));

            BisectionPt4A pt4A = new BisectionPt4A();
            Console.WriteLine(pt4A.FindRoot(-1, 1, 0.001, 100));

            BisectionPt4B pt4B = new BisectionPt4B();
            Console.WriteLine(pt4B.FindRoot(0, 1, 0.001, 100));

            Console.ReadLine();
        }
    }

    class BisectionPt1
    {
        public string FindRoot(double a, double b, double TOL, int NMax)
        {
            Tuple<double, double> Interval = new Tuple<double, double>(a, b);

            double solutionA = EquationA(a);

            double solutionB = EquationA(b);

            //checking that a and b have opposite signs
            if (Math.Sign(solutionA) == Math.Sign(solutionB))
            {
                return "Same Sign";

            }

            int n = 1;
            double c = 0;
            double solution = 0;
            while (n <= NMax)
            {
                c = (a + b) / 2;
                solution = EquationA(c);

                if (((b - a) / 2 < TOL) || solution == 0)
                {
                    return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
                }

                n++;

                if (Math.Sign(EquationA(c)) == Math.Sign(EquationA(a)))
                {
                    a = c;
                }
                else
                {
                    b = c;
                }

            }

            return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
        }

        private static double EquationA(double c)
        {
            double solution = Math.Cos(c);

            solution = solution * solution + 6 - c;
            return solution;
        }

    }

    class BisectionPt2
    {
        public string FindRoot(double a, double b, double TOL, int NMax)
        {
            Tuple<double, double> Interval = new Tuple<double, double>(a, b);

            double solutionA = EquationB(a);

            double solutionB = EquationB(b);

            //checking that a and b have opposite signs
            if (Math.Sign(solutionA) == Math.Sign(solutionB))
            {
                return "Same Sign";
            }

            int n = 1;
            double c = 0;
            double solution = 0;

            while (n <= NMax)
            {
                c = (a + b) / 2;
                solution = EquationB(c);

                if (((b - a) / 2 < TOL) || solution == 0)
                {
                    return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
                }

                n++;

                if (Math.Sign(EquationB(c)) == Math.Sign(EquationB(a)))
                {
                    a = c;
                }
                else
                {
                    b = c;
                }

            }

            return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
        }

        private static double EquationB(double c)
        {
            // 1 + 5x - 6x^3 - e^2x
            double solution = 1 + (5 * c) - (6 * (Math.Pow(c, 3)) ) - (Math.Exp(2 * c));
            return solution;
        }

    }

    class BisectionPt4A
    {
        public string FindRoot(double a, double b, double TOL, int NMax)
        {
            Tuple<double, double> Interval = new Tuple<double, double>(a, b);

            double solutionA = EquationD(a);

            double solutionB = EquationD(b);

            //checking that a and b have opposite signs
            if (Math.Sign(solutionA) == Math.Sign(solutionB))
            {
                return "Same Sign";
            }

            int n = 1;
            double c = 0;
            double solution = 0;

            while (n <= NMax)
            {
                c = (a + b) / 2;
                solution = EquationD(c);

                if (((b - a) / 2 < TOL) || solution == 0)
                {
                    return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
                }

                n++;

                if (Math.Sign(EquationD(c)) == Math.Sign(EquationD(a)))
                {
                    a = c;
                }
                else
                {
                    b = c;
                }

            }

            return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
        }

        private static double EquationD(double c)
        {
            // sin x
            double solution = Math.Sin(c);
            return solution;
        }

    }

    class BisectionPt4B
    {
        public string FindRoot(double a, double b, double TOL, int NMax)
        {

            Tuple<double, double> Interval = new Tuple<double, double>(a, b);

            double solutionA = EquationD(a);

            double solutionB = EquationD(b);

            //checking that a and b have opposite signs
            if (Math.Sign(solutionA) == Math.Sign(solutionB))
            {
                return "Same Sign";
            }

            int n = 1;
            double c = 0;
            double solution = 0;

            while (n <= NMax)
            {
                c = (a + b) / 2;
                solution = EquationD(c);

                if (((b - a) / 2 < TOL) || solution == 0)
                {
                    return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}",
                                  Interval.Item1, Interval.Item2, a, b, c, n);
                }

                n++;

                if (Math.Sign(EquationD(c)) == Math.Sign(EquationD(a)))
                {
                    a = c;
                }
                else
                {
                    b = c;
                }

            }

            return String.Format("Starting Interval [{0}, {1}], Final Interval [{2}, {3}], Solution: {4}, Iterations: {5}", 
                                  Interval.Item1, Interval.Item2, a, b, c, n);
        }

        private static double EquationD(double c)
        {
            // 5 - 6x 
            double solution = 5 - (6 * c);
            return solution;
        }

    }


}
