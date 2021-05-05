using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public abstract class Plugin
    {
        public abstract string Name { get; }
        public abstract Type Shape { get; }
        public abstract Type ShapeCreator { get; }
        public abstract DrawingType DrawingType { get; }

        public (string name, Type shape, Type shapeCreator) GetData() => (Name, Shape, ShapeCreator);
    }
}
