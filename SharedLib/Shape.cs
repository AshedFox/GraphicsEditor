using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    [Serializable]
    // Интерфейс для абстракции геометрической фигуры
    public abstract class Shape
    {
        protected bool isFilled;


        public float BorderWidth { get; set ; }
        protected Color PenColor { get ; set; }
        protected Color BrushColor { get; set; }

        /// <summary>
        /// Отрисовка границ фигуры без заполнения
        /// </summary>
        public abstract void Draw(Pen pen, Graphics graphics);

        /// <summary>
        /// Заполнение фигуры без отрисовки границ
        /// </summary>
        public abstract void Fill(Brush brush, Graphics graphics);

        /// <summary>
        /// Отрисовка фигуры в соответствии с её параметрами
        /// </summary>
        public virtual void Paint(Pen pen, Brush brush, Graphics graphics)
        {
            pen.Width = BorderWidth;
            pen.Color = PenColor;
            brush = new SolidBrush(BrushColor);

            if (isFilled)
            {
                Fill(brush, graphics);
            }
            Draw(pen, graphics);
        }
    }
}
