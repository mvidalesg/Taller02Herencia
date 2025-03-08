namespace Geometry
{
    public class Rectangle : Square
    {
        private double _b;

        public double B
        {
            get => _b;
            private set => _b = ValidateB(value);
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        public override double GetArea()
        {
            return double.Parse($"{A * B,15:F5}");
        }

        public override double GetPerimeter()
        {
            return double.Parse($"{2 * (A + B),15:F5}");
        }

        private static double ValidateB(double b)
        {
            return b > 0 ? b : throw new ArgumentException("Side B must be positive.");
        }
        
    }
}
