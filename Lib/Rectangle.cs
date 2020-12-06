using System;
using System.Drawing;

namespace Shapes
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }
        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }
        protected int width, height;
        public int Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than 0.");
                }
                else width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than 0.");
                }
                else height = value;
            }
        }
        public override bool Contains(Point point)
        {
            return
                Location.X < point.X && point.X < Location.X + Width &&
                Location.Y < point.Y && point.Y < Location.Y + Height;
        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
        public override string ToString()
        {
            return string.Format("Selected figure is Rectangle with sides {0} and {1}.\n" +
                "Surface = {2}, Perimeter = {3}",
                Width, Height, CalculateSurface(), CalculatePerimeter());
        }
    }
}
