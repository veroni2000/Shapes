using System;

namespace Shapes
{
    [Serializable]
    public class Square : Rectangle
    {
        public Square(int w)
        {
            Width = w;
            Height = w;
        }
        public new int Height
        {
            get { return height; }
            set
            {
                if (value != Width)
                {
                    throw new ArgumentException("A square must have equal sides.");
                }
                else height = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Selected figure is Square with side {0}.\n" +
                " Surface = {1}, Perimeter = {2}",
                Width, CalculateSurface(), CalculatePerimeter());
        }
    }
}
