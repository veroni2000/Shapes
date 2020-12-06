using System;
using System.Drawing;
using System.Linq;

namespace Shapes
{
    [Serializable]
    public class Triangle : Shape
    {
        public Triangle(int s1, int s2, int s3)
        {
            Sides = new int[] { s1, s2, s3 };
        }
        private int[] sides;
        public int[] Sides
        {
            get { return sides; }
            set
            {
                if (value[0] <= 0 || value[1] <= 0 || value[2] <= 0)
                {
                    throw new ArgumentException("Sides must be greater than 0.");
                }
                else sides = value;
            }
        }
        public Point[] Points { get; set; }
        private static bool PointUnderLine(Point p, Point p1, Point p2)
        {
            var x = p.X;
            var y = p.Y;
            var x1 = p1.X;
            var x2 = p2.X;
            var y1 = p1.Y;
            var y2 = p2.Y;

            var d = (x - x1) * (y2 - y1) - (y - y1) * (x2 - x1);

            if (x2 < x1)
                d = -d;

            if (d > 0)
                return false;

            return true;
        }
        public override bool Contains(Point point)
        {
            if (PointUnderLine(Points[0], Points[1], Points[2]))
            {
                if (PointUnderLine(Points[1], Points[0], Points[2]))
                    return !PointUnderLine(point, Points[0], Points[1]) &&
                        PointUnderLine(point, Points[1], Points[2]) &&
                        PointUnderLine(point, Points[2], Points[0]);
                else
                {
                    return !PointUnderLine(point, Points[0], Points[1]) &&
                        PointUnderLine(point, Points[1], Points[2]) &&
                        !PointUnderLine(point, Points[2], Points[0]);
                }
            }
            else
            {
                return !PointUnderLine(point, Points[0], Points[1]) &&
                    !PointUnderLine(point, Points[1], Points[2]) &&
                    PointUnderLine(point, Points[2], Points[0]);
            }
        }
        public override double CalculatePerimeter()
        {
            return Sides.Sum();
        }
        public override double CalculateSurface()
        {
            var p = CalculatePerimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2])), 2);
        }
        public override string ToString()
        {
            return string.Format("Selected figure is Triangle with sides {0}, {1} and {2}.\n" +
                "Surface = {3}, Perimeter = {4}",
                Sides[0], Sides[1], Sides[2], CalculateSurface(), CalculatePerimeter());
        }
    }
}
