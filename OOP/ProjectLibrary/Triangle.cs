using System;
using System.Drawing;

namespace ProjectLibrary
{
    public class Triangle : BaseFigure
    {
        public Point Position { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int index { get; set; }
        public Color color { get; set; }
        public bool filled { get; set; }
        
        public Triangle(Point p, int w, int h, int i, Color c, bool fill)
        {
            Position = p;
            width = w;
            height = h;
            index = i;
            color = c;
            filled = fill;
        }

        public override void ClearFill() { filled = false; }

        public override void ColorChange(Color color) { this.color = color; }

        public override void Draw(IRenderer ir)
        {
            ir.DrawTriangle(Position.X, Position.Y, width, height, index, color, filled);
        }

        public override void Fill() { filled = true; }

        public override bool IsClicked(Point mPosition)
        {
            return ((mPosition.X >= Position.X && mPosition.X <= Position.X + width &&
                    mPosition.Y >= Position.Y && mPosition.Y <= Position.Y + height) ||

                    (mPosition.X <= Position.X && mPosition.X >= Position.X + width &&
                    mPosition.Y >= Position.Y && mPosition.Y <= Position.Y + height) ||

                    (mPosition.X <= Position.X && mPosition.X >= Position.X + width &&
                    mPosition.Y <= Position.Y && mPosition.Y >= Position.Y + height) ||

                    (mPosition.X >= Position.X && mPosition.X <= Position.X + width &&
                    mPosition.Y <= Position.Y && mPosition.Y >= Position.Y + height));
        }

        public override void Rotate(IRenderer ir)
        {
            if ((width > 0 && height > 0) || (width < 0 && height < 0))
            {
                Position = new Point(Position.X + width, Position.Y);
                int temp = height;
                height  = width;
                width = -temp;
            }
            else if ((width < 0 && height > 0) || (width > 0 && height < 0))
            {
                Position = new Point(Position.X, Position.Y + height);
                int temp = width;
                width = -height;
                height = temp;
            }

            ir.DrawTriangle(Position.X, Position.Y, width, height, index, color, filled);
        }
    }
}
