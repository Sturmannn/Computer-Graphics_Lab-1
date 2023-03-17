using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class InvertFilter : MyFilters // Инвертирование
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);
      Color resultColor = Color.FromArgb(255 - sourceColor.R, 255 - sourceColor.G, 255 - sourceColor.B);
      return resultColor;
    }
  }
}
