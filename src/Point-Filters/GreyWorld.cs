using System.ComponentModel;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  class GreyWorld : MyFilters // Серый мир
  {
    float R = 0f;
    float G = 0f;
    float B = 0f;

    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color resultColor = sourceImage.GetPixel(x, y);
      resultColor = Color.FromArgb(Clamp((int)(resultColor.R * R), 0, 255),
                                     Clamp((int)(resultColor.G * G), 0, 255),
                                     Clamp((int)(resultColor.B * B), 0, 255));
      return resultColor;
    }

    public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
      GetCoeff(sourceImage);
      for (int x = 0; x < sourceImage.Width; x++)
      {
        worker.ReportProgress((int)((float)x / resultImage.Width * 100));
        if (worker.CancellationPending) return null;
        for (int y = 0; y < sourceImage.Height; y++)
        {
          resultImage.SetPixel(x, y, CalculateNewPixelColor(sourceImage, x, y));
        }
      }
      return resultImage;
    }

    protected void GetCoeff(Bitmap sourceImage)
    {
      Color colorPixel;
      int sizeOfImage = sourceImage.Height * sourceImage.Width;
      for (int idX = 0; idX < sourceImage.Width; idX++)
        for (int idY = 0; idY < sourceImage.Height; idY++)
        {
          colorPixel = sourceImage.GetPixel(idX, idY);
          R += colorPixel.R;
          G += colorPixel.G;
          B += colorPixel.B;
        }
      R /= sizeOfImage;
      G /= sizeOfImage;
      B /= sizeOfImage;
      float avg = (R + G + B) / 3f;
      R = avg / R;
      G = avg / G;
      B = avg / B;
    }
  }
}
