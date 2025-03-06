namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double r; // Radio del círculo

        // Constructor
        public Circle(double r)
        {
            Nombre = "circle";
            this.r = r;
            ValidateR();
        }

        // Propiedad para el radio 'r'
        public double R
        {
            get { return r; }
            set
            {
                r = value;
                ValidateR();
            }
        }

        // Método para validar el radio 'r'
        private void ValidateR()
        {
            if (r <= 0)
            {
                throw new ArgumentException("El radio 'r' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return Math.PI * r * r;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}