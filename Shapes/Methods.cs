using System;
using System.Drawing;

namespace Shapes
{
    public class Methods
    {
        public static void DrawShape(Shape shape, Graphics graphics)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                using (var pen = new Pen(shape.Color, 3))
                {
                    graphics.DrawRectangle(pen, rectangle.Location.X, rectangle.Location.Y,
                        rectangle.Width, rectangle.Height);
                }

                using (var brush = new SolidBrush(Color.FromArgb(Math.Min(byte.MaxValue, rectangle.Color.R + 100),
                    Math.Min(byte.MaxValue, rectangle.Color.G + 100),
                    Math.Min(byte.MaxValue, rectangle.Color.B + 100))))
                {
                    graphics.FillRectangle(brush, rectangle.Location.X, rectangle.Location.Y,
                        rectangle.Width, rectangle.Height);
                }
            }
            else if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                using (var pen = new Pen(circle.Color, 3))
                {
                    graphics.DrawEllipse(pen, circle.Location.X - circle.Radius,
                        circle.Location.Y - circle.Radius,
                        circle.Radius * 2, circle.Radius * 2);
                }

                using (var brush = new SolidBrush(Color.FromArgb(Math.Min(byte.MaxValue, circle.Color.R + 100),
                    Math.Min(byte.MaxValue, circle.Color.G + 100),
                    Math.Min(byte.MaxValue, circle.Color.B + 100))))
                {
                    graphics.FillEllipse(brush, circle.Location.X - circle.Radius,
                        circle.Location.Y - circle.Radius,
                        circle.Radius * 2, circle.Radius * 2);
                }
            }
            else if (shape is Triangle)
            {
                Triangle triangle = (Triangle)shape;
                triangle.Points = new Point[3];
                triangle.Points[0] = triangle.Location;
                triangle.Points[1] = new Point(triangle.Location.X + triangle.Sides[0], triangle.Location.Y);
                var x = (triangle.Sides[0] * triangle.Sides[0]
                    + triangle.Sides[2] * triangle.Sides[2]
                    - triangle.Sides[1] * triangle.Sides[1]) / (2 * triangle.Sides[0]);
                var y = Math.Sqrt(triangle.Sides[2] * triangle.Sides[2] - x * x);
                triangle.Points[2] = new Point(x + triangle.Location.X, triangle.Location.Y - (int)y);

                using (var pen = new Pen(triangle.Color, 3))
                {
                    graphics.DrawPolygon(pen, triangle.Points);
                }

                using (var brush = new SolidBrush(Color.FromArgb(Math.Min(byte.MaxValue, triangle.Color.R + 100),
                    Math.Min(byte.MaxValue, triangle.Color.G + 100),
                    Math.Min(byte.MaxValue, triangle.Color.B + 100))))
                {
                    graphics.FillPolygon(brush, triangle.Points);
                }
            }
        }
    }
}
