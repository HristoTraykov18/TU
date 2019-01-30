using System;
using ProjectLibrary;
using System.Drawing;

namespace ProjectLibrary
{
    [Serializable]
    public abstract class BaseFigure : IDrawable // Base figure class
    {
        public Color color;
        public Point Position;
        public int width, height;
        public int index;
        public bool filled;

        public BaseFigure()
        {
            Position = new Point(0, 0);
            width = 0;
            height = 0;
            index = 0;
            color = Color.Transparent;
            filled = false;
        }


        public BaseFigure(Point p, int w, int h, Color c, int i, bool fill)
        {
            Position = p;
            width = w;
            height = h;
            index = i;
            color = c;
            filled = fill;
        }
        

        public virtual void ClearFill() { filled = false; }

        public virtual void ColorChange(Color color) { this.color = color; }

        public virtual void Draw(IRenderer ir)
        {
            // Draw Something. Will be overridden for each figure
        }

        public virtual void Fill() { filled = true; }

        public virtual bool IsClicked(Point mPosition)
        {
            return (mPosition.X >= Position.X && mPosition.X <= Position.X + width &&
                    mPosition.Y >= Position.Y && mPosition.Y <= Position.Y + height);
        }

        public virtual bool IsNotInBounds(int xStart, int yStart, int width, int height)
        {
            return xStart + width > 800 || xStart + width < 0 || 
                   yStart + height > 600 || yStart + height < 90;
        }

        public virtual void Rotate(IRenderer ir)
        {
            // Rotate the clicked figure 90 degrees
        }
    }
}
