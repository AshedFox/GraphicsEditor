using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    class PolygonCreator : ShapeCreator
    {
        public override Shape Create(float borderWidth, Color penColor, Color brushColor)
        {
            if (Points.Count >= 2)
            {
                return new Polygon(Points.ToArray(), borderWidth, penColor, brushColor);
            }
            return null;
        }

        public override Shape Create(float borderWidth, Color penColor, Color brushColor, bool isFilled)
        {
            if (Points.Count >= 2)
            {
                return new Polygon(Points.ToArray(), borderWidth, penColor, brushColor, isFilled);
            }
            return null;
        }
    }
}
