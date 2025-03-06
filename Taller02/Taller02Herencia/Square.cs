namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double a; // Lado del cuadrado

        // Constructor
        public Square(double a)
        {
            Nombre = "square";
            this.a = a;
            ValidateA();
        }

        // Propiedad para el lado 'a'
        public double A
        {
            get { return a; }
            set
            {
                a = value;
                ValidateA();
            }
        }

        // Método para validar el lado 'a'
        private void ValidateA()
        {
            if (a <= 0)
            {
                throw new ArgumentException("El lado 'a' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return a * a;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            return 4 * a;
        }
    }
}