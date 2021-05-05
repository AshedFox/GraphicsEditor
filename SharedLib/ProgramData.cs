using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SharedLib
{
    [Serializable]
    public class ProgramData
    {
        public Shape[] shapes;
        public int currentShapeIndex;
        public Size drawingFieldSize;
        public Color penColor;
        public float penWidth;
        public Color brushColor;

        public ProgramData(LinkedList<Shape> shapesList, Shape currentShape, Size drawingFieldSize, Color penColor,
                           float penWidth, Color brushColor)
        {
            shapes = new Shape[shapesList.Count];
            shapesList.CopyTo(shapes, 0);

            currentShapeIndex = Array.IndexOf(shapes, currentShape);

            this.brushColor = brushColor;
            this.drawingFieldSize = drawingFieldSize;
            this.penColor = penColor;
            this.penWidth = penWidth;
        }
    }
}
