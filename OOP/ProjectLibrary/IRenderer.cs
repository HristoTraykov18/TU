using System.Drawing;

namespace ProjectLibrary
{
    public interface IRenderer
    {
        void DrawLine(int xStart, int yStart, int xEnd, int yEnd, Color c, int w);
        void DrawTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Color c, int w, bool filled = false);
        void DrawRect(int xStart, int yStart, int width, int height, Color c, int w, bool filled = false);
        void RotateTransform(float angle);
    }
}
