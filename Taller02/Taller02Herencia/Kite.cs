using System;

namespace Geometry
{
    public class Rhombus : GeometricFigure
    {
        protected double d1; // Diagonal mayor
        protected double d2; // Diagonal menor

        // Constructor
        public Rhombus(double d1, double d2)
        {
            Nombre = "rhombus";
            this.d1 = d1;
            this.d2 = d2;
            ValidateD1();
            ValidateD2();
        }

        // Propiedad para la diagonal mayor 'd1'
        public double D1
        {
            get { return d1; }
            set
            {
                d1 = value;
                ValidateD1();
            }
        }

        // Propiedad para la diagonal menor 'd2'
        public double D2
        {
            get { return d2; }
            set
            {
                d2 = value;
                ValidateD2();
            }
        }

        // Método para validar la diagonal mayor 'd1'
        protected void ValidateD1()
        {
            if (d1 <= 0)
            {
                throw new ArgumentException("La diagonal mayor 'd1' debe ser mayor que cero.");
            }
        }

        // Método para validar la diagonal menor 'd2'
        protected void ValidateD2()
        {
            if (d2 <= 0)
            {
                throw new ArgumentException("La diagonal menor 'd2' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return (d1 * d2) / 2;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            // Calcula el lado del rombo usando el teorema de Pitágoras
            double lado = Math.Sqrt((d1 * d1 / 4) + (d2 * d2 / 4));
            return 4 * lado;
        }
    }

    public class Kite : Rhombus
    {
        private double b; // Lado corto

        // Constructor
        public Kite(double d1, double d2, double b) : base(d1, d2)
        {
            Nombre = "kite";
            this.b = b;
            ValidateB();
        }

        // Propiedad para el lado corto 'b'
        public double B
        {
            get { return b; }
            set
            {
                b = value;
                ValidateB();
            }
        }

        // Método para validar el lado corto 'b'
        private void ValidateB()
        {
            if (b <= 0)
            {
                throw new ArgumentException("El lado corto 'b' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return (d1 * d2) / 2;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            // Calcula el lado largo 'a' usando el teorema de Pitágoras
            double a = Math.Sqrt((d1 * d1 / 4) + (d2 * d2 / 4));
            return 2 * (a + b);
        }
    }
}