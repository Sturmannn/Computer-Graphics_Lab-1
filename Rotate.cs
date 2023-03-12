using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Rotate : MyFilters
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      double angle = Math.PI / (double)6;
      int x0 = (int)Math.Round(sourceImage.Width * 0.5f + 1);
      int y0 = (int)Math.Round(sourceImage.Height * 0.5f + 1);

      int idX = (int)Math.Round((x - x0) * Math.Cos(angle) - (y - y0) * Math.Sin(angle) + x0);
      int idY = (int)Math.Round((x - x0) * Math.Sin(angle) + (y - y0) * Math.Sin(angle) + y0);

      if (idX >= sourceImage.Width || idX < 0 || idY >= sourceImage.Height || idY < 0) return Color.FromArgb(0, 0, 0);
      else return sourceImage.GetPixel(idX, idY);

    }
  }
}
