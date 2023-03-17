using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class GrayScaleFilter : MyFilters // Чёрно-белый
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);
      int intensity = (int)Math.Round(0.36f * sourceColor.R + 0.53f * sourceColor.G + 0.11f * sourceColor.B);
      Color resultColor = Color.FromArgb(intensity, intensity, intensity);
      return resultColor;      
    }
  }
}
