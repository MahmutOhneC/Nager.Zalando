using System.Drawing;
using System.Drawing.Text;

namespace Nager.Zalando.Monitor
{
    public static class ImageHelper
    {
        public static Bitmap GetImage(string text)
        {
            var bitmap = new Bitmap(200, 50);
            using (var graphic = Graphics.FromImage(bitmap))
            {
                graphic.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                graphic.DrawString(text, new Font("Arial", 15), Brushes.Black, 0, 0);
                graphic.Flush();
            }

            return bitmap;
        }
    }
}
