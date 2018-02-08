using System.IO;
using System.Drawing;
using System.Reflection;

namespace CharResizer
{
    class Resizer
    {
        public static readonly int charsetWidth = 348;
        public static readonly int charsetHeight = 256;
        public static readonly int charWidth = 96;
        public static readonly int charHeight = 128;

        public static Bitmap Stretch(Bitmap bmp, int newSizeX, int newSizeY)
        {
            Bitmap result = new Bitmap(newSizeX, newSizeY);
            Graphics g = Graphics.FromImage(result);

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(bmp, 0, 0, newSizeX + 1, newSizeY + 1);
            g.Dispose();
            return result;
        }

        private static Bitmap GetTemplate(string resName)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            Stream stream = ass.GetManifestResourceStream("CharResizer.Resource." + resName + ".png");
            Bitmap bmp = new Bitmap(stream);
            
            stream.Dispose();
            return bmp;
        }
        
        public static Bitmap ApplyMultiplierFactor(int width, int height, string resName)
        {
            return Stretch(GetTemplate(resName), width, height);
        }
    }
}
