namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name} => Area.....: {GetArea(),15:F5}\t Perimeter: {GetPerimeter(),15:F5}";
        }
    }
}
