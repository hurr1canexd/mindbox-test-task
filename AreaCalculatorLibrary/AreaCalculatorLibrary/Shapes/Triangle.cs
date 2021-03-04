using System;

namespace AreaCalculatorLibrary
{
    public class Triangle : Shape
    {
        private const double eps = 1e-10;

        private double _a, _b, _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Side length can't be negative.");
            }

            if (a + b <= c || b + c <= a || a + c <= b)
            {
                throw new ArgumentException("The sum of the two sides of a triangle must always be greater than the third side");
            }

            _a = a;
            _b = b;
            _c = c;
        }

        public override double GetArea()
        {
            double p = (_a + _b + _c) / 2; // semi-perimeter
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRight()
        {
            return IsPythagorean(_a, _b, _c) || IsPythagorean(_c, _a, _b) || IsPythagorean(_b, _c, _a);

            static bool IsPythagorean(double a, double b, double c)
            {
                return Math.Abs(a * a + b * b - c * c) < eps;
            }
        }


    }
}
