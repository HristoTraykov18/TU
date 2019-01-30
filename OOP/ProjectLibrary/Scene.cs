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
        static internal List<BaseFigure> _selected = new List<BaseFigure>();
        private int index = 1;
        public IRenderer renderer;

        public Scene(IRenderer ir) { renderer = ir; }

        public enum MouseKeyButton { Left, Middle, Right };
        
        public void ChangeFigureColor(Point mPosition, Color color, bool filled) // If filled is true the figure should be/stay filled
        {
            foreach (BaseFigure figure in _figures)
            {
                if (figure.IsClicked(mPosition))
                {
                    if (filled)
                    {
                        figure.Fill();
                        figure.ColorChange(color);
                    }
                    else
                    {
                        figure.ClearFill();
                        renderer.Clear(color);
                    }
                }
            }
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public void DrawFigures(int figureType, int xStart, int yStart, int width, int height, bool filled)
        {
            switch (figureType)
            {
                case 1:
                    Triangle newTriangle = new Triangle(new Point(xStart, yStart), width, height, index, Color.Orange, filled);
                    _figures.Add(newTriangle);
                    break;
                case 2:
                    Rectangle newRectangle = new Rectangle(new Point(xStart, yStart), width, height, index, Color.Orange, filled);
                    _figures.Add(newRectangle);
                    break;
                case 3:
                    Ellipse newCircle = new Ellipse(new Point(xStart, yStart), width, height, index, Color.Orange, filled);
                    _figures.Add(newCircle);
                    break;
            }
            index++;
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public bool ImportFigures(string file)
        {
            List<BaseFigure> _figuresToImport = new List<BaseFigure>();
            try
            {
                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    _figuresToImport = (List<BaseFigure>)binaryFormatter.Deserialize(stream);
                }
                int temp = 0;
                foreach (BaseFigure figure in _figuresToImport)
                {
                    figure.SetNewIndex(index + temp);
                    _figures.Add(figure);
                    temp++;
                }
                foreach (BaseFigure figure in _figures)
                    figure.Draw(renderer);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        public void MouseKeyEvent(MouseKeyButton mButton, Point mPosition)
        {
            foreach (BaseFigure figure in _figures)
            {
                switch (mButton)
                {
                    case MouseKeyButton.Left:
                        //if (figure.IsClicked(mPosition))
                        //
                        break;
                    case MouseKeyButton.Middle:
                        //if (figure.IsClicked(mPosition))
                        //
                        break;
                    case MouseKeyButton.Right:
                        //if (figure.IsClicked(mPosition))
                        //
                        break;
                }
            }
        }

        public void MoveFigure(Point mPosition)
        {

        }

        public void Redraw()
        {
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public void RotateFigures(Point mPosition)
        {
            foreach (BaseFigure figure in _figures)
            {
                if (figure.IsClicked(mPosition))
                {
                    renderer.Clear(Color.White);
                    figure.Rotate(renderer);
                }
            }
            foreach (BaseFigure figure in _figures)
                figure.Draw(renderer);
        }

        public bool SaveFigures(string file, bool append = false)
        {
            using (Stream stream = File.Open(file, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, _figures);
                return true;
            }
        }

        public void SelectFigure(Point mPosition)
        {
            foreach (BaseFigure figure in _figures)
            {
                if (figure.IsClicked(mPosition))
                    _selected.Add(figure);
            }
        }
    }
}
