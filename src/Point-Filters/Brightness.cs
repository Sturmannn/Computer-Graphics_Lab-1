using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Brightness : MyFilters // Увеличение яркости
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int k = 20; // Коэффициент увеличения яркости
      Color sourceColor = sourceImage.GetPixel(x, y);
      Color resultColor = Color.FromArgb(Clamp(sourceColor.R + k, 0, 255),
                                         Clamp(sourceColor.G + k, 0, 255),
                                         Clamp(sourceColor.B + k, 0, 255));
      return resultColor;
    }
  }
}
