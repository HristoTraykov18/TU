using System.Drawing;

namespace ProjectLibrary
{
    public class Triangle : Figure, IDrawable
    {
        public Point Position { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public Color color { get; set; }
        public int lineWidth { get; set; }
        public bool filled;

        public Triangle(Point p, int x2, int y2, int x3, int y3, Color c, int lW, bool fill)
        {
            Position = p;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            color = c;
            lineWidth = lW;
            filled = fill;
        }

        public override void Draw(IRenderer ir)
        {
            ir.DrawTriangle(Position.X, Position.Y, x2, y2, x3, y3, color, lineWidth, filled);
        }
    }
}
