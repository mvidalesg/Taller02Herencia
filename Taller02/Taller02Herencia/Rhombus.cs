namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            private set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            private set => _d2 = ValidateD2(value);
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private static double ValidateD1(double d1)
        {
            return d1 > 0 ? d1 : throw new ArgumentException("Diagonal D1 must be positive.");
        }

        private static double ValidateD2(double d2)
        {
            return d2 > 0 ? d2 : throw new ArgumentException("Diagonal D2 must be positive.");
        }
       
    }
}
