using SharedLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidPlugin
{
    public class TrapezoidPlugin : Plugin
    {
        public override string Name => "Трапеция";
        public override Type Shape => typeof(Trapezoid);
        public override Type ShapeCreator => typeof(TrapezoidCreator);
        public override DrawingType DrawingType => DrawingType.Pen;
    }
}
