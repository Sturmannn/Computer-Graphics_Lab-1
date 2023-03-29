using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Computer_graphics_Lab_1
{
  class MedianFilter : MatrixFilter
  {
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {

      List<int> Reds = new List<int>();
      List<int> Greens = new List<int>();
      List<int> Blues = new List<int>();

      int radiusW = 1;
      int radiusH = 1;

      for (int k = -radiusW; k <= radiusW; k++)
      {
        for (int l = -radiusH; l <= radiusH; l++)
        {
          int idX = Clamp(x + k, 0, sourceImage.Width - 1);
          int idY = Clamp(y + l, 0, sourceImage.Height - 1);

          Color color = sourceImage.GetPixel(idX, idY);

          Reds.Add(color.R);
          Greens.Add(color.G);
          Blues.Add(color.B);
        }
      }

      Reds.Sort();
      Greens.Sort();
      Blues.Sort();

      return Color.FromArgb(Reds[Reds.Count() / 2], Greens[Greens.Count() / 2], Blues[Blues.Count() / 2]);
    }
  }
}