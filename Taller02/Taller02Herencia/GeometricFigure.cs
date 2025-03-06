using System;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Nombre { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Nombre} => Area...: {GetArea():F5} Perimeter: {GetPerimeter():F5}";
        }
    }

    public class Circle : GeometricFigure
    {
        private double r; // Radio del círculo

        // Constructor
        public Circle(string nombre, double r = 5) // Valor predeterminado para el radio
        {
            Nombre = nombre;
            this.r = r;
            ValidateR();
        }

        // ... (resto del código de Circle) ...
    }

    public class Square : GeometricFigure
    {
        private double lado;

        public Square(string nombre, double lado = 10) // Valor predeterminado para el lado
        {
            Nombre = nombre;
            this.lado = lado;
            ValidateLado();
        }

        // ... (resto del código de Square) ...
    }

    public class Rhombus : GeometricFigure
    {
        private double d1; // Diagonal mayor
        private double d2; // Diagonal menor

        public Rhombus(string nombre, double d1 = 10, double d2 = 7) // Valores predeterminados para las diagonales
        {
            Nombre = nombre;
            this.d1 = d1;
            this.d2 = d2;
            ValidateD1();
            ValidateD2();
        }

        // ... (resto del código de Rhombus) ...
    }

    public class Kite : Rhombus
    {
        private double b; // Lado corto

        public Kite(string nombre, double d1 = 6, double d2 = 5, double b = 8) : base(nombre, d1, d2)
        {
            Nombre = nombre;
            this.b = b;
            ValidateB();
        }

        // ... (resto del código de Kite) ...
    }

    public class Rectangle : Square
    {
        private double b; // Ancho del rectángulo

        public Rectangle(string nombre, double lado = 17.7, double b = 17.5) : base(nombre, lado)
        {
            Nombre = nombre;
            this.b = b;
            ValidateB();
        }

        // ... (resto del código de Rectangle) ...
    }

    public class Parallelogram : Rectangle
    {
        private double h; // Altura del paralelogramo

        public Parallelogram(string nombre, double lado = 35.8, double b = 35.3, double h = 35.4) : base(nombre, lado, b)
        {
            Nombre = nombre;
            this.h = h;
            ValidateH();
        }

        // ... (resto del código de Parallelogram) ...
    }

    public class Triangle : Rectangle
    {
        private double c; // Lado C del triángulo
        private double h; // Altura del triángulo

        public Triangle(string nombre, double lado = 15, double b = 12.34, double c = 57.65, double h = 12.34) : base(nombre, lado, b)
        {
            Nombre = nombre;
            this.c = c;
            this.h = h;
            ValidateC();
            ValidateH();
        }

        // ... (resto del código de Triangle) ...
    }

    public class Trapeze : Triangle
    {
        private double d; // Base mayor del trapecio

        public Trapeze(string nombre, double lado = 100, double b = 100, double c = 100, double h = 80, double d = 100) : base(nombre, lado, b, c, h)
        {
            Nombre = nombre;
            this.d = d;
            ValidateD();
        }

        // ... (resto del código de Trapeze) ...
    }
}