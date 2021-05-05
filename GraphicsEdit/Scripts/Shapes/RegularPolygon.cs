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
    public class RegularPolygon : Shape
    {
        PointF[] points;

        public RegularPolygon(int amountOfPoints, int x, int y, int radius, float borderWidth, Color penColor, Color brushColor)
        {
            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            PointF center = new PointF(x, y);

            var angle = Math.PI * 2 / amountOfPoints;

            points = Enumerable.Range(0, amountOfPoints).Select(
                     i => PointF.Add(center, 
                                     new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)
                                    )
                     ).ToArray();

            isFilled = false;
        }        
        
        public RegularPolygon(int amountOfPoints, int x, int y, int radius, float borderWidth, 
                        Color penColor, Color brushColor, bool isFilled)
        {
            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            PointF center = new PointF(x, y);

            var angle = Math.PI * 2 / amountOfPoints;

            points = Enumerable.Range(0, amountOfPoints).Select(
                     i => PointF.Add(center,
                                     new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius)
                                    )
                     ).ToArray();

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
