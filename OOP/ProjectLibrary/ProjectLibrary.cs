using System;
using System.Drawing;

namespace ProjectLibrary
{
    public class Figure // Base figure class
    {
        public int xStart, yStart, x2, y2, lineWidth;
        public Color color;
        public Point Position;

        public virtual void Draw(IRenderer ir)
        {
            // Draw Something. Will be overridden for each figure
        }

        public virtual void Rotate(IRenderer ir, float angle)
        {
            // Rotate the figure
        }
    }
}
