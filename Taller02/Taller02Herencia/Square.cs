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
            return double.Parse($"{A * A,15:F5}");
        }

        public override double GetPerimeter()
        {
            return double.Parse($"{4 * A,15:F5}");
        }

        private static double ValidateA(double a)
        {
            return a > 0 ? a : throw new ArgumentException("Side A must be positive.");
        }
       
    }
}

