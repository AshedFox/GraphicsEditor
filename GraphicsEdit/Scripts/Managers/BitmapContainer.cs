using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEdit
{
    public class BitmapContainer
    {
        #region Singleton

        private static readonly Lazy<BitmapContainer> instance =
            new Lazy<BitmapContainer>(() => new BitmapContainer());

        #endregion

        public static BitmapContainer Instance => instance.Value;
        
        Bitmap bitmap;
        Bitmap bitmapBuffer;

        public BitmapContainer()
        {
        }

        public Bitmap Bitmap { get => bitmap; set => bitmap = value; }
        public Bitmap BitmapBuffer { get => bitmapBuffer; set => bitmapBuffer = value; }
    }
}
