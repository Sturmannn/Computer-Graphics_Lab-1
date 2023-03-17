using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Transfer : MyFilters // Сдвиг на 50 пикселей влево
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      if (x + 50 >= sourceImage.Width)
      {
        return Color.FromArgb(0, 0, 0);
      }
      else
      {
        return sourceImage.GetPixel(x + 50, y);
      }
    }
  }
}
