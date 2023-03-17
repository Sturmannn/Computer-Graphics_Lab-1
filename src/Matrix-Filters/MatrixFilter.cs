using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class MatrixFilter : MyFilters
  {
    protected float[ , ] kernel = null;
    public MatrixFilter() { }
    public MatrixFilter(float[,] kernel)
    {
      this.kernel = kernel;
    }
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int radiusX = kernel.GetLength(0) / 2;
      int radiusY = kernel.GetLength(1) / 2;

      float resultR = 0;
      float resultG = 0;
      float resultB = 0;
      for (int i = -radiusY; i <= radiusY; i++)
        for (int j = -radiusX; j <= radiusX; j++)
        {
          int idX = Clamp(x + j, 0, sourceImage.Width - 1);
          int idY = Clamp(y + i, 0, sourceImage.Height - 1);
          Color neighborColor = sourceImage.GetPixel(idX, idY);
          resultR += neighborColor.R * kernel[j + radiusX, i + radiusY];
          resultG += neighborColor.G * kernel[j + radiusX, i + radiusY];
          resultB += neighborColor.B * kernel[j + radiusX, i + radiusY];
        }
      return Color.FromArgb(
        Clamp((int)resultR, 0, 255),
        Clamp((int)resultG, 0, 255),
        Clamp((int)resultB, 0, 255)
        );
    }
  }
}
