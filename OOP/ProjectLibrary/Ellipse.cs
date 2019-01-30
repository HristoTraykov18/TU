using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ProjectLibrary
{
    [Serializable]
    public class Ellipse : BaseFigure
    {
        public Point Position { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int index { get; set; }
        public Color color { get; set; }
        public bool filled { get; set; }

        public Ellipse(Point p, int w, int h, int i, Color c, bool fill)
        {
            Position = p;
            width = w;
            height = h;
            index = i;
            color = c;
            filled = fill;
        }

        public override void ClearFill() { filled = false; }

        public override void ColorChange(Color color) { this.color = color;  }

        public override void Draw(IRenderer ir)
        {
            ir.DrawEllipse(Position.X, Position.Y, width, height, index, color, filled);
        }

        public override void Fill() { filled = true; }

        public override bool IsClicked(Point mPosition)
        {
            return (mPosition.X >= Position.X && mPosition.X <= Position.X + width &&
                    mPosition.Y >= Position.Y && mPosition.Y <= Position.Y + height);
        }

        public override void Rotate(IRenderer ir)
        {
            int temp = height;
            height = width;
            width = temp;

            if (IsNotInBounds(Position.X, Position.Y, width, height))
            {
                if (Position.X + width >= 800)
                    Position = new Point(750 - Math.Abs(width), Position.Y);
                if (Position.Y + height >= 600)
                    Position = new Point(Position.X, 500 - Math.Abs(height));
            }

            ir.DrawEllipse(Position.X, Position.Y, width, height, index, color, filled);
        }
    }
}
