using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    class RegularPolygonCreator : ShapeCreator
    {
        int amountOfPoints;

        public int AmountOfPoints { get => amountOfPoints; set => amountOfPoints = value; }

        public RegularPolygonCreator()
        {
            AmountOfPoints = 3;
        }

        public RegularPolygonCreator(int amountOfPoints)
        {
            AmountOfPoints = amountOfPoints;
        }

        public override Shape Create(float borderWidth, Color penColor, Color brushColor)
        {
            if (Points.Count >= 2)
            {
                int radius = (int)Math.Sqrt(Math.Pow(Points[1].X - Points[0].X, 2) +
                                        Math.Pow(Points[1].Y - Points[0].Y, 2));
                if (Points[0].Y > Points[1].Y)
                {
                    radius =-radius;
                }
                return new RegularPolygon(AmountOfPoints, Points[0].X, Points[0].Y, radius, borderWidth, penColor, brushColor);
            }
            return null;
        }

        public override Shape Create(float borderWidth, Color penColor, Color brushColor, bool isFilled)
        {
            if (Points.Count >= 2)
            {
                int radius = (int)Math.Sqrt(Math.Pow(Points[1].X - Points[0].X, 2) +
                                        Math.Pow(Points[1].Y - Points[0].Y, 2));

                if (Points[0].Y > Points[1].Y)
                {
                    radius = -radius;
                }

                return new RegularPolygon(AmountOfPoints, Points[0].X, Points[0].Y, radius,
                                   borderWidth, penColor, brushColor, isFilled);
            }
            return null;
        }
    }
}
