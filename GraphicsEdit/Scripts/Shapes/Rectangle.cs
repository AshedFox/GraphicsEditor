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
    public class Rectangle : Shape
    {
        int x;
        int y;
        int width;
        int height;

        public Rectangle(int x, int y, int width, int height, 
                        float borderWidth,
                         Color penColor, Color brushColor)
        {          
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            isFilled = false;
        }        
        
        public Rectangle(int x, int y, int width, int height, float borderWidth, 
                         Color penColor, Color brushColor, bool isFilled)
        {          
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            BorderWidth = borderWidth;
            PenColor = penColor;
            BrushColor = brushColor;

            this.isFilled = isFilled;

        }

        public override void Draw(Pen pen, Graphics graphics)
        {
            graphics.DrawRectangle(pen, x, y, width, height);
        }

        public override void Fill(Brush brush, Graphics graphics)
        {
            graphics.FillRectangle(brush, x, y, width, height);
        }
    }
}
