using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public abstract class ShapeCreator
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public abstract Shape Create(float borderWidth, Color penColor, Color brushColor);

        public abstract Shape Create(float borderWidth, Color penColor, Color brushColor, bool isFilled);

        public void AddPoint(int x, int y)
        {
            Points.Add(new Point(x, y));
        }

        public void RemoveLastPoint()
        {
            if (Points.Count > 0)
                Points.RemoveAt(Points.Count - 1);
        }

        public void ResetPoints()
        {
            Points.Clear();
        }
    }
}
