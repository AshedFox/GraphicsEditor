using Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace GraphicsEdit
{
    public class Drawer
    {
        private Graphics graphics;

        private Pen pen;

        private Brush brush;
        
        private bool isDrawing;

        public Drawer()
        {
            Pen = new Pen(Color.Black, 2);
            Brush = Brushes.White;

            IsDrawing = false;
        }

        public Drawer(Graphics graphics)
        {
            Graphics = graphics;

            Pen = new Pen(Color.Black, 2);
            Brush = Brushes.White;

            IsDrawing = false;
        }

        public Drawer(Graphics graphics, Pen pen, Brush brush)
        {
            Graphics = graphics;

            Pen = pen;
            Brush = brush;

            IsDrawing = false;
        }

        public Graphics Graphics
        {
            get => graphics;
            set
            {
                graphics = value;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }

        public Pen Pen
        {
            get => pen;
            set
            {
                if (value != null) pen = value;
            }
        }

        public Brush Brush
        {
            get => brush;
            set
            {
                if (value != null)
                    brush = value;
            }
        }

        public bool IsDrawing
        {
            get => isDrawing;
            set
            {
                if (value == true)
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }
                else
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                isDrawing = value;
            }
        }

        /// <summary>
        /// Отрисовка границ без заполнения
        /// </summary>
        public void Draw(Shape shape)
        {
            if (Graphics != null) shape.Draw(Pen, Graphics);
        }

        /// <summary>
        /// Заполнение фигуры без отрисовки границ
        /// </summary>
        public void Fill(Shape shape)
        {
            if (Graphics != null) shape.Fill(Brush, Graphics);
        }

        /// <summary>
        /// Отрисовка фигуры в соответствии с её параметрами
        /// </summary>
        public void Paint(Shape shape)
        {
            if (Graphics != null) shape.Paint(Pen, Brush, Graphics);
        }
    }
}