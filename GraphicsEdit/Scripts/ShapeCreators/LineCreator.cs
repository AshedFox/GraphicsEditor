using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    class LineCreator : ShapeCreator
    {
        public override Shape Create(float borderWidth, Color penColor, Color brushColor)
        {
            if (Points.Count >= 2)
            {
                return new Line(Points.ToArray(), borderWidth, penColor);
            }
            return null;
        }

        public override Shape Create(float borderWidth, Color penColor, Color brushColor, bool isFilled)
        {
            return Create(borderWidth, penColor, brushColor);
        }
    }
}
