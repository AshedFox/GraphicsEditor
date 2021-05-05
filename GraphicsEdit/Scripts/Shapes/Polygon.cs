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
    public class Polygon : Shape
    {
        Point[] points;

        public Polygon(Point[] points, float borderWidth, Color penColor, Color brushColor)
        {
            this.points = points;

            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            isFilled = false;
        }        
        
        public Polygon(Point[] points, float borderWidth, 
                        Color penColor, Color brushColor, bool isFilled)
        {
            this.points = points;

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
