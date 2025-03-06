﻿using System;

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

    public class Rectangle : Square
    {
        private double b; // Ancho del rectángulo

        // Constructor
        public Rectangle(double lado, double b) : base(lado)
        {
            Nombre = "rectangle";
            this.b = b;
            ValidateB();
        }

        // Propiedad para el ancho 'b'
        public double B
        {
            get { return b; }
            set
            {
                b = value;
                ValidateB();
            }
        }

        // Método para validar el ancho 'b'
        private void ValidateB()
        {
            if (b <= 0)
            {
                throw new ArgumentException("El ancho 'b' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return lado * b;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            return 2 * (lado + b);
        }
    }

    public class Triangle : Rectangle
    {
        private double c; // Lado C del triángulo
        private double h; // Altura del triángulo

        // Constructor
        public Triangle(double lado, double b, double c, double h) : base(lado, b)
        {
            Nombre = "triangle";
            this.c = c;
            this.h = h;
            ValidateC();
            ValidateH();
        }

        // Propiedad para el lado 'c'
        public double C
        {
            get { return c; }
            set
            {
                c = value;
                ValidateC();
            }
        }

        // Propiedad para la altura 'h'
        public double H
        {
            get { return h; }
            set
            {
                h = value;
                ValidateH();
            }
        }

        // Método para validar el lado 'c'
        private void ValidateC()
        {
            if (c <= 0)
            {
                throw new ArgumentException("El lado 'c' debe ser mayor que cero.");
            }
        }

        // Método para validar la altura 'h'
        private void ValidateH()
        {
            if (h <= 0)
            {
                throw new ArgumentException("La altura 'h' debe ser mayor que cero.");
            }
        }

        // Implementación del método abstracto GetArea()
        public override double GetArea()
        {
            return (lado * h) / 2;
        }

        // Implementación del método abstracto GetPerimeter()
        public override double GetPerimeter()
        {
            return lado + b + c;
        }
    }
}