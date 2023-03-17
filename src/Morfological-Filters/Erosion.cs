using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Erosion : Math_Morphology
  {
    public Erosion()
    {
      SetKernel();
      radiusW = mask.GetLength(0) / 2;
      radiusH = mask.GetLength(1) / 2;
    }

    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int maxR = 255;
      int maxG = 255;
      int maxB = 255;

      for (int j = -radiusH; j <= radiusH; j++)
        for (int i = -radiusW; i <= radiusW; i++)
        {
          int idX = Clamp(x + i, 0, sourceImage.Width - 1);
          int idY = Clamp(y + j, 0, sourceImage.Height - 1);

          if (mask[i + radiusW, j + radiusH] == 1)
          {
            Color color = sourceImage.GetPixel(idX, idY);
            maxR = Math.Min(maxR, color.R);
            maxG = Math.Min(maxG, color.G);
            maxB = Math.Min(maxB, color.B);
          }
        }
      return Color.FromArgb(maxR, maxG, maxB);
    }

    protected override void SetKernel()
    {
      mask = new byte[3, 3] { {1, 1, 1},
                              {1, 1, 1},
                              {1, 1, 1}};
    }
  }
}
