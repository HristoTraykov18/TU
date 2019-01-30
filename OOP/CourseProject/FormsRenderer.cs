using System.Drawing;
using ProjectLibrary;
using System.Windows.Forms;

namespace CourseProject
{
    class FormsRenderer : IRenderer // Renderer for drawing the objects
    {
        Form form;

        public FormsRenderer(Form form) { this.form = form; }

        public void Clear(Color c)
        {
            using (Graphics  g = form.CreateGraphics())
                g.Clear(c);
        }

        public void DrawEllipse(int xStart, int yStart, int width, int height, int index, Color c, bool filled)
        {
            Graphics g = form.CreateGraphics();
            if (filled)
            {
                using (SolidBrush sBr = new SolidBrush(c))
                {
                    g.FillEllipse(sBr, new System.Drawing.Rectangle(xStart - 3, yStart - 3, width + 3, height + 3));
                    sBr.Dispose();
                }
            }
            else
            {
                using (Pen p = new Pen(c, 3))
                    g.DrawEllipse(p, new System.Drawing.Rectangle(xStart, yStart, width, height));
            }
            g.Dispose();
        }

        public void DrawLine(int xStart, int yStart, int xEnd, int yEnd, Color c)
        {
            Graphics g = form.CreateGraphics();
            using (Pen p = new Pen(c, 3))
                g.DrawLine(p, xStart, yStart, xEnd, yEnd);
            g.Dispose();
        }

        public void DrawTriangle(int xStart, int yStart, int width, int height, int index, Color c, bool filled)
        {
            if (filled)
            {
                Graphics g = form.CreateGraphics();
                using (SolidBrush sBr = new SolidBrush(c))
                {
                    Point[] figurePoints = { new Point(xStart - 3, yStart - 3), new Point(xStart + width + 3, yStart),
                                             new Point(xStart, yStart + height + 3) };
                    g.FillPolygon(sBr, figurePoints);
                    sBr.Dispose();
                }
                DrawLine(xStart, yStart, xStart, (yStart + height), c);
                DrawLine(xStart, yStart, (xStart + width), yStart, c);
                DrawLine((xStart + width), yStart, xStart, (yStart + height), c);
            }
            else
            {
                DrawLine(xStart, yStart, xStart, (yStart + height), c);
                DrawLine(xStart, yStart, (xStart + width), yStart, c);
                DrawLine((xStart + width), yStart, xStart, (yStart + height), c);
            }
        }

        public void DrawRectangle(int xStart, int yStart, int width, int height, int index, Color c, bool filled)
        {
            Graphics g = form.CreateGraphics();
            if (filled)
            {
                using (SolidBrush sBr = new SolidBrush(c))
                {
                    g.FillRectangle(sBr, xStart - 3, yStart - 3, width + 3, height + 3);
                    sBr.Dispose();
                }
            }
            else
            {
                using (Pen p = new Pen(c, 3))
                    g.DrawRectangle(p, xStart, yStart, width, height);
            }
            g.Dispose();
        }
    }
}
