using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Rotate : MyFilters // Поворот на 90 градусов
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      double angle = Math.PI * 0.5; 
      int x0 = (int)(sourceImage.Width * 0.5f);
      int y0 = (int)(sourceImage.Height * 0.5f);

      int idX = (int)((x - x0) * Math.Cos(angle) - (y - y0) * Math.Sin(angle) + x0);
      int idY = (int)((x - x0) * Math.Sin(angle) + (y - y0) * Math.Cos(angle) + y0);

      if (idX >= sourceImage.Width || idX < 0 || idY >= sourceImage.Height || idY < 0) return Color.FromArgb(0, 0, 0);
      else return sourceImage.GetPixel(idX, idY);
    }
  }
}
