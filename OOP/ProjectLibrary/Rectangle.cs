using System.Drawing;

namespace ProjectLibrary
{
    public class Rectangle : Figure, IDrawable
    {
        public Point Position { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Color color { get; set; }
        public int lineWidth { get; set; }
        public bool filled { get; set; }

        public Rectangle(Point p, int w, int h, Color c, int lW, bool fill)
        {
            Position = p;
            width = w;
            height = h;
            color = c;
            lineWidth = lW;
            filled = fill;
            x2 = Position.X + width;
            y2 = Position.Y + height;
        }

        public override void Draw(IRenderer ir)
        {
            ir.DrawRect(Position.X, Position.Y, width, height, color, lineWidth, filled);
        }
    }
}
