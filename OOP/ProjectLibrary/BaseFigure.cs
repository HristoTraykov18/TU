using System;
using ProjectLibrary;
using System.Drawing;

namespace ProjectLibrary
{
    [Serializable]
    public class BaseFigure : IDrawable // Base figure class
    {
        public Color color;
        public Point Position;
        public int width, height, index;

        public virtual void Draw(IRenderer ir)
        {
            // Draw Something. Will be overridden for each figure
        }

        public virtual void Rotate(IRenderer ir)
        {
            // Rotate the clicked figure 90 degrees
        }

        public virtual bool IsClicked(Point mPosition)
        {
            return false;
        }
    }
}
