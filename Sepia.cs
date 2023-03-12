using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Sepia : MyFilters
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      float k = 10f; // Заданный вручную коэффициент
      Color sourceColor = sourceImage.GetPixel(x, y);

      int intensity = (int)Math.Round(0.36f * sourceColor.R + 0.53f * sourceColor.G + 0.11f * sourceColor.B);
      int red = Clamp((int)Math.Round(intensity + 2 * k), 0, 255);
      int green = Clamp((int)Math.Round(intensity + 0.5 * k), 0, 255);
      int blue = Clamp((int)Math.Round(intensity - 1 * k), 0, 255);

      Color resultColor = Color.FromArgb(red, green, blue);
      return resultColor;
    }
  }
}
