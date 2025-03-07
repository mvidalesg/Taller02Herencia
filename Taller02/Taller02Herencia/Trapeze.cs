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
            return ((A + D) * H) / 2;
        }

        private static double ValidateD(double d)
        {
            return d > 0 ? d : throw new ArgumentException("Base D must be positive.");
        }
    }
}
