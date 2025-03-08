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

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea()
        {
            return double.Parse($"{((B + D) * H) / 2,15:N5}");
        }

        public override double GetPerimeter()
        {
            return double.Parse($"{A + B + C + D,10:N5}");
        }

        private static double ValidateD(double d)
        {
            return d > 0 ? d : throw new ArgumentException("Side D must be positive.");
        }
        

    }
}
