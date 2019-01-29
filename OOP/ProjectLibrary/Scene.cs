using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace ProjectLibrary
{
    public class Scene // The scene in which all the functionality is done
    {
        static internal List<BaseFigure> _figures = new List<BaseFigure>();
        static internal int index = 1;
        public IRenderer renderer;

        public Scene(IRenderer ir) { renderer = ir; }

        /*public enum MouseKeyCode { Left, Right, Middle };

        public void MouseKeyEvent(MouseKeyCode mButton, Point mPosition)
        {
            foreach (BaseFigure figure in _figures)
            {
                switch (mButton)
                {
                    case MouseKeyCode.Left:
                        if (figure.IsClicked(mPosition))
                            figure.Rotate(renderer);
                        break;
                }
            }
        }*/

        public void DrawFigures(int type, int xStart, int yStart, int width, int height, bool filled)
        {
            switch (type)
            {
                case 1:
                    Triangle newTriangle = new Triangle(new Point(xStart, yStart), width, height, index, Color.Orange, true);
                    _figures.Add(newTriangle);
                    break;
                case 2:
                    Rectangle newRectangle = new Rectangle(new Point(xStart, yStart), width, height, index, Color.Orange, false);
                    _figures.Add(newRectangle);
                    break;
                case 3:
                    Circle newCircle = new Circle(new Point(xStart, yStart), width, height, index, Color.Orange, false);
                    _figures.Add(newCircle);
                    break;
            }
            index++;
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public bool ImportFigures(string file)
        {
            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _figures = (List<BaseFigure>)binaryFormatter.Deserialize(stream);
                }
                foreach (BaseFigure figure in _figures)
                    figure.Draw(renderer);
                return true;
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return false;
            }
        }

        public void RotateFigures(Point mPosition)
        {
            foreach (BaseFigure figure in _figures)
            {
                if (figure.IsClicked(mPosition))
                {
                    renderer.Clear(figure.color);
                    figure.Rotate(renderer);
                }
            }
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public bool SaveFigures(string file, bool append = false)
        {
            try
            {
                using (Stream stream = File.Open(file, append ? FileMode.Append : FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, _figures);
                    return true;
                }
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return false;
            }
        }
    }
}
