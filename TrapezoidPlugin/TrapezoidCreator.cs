using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidPlugin
{
    class TrapezoidCreator : ShapeCreator
    {
        public override Shape Create(float borderWidth, System.Drawing.Color penColor, System.Drawing.Color brushColor)
        {
            if (Points.Count > 3)
            {
                return new Trapezoid(Points[0], Points[1].Y - Points[0].Y, Math.Abs(Points[0].X - Points[2].X),
                                     Math.Abs(Points[0].X - Points[3].X), borderWidth, penColor, brushColor, false);
            }
            return null;
        }

        public override Shape Create(float borderWidth, System.Drawing.Color penColor, System.Drawing.Color brushColor, bool isFilled)
        {
            if (Points.Count > 3)
            {
                return new Trapezoid(Points[0], Points[1].Y - Points[0].Y, Math.Abs(Points[0].X - Points[2].X),
                                     Math.Abs(Points[0].X - Points[3].X), borderWidth, penColor, brushColor, isFilled);
            }
            return null;
        }
    }
}
