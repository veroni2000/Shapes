using System;
using System.Drawing;

namespace Shapes
{
    [Serializable]
    public class Shape
    {
        public Point Location { get; set; }
        public Color Color { get; set; }
        public int Order { get; set; }
        public virtual bool Contains(Point point)
        {
            throw new NotImplementedException();
        }
        public virtual void Move(Point p1, Point p2)
        {
            var xChange = p2.X - p1.X;
            var yChange = p2.Y - p1.Y;
            Location = new Point(Location.X + xChange, Location.Y + yChange);
        }
        public virtual double CalculateSurface()
        {
            throw new NotImplementedException();
        }
        public virtual double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
