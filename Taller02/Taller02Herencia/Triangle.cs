namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            private set => _c = ValidateC(value);
        }

        public double H
        {
            get => _h;
            private set => _h = ValidateH(value);
        }

        public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea()
        {
            return (A * H) / 2;
        }

        private static double ValidateC(double c)
        {
            return c > 0 ? c : throw new ArgumentException("Side C must be positive.");
        }

        private static double ValidateH(double h)
        {
            return h > 0 ? h : throw new ArgumentException("Height H must be positive.");
        }
    }
}