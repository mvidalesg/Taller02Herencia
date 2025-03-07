namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            private set => _a = ValidateA(value);
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private static double ValidateA(double a)
        {
            return a > 0 ? a : throw new ArgumentException("Side A must be positive.");
        }
    }
}

