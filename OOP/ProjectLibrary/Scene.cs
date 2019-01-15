using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectLibrary
{
    public class Scene // The scene in which all the functionality is done
    {
        static internal List<Figure> _figures = new List<Figure>();
        public IRenderer renderer;

        public Scene(IRenderer ir) { renderer = ir; }

        /*public enum MouseKeyCode { Left, Right, Middle };

        public static void MouseKeyEvent(MouseKeyCode mCode, int x, int y)
        {
            switch (mCode)
            {
                case MouseKeyCode.Left:

                    break;
            }
        }*/

        public void DrawFigures(int type)
        {
            switch (type)
            {
                case 1:
                    Triangle newTriangle = new Triangle(new Point(325, 100), 325, 175, 400, 100, Color.Red, 3, false);
                    _figures.Add(newTriangle);
                    break;
                case 2:
                    Rectangle newRectangle = new Rectangle(new Point(465, 100), 75, 75, Color.Red, 3, false);
                    _figures.Add(newRectangle);
                    break;
                case 3:
                    Line newLine = new Line(new Point(605, 100), 605, 175, Color.Red, 3);
                    _figures.Add(newLine);
                    newLine.Draw(renderer);
                    break;
            }
            foreach (Figure figure in _figures)
                figure.Draw(renderer);
        }

        public void RotateFigure(int eX, int eY)
        {
            foreach(Figure figure in _figures)
                if (eX > figure.xStart && eX < figure.x2 && eY > figure.yStart && eY < figure.y2)
                    figure.Rotate(renderer, 90.0f);
        }

        public bool SaveFigures<T>(string file, bool append = false) where T : new()
        {
            /*using (Stream stream = File.Open(file, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, _figures);
            }*/

            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter("figures.xml", append);
                serializer.Serialize(writer, _figures);
                return true;
            }
            catch (System.InvalidOperationException)
            {
                return false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public bool ImportFigures(string file)
        {
            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _figures = (List<Figure>)binaryFormatter.Deserialize(stream);
                }
                foreach (Figure figure in _figures)
                    figure.Draw(renderer);
                return true;
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                return false;
            }
        }
    }
}
