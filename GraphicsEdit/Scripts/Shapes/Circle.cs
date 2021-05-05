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
    public class Circle: Shape
    {
        int x;
        int y;
        int radius;

        public Circle(int x, int y, int radius, float borderWidth,
                      Color penColor, Color brushColor)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            BorderWidth = borderWidth;

            PenColor = penColor;
            BrushColor = brushColor;

            isFilled = false;
        }        
        
        public Circle(int x, int y, int radius, float borderWidth, 
                      Color penColor, Color brushColor, bool isFilled)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            BorderWidth = borderWidth;

            PenColor = penColor;
            BrushColor = brushColor;

            this.isFilled = isFilled;
        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawEllipse(pen, x - radius, y - radius, radius*2, radius*2);
        }

        public override void Fill(Brush brush, Graphics graphics)
        {
            graphics.FillEllipse(brush, x - radius, y - radius, radius * 2, radius * 2);
        }
    }
}
