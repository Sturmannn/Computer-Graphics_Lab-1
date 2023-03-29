using System;
using System.ComponentModel;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class Auto_Levels : MyFilters
  {
    protected int maxR = 0;
    protected int maxG = 0;
    protected int maxB = 0;

    protected int minR = 255;
    protected int minG = 255;
    protected int minB = 255;

    public void GetMaxColor(Bitmap sourceImage)
    {
      maxR = 0;
      maxG = 0;
      maxB = 0;
      
      for (int i = 0; i < sourceImage.Width; i++)
      {
        for (int j = 0; j < sourceImage.Height; j++)
        {
          Color color = sourceImage.GetPixel(i, j);

          maxR = Math.Max(maxR, color.R);
          maxB = Math.Max(maxB, color.B);
          maxG = Math.Max(maxG, color.G);
        }
      }
    }

    public void GetMinColor(Bitmap sourceImage)
    {
      minR = 255;
      minG = 255;
      minB = 255;
      for (int i = 0; i < sourceImage.Width; i++)
      {
        for (int j = 0; j < sourceImage.Height; j++)
        {
          Color color = sourceImage.GetPixel(i, j);

          minR = Math.Min(minR, color.R);
          minB = Math.Min(minB, color.B);
          minG = Math.Min(minG, color.G);
        }
      }
    }
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color pixel = sourceImage.GetPixel(x, y);

      float newR = (pixel.R - minR) * 255 / (maxR - minR);
      float newG = (pixel.G - minG) * 255 / (maxG - minG);
      float newB = (pixel.B - minB) * 255 / (maxB - minB);

      return Color.FromArgb(Clamp((int)newR, 0, 255),
                            Clamp((int)newG, 0, 255),
                            Clamp((int)newB, 0, 255));
    }

    public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      GetMinColor(sourceImage);
      GetMaxColor(sourceImage);

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 100));
        for (int j = 0; j < sourceImage.Height; j++)
        {
          resultImage.SetPixel(i, j, CalculateNewPixelColor(sourceImage, i, j));
        }
      }
      return resultImage;
    }
  }
}
