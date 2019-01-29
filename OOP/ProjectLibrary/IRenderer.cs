﻿using System.Drawing;

namespace ProjectLibrary
{
    public interface IRenderer
    {
        void Clear(Color c);
        void DrawCircle(int xStart, int yStart, int width, int height, int index, Color c, bool filled);
        void DrawLine(int xStart, int yStart, int xEnd, int yEnd, Color c);
        void DrawRectangle(int xStart, int yStart, int width, int height, int index, Color c, bool filled);
        void DrawTriangle(int xStart, int yStart, int width, int height, int index, Color c, bool filled);
    }
}
