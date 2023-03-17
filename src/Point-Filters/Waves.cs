using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Waves : MyFilters
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int idX = Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 30)), 0, sourceImage.Width - 1);
      int idY = y;
      return sourceImage.GetPixel(idX, idY);
    }
  }
}
