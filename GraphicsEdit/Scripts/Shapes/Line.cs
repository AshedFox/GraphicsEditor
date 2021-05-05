using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    [Serializable]
    class Line : Shape
    {
        Point[] points;

        public Line(Point[] points, float borderWidth, Color penColor)
        {
            this.points = points;
            BorderWidth = borderWidth;
            PenColor = penColor;

            isFilled = false;
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawLines(pen, points);
        }

        public override void Fill(Brush brush, Graphics graphics)
        {
        }
    }
}
