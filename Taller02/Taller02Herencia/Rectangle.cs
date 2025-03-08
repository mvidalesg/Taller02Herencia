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
            return A * B;
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
