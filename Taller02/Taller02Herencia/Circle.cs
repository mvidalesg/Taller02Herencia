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
            return double.Parse($"{Math.PI * R * R,15:N5}");
        }

        public override double GetPerimeter()
        {
            return double.Parse($"{2 * Math.PI * R,15:N5}");
        }

        private static double ValidateR(double r)
        {
            return r > 0 ? r : throw new ArgumentException("Radius must be positive.");
        }
       

    }
}

