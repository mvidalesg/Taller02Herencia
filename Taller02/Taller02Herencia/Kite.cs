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
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private static double ValidateB(double b)
        {
            return b > 0 ? b : throw new ArgumentException("Side B must be positive.");
        }
        public override string ToString()
        {
            return $"{GetType().Name,-15} => Area: {GetArea(),10:F5}  Perimeter: {GetPerimeter(),10:F5}";
        }

    }
}