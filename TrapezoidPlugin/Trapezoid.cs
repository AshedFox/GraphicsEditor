using SharedLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TrapezoidPlugin
{
    [Serializable]
    class Trapezoid : Shape
    {
        Point[] points = new Point[4];

        public Trapezoid(Point basePoint, int height, int bottomWidth, int topWidth,
                         float borderWidth, Color penColor, Color brushColor, bool isFilled)
        {
            points[0] = new Point(basePoint.X - bottomWidth, basePoint.Y);
            points[1] = new Point(basePoint.X + bottomWidth, basePoint.Y);
            points[2] = new Point(basePoint.X + topWidth, basePoint.Y + height);
            points[3] = new Point(basePoint.X - topWidth, basePoint.Y + height);

            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            this.isFilled = isFilled;
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }

        public override void Fill(Brush brush, Graphics graphics)
        {
            graphics.FillPolygon(brush, points);
        }
    }
}
