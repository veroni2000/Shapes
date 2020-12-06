using System;
using System.Drawing;

namespace Shapes
{
    [Serializable]
    public class Circle : Shape
    {
        public Circle(int rad)
        {
            Radius = rad;
        }
        private float radius;
        public float Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than 0.");
                }
                else radius = value;
            }
        }
        public override bool Contains(Point point)
        {
            return (point.X - Location.X) * (point.X - Location.X) +
            (point.Y - Location.Y) * (point.Y - Location.Y) <= Radius * Radius;
        }
        public override double CalculateSurface()
        {
            return Math.Round(Math.PI * Radius * Radius, 2);
        }
        public override double CalculatePerimeter()
        {
            return Math.Round(Math.PI * 2 * Radius, 2);
        }
        public override string ToString()
        {
            return string.Format("Selected figure is Circle with radius {0}.\n" +
                "Surface = {1}, Perimeter = {2}",
                Radius, CalculateSurface(), CalculatePerimeter());
        }
    }
}
