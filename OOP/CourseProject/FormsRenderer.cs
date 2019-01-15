using System.Drawing;
using ProjectLibrary;
using System.Windows.Forms;

namespace CourseProject
{
    class FormsRenderer : IRenderer // Renderer for
    {
        Form form;

        public FormsRenderer(Form form) { this.form = form; }

        public void DrawLine(int xStart, int yStart, int xEnd, int yEnd, Color c, int w)
        {
            Graphics g = form.CreateGraphics();
            using (Pen p = new Pen(c, w))
                g.DrawLine(p, xStart, yStart, xEnd, yEnd);
        }
        public void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Color c, int w, bool filled = false)
        {
            DrawLine(x1, y1, x2, y2, c, w);
            DrawLine(x2, y2, x3, y3, c, w);
            DrawLine(x3, y3, x1, y1, c, w);
            // g.FillPolygon()
        }
        public void DrawRect(int xStart, int yStart, int width, int height, Color c, int w, bool filled = false)
        {
            Graphics g = form.CreateGraphics();
            if (!filled)
            {
                using (Pen p = new Pen(c, w))
                    g.DrawRectangle(p, xStart, yStart, width, height);
            }
            else
            {
                using (SolidBrush sBr = new SolidBrush(c))
                    g.FillRectangle(sBr, xStart, yStart, width, height);
            }
        }
        public void RotateTransform(float angle)
        {
            Graphics g = form.CreateGraphics();
            g.RotateTransform(90.0f);
        }
    }
}
