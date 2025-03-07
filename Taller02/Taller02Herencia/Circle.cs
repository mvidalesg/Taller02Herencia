namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            private set => _r = ValidateR(value);
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private static double ValidateR(double r)
        {
            return r > 0 ? r : throw new ArgumentException("Radius must be positive.");
        }
    }
}

