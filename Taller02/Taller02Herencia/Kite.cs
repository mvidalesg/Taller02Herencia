namespace Geometry
{
    public class Kite : Rhombus
    {
        private double _b;

        public double B
        {
            get => _b;
            private set => _b = ValidateB(value);
        }

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            B = b;
        }

        public override double GetArea()
        {
            return double.Parse($"{(D1 * D2) / 2,15:F5}");
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