namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            private set => _d = ValidateD(value);
        }

        public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private static double ValidateD(double d)
        {
            return d > 0 ? d : throw new ArgumentException("Side D must be positive.");
        }
        public override string ToString()
        {
            return $"{GetType().Name,-15} => Area: {GetArea(),10:F5}  Perimeter: {GetPerimeter(),10:F5}";
        }

    }
}
