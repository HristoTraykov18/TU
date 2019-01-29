using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ProjectLibrary
{
    class Circle : BaseFigure
    {
        public Point Position { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int index { get; set; }
        public Color color { get; set; }
        public bool filled { get; set; }

        public Circle(Point p, int w, int h, int i, Color c, bool fill)
        {
            Position = p;
            width = w;
            height = h;
            index = i;
            color = c;
            filled = fill;
        }

        public override void Draw(IRenderer ir)
        {
            ir.DrawCircle(Position.X, Position.Y, width, height, index, color, filled);
        }

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

            ir.DrawCircle(Position.X, Position.Y, width, height, index, color, filled);
        }
    }
}
