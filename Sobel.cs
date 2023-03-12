using System;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Sobel : DualKernelMF
  {
    public Sobel()
    {
      kernel = new float[3, 3];
      kernel2 = new float[3, 3];
      SetKernelX();
      SetKernelY();
    }
    protected void SetKernelX()
    {
      kernel[0, 0] = -1f; kernel[0, 1] = 0f; kernel[0, 2] = 1f;
      kernel[1, 0] = -2f; kernel[1, 1] = 0f; kernel[1, 2] = 2f;
      kernel[2, 0] = -1f; kernel[2, 1] = 0f; kernel[2, 2] = 1f;
    }
    protected void SetKernelY()
    {
      kernel2[0, 0] = -1f; kernel2[0, 1] = -2f; kernel2[0, 2] = -1f;
      kernel2[1, 0] = 0f;  kernel2[1, 1] = 0f;  kernel2[1, 2] = 0f;
      kernel2[2, 0] = 1f;  kernel2[2, 1] = 2f;  kernel2[2, 2] = 1f;
    }

    //protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    //{
    //  SetKernelX();
    //  Color resultColor = CalculatePixel(sourceImage, x, y);
    //  int red = resultColor.R;
    //  int green = resultColor.G;
    //  int blue = resultColor.B;
    //  SetKernelY();

    //  resultColor = CalculatePixel(sourceImage, x, y);
    //  resultColor = Color.FromArgb(Clamp((int)(Math.Sqrt(red * red + resultColor.R * resultColor.R)), 0, 255),
    //                               Clamp((int)(Math.Sqrt(green * green + resultColor.G * resultColor.G)), 0, 255),
    //                               Clamp((int)(Math.Sqrt(blue * blue + resultColor.B * resultColor.B)), 0, 255));
    //  return resultColor;
    //}

    //protected Color CalculatePixel(Bitmap sourceImage, int x, int y)
    //{
    //  int radiusX = kernel.GetLength(0) / 2;
    //  int radiusY = kernel.GetLength(1) / 2;

    //  float resultR = 0;
    //  float resultG = 0;
    //  float resultB = 0;
    //  for (int i = -radiusY; i <= radiusY; i++)
    //    for (int j = -radiusX; j <= radiusX; j++)
    //    {
    //      int idX = Clamp(x + j, 0, sourceImage.Width - 1);
    //      int idY = Clamp(y + i, 0, sourceImage.Height - 1);
    //      Color neighborColor = sourceImage.GetPixel(idX, idY);
    //      resultR += neighborColor.R * kernel[j + radiusX, i + radiusY];
    //      resultG += neighborColor.G * kernel[j + radiusX, i + radiusY];
    //      resultB += neighborColor.B * kernel[j + radiusX, i + radiusY];
    //    }
    //  return Color.FromArgb(
    //    Clamp((int)resultR, 0, 255),
    //    Clamp((int)resultG, 0, 255),
    //    Clamp((int)resultB, 0, 255)
    //    );
    //}
  }
}
