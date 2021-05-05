using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    class RectangleCreator : ShapeCreator
    {
        public override Shape Create(float borderWidth, Color penColor, Color brushColor)
        {
            if (Points.Count >= 2)
            {
                return new Rectangle(Math.Min(Points[1].X, Points[0].X), Math.Min(Points[1].Y, Points[0].Y),
                                     Math.Abs(Points[1].X - Points[0].X), Math.Abs(Points[1].Y - Points[0].Y),
                                     borderWidth, penColor, brushColor);
            }
            return null;
        }

        public override Shape Create(float borderWidth, Color penColor, Color brushColor, bool isFilled)
        {
            if (Points.Count >= 2)
            {
                return new Rectangle(Math.Min(Points[1].X, Points[0].X), Math.Min(Points[1].Y, Points[0].Y),
                                     Math.Abs(Points[1].X - Points[0].X), Math.Abs(Points[1].Y - Points[0].Y),
                                     borderWidth, penColor, brushColor, isFilled);
            }
            return null;
        }
    }
}
