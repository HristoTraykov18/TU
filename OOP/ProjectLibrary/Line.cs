using System.Drawing;

namespace ProjectLibrary
{
    public class Line : Figure, IDrawable
    {
        public Point Position { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public Color color { get; set; }
        public int lineWidth { get; set; }

        public Line(Point p, int xEnd, int yEnd, Color c, int lW) // Constructor
        {
            Position = p;
            x2 = xEnd;
            y2 = yEnd;
            color = c;
            lineWidth = lW;
        }

        public override void Draw(IRenderer ir)
        {
            ir.DrawLine(Position.X, Position.Y, x2, y2, color, lineWidth);
        }

        public override void Rotate(IRenderer ir, float angle)
        {
            ir.RotateTransform(90.0f);
        }
    }
}
