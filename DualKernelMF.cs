using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class DualKernelMF : MatrixFilter
  {
    protected float[,] kernel2;
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color resultColor = CalculatePixel(sourceImage, x, y, kernel);
      int red = resultColor.R;
      int green = resultColor.G;
      int blue = resultColor.B;

      resultColor = CalculatePixel(sourceImage, x, y, kernel2);
      resultColor = Color.FromArgb(Clamp((int)(Math.Sqrt(red * red + resultColor.R * resultColor.R)), 0, 255),
                                   Clamp((int)(Math.Sqrt(green * green + resultColor.G * resultColor.G)), 0, 255),
                                   Clamp((int)(Math.Sqrt(blue * blue + resultColor.B * resultColor.B)), 0, 255));
      return resultColor;
    }
    protected Color CalculatePixel(Bitmap sourceImage, int x, int y, float[,] ker)
    {
      int radiusX = ker.GetLength(0) / 2;
      int radiusY = ker.GetLength(1) / 2;

      float resultR = 0;
      float resultG = 0;
      float resultB = 0;
      for (int i = -radiusY; i <= radiusY; i++)
        for (int j = -radiusX; j <= radiusX; j++)
        {
          int idX = Clamp(x + j, 0, sourceImage.Width - 1);
          int idY = Clamp(y + i, 0, sourceImage.Height - 1);
          Color neighborColor = sourceImage.GetPixel(idX, idY);
          resultR += neighborColor.R * ker[j + radiusX, i + radiusY];
          resultG += neighborColor.G * ker[j + radiusX, i + radiusY];
          resultB += neighborColor.B * ker[j + radiusX, i + radiusY];
        }
      return Color.FromArgb(
        Clamp((int)resultR, 0, 255),
        Clamp((int)resultG, 0, 255),
        Clamp((int)resultB, 0, 255)
        );
    }
  }
}
