namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            private set => _h = ValidateH(value);
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea()
        {
            return A * H;
        }

        private static double ValidateH(double h)
        {
            return h > 0 ? h : throw new ArgumentException("Height H must be positive.");
        }
    }
}
