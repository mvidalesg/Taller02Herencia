using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Geometry
{
    public class Square : GeometricFigure
    {
        protected double lado;

        public Square(double lado)
        {
            Nombre = "square";
            this.lado = lado;
            ValidateLado();
        }

        public double Lado
        {
            get { return lado; }
            set
            {
                lado = value;
                ValidateLado();
            }
        }

        protected void ValidateLado()
        {
            if (lado <= 0)
            {
                throw new ArgumentException("El lado debe ser mayor que cero.");
            }
        }

        public override double GetArea()
        {
            return lado * lado;
        }

        public override double GetPerimeter()
        {
            return 4 * lado;
        }
    }

    public class Rhombus : Square
    {
        private double d1; // Diagonal mayor
        private double d2; // Diagonal menor

        // Constructor
        public Rhombus(double d1, double d2) : base(Math.Sqrt((d1 * d1 / 2) + (d2 * d2 / 2)))
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
        private void ValidateD1()
        {
            if (d1 <= 0)
            {
                throw new ArgumentException("La diagonal mayor 'd1' debe ser mayor que cero.");
            }
        }

        // Método para validar la diagonal menor 'd2'
        private void ValidateD2()
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
            return 4 * Lado;
        }
    }
}