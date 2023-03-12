using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class GreyWorld : MyFilters
  {
    float[] coeffs = new float[3]; // 0-red 1-green 2-blue
    Bitmap tmpSourceImage;
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color resultColor = sourceImage.GetPixel(x, y);
      if (tmpSourceImage != sourceImage) // Смотрим, новое ли изображение пришло
      {
        GetCoeff(sourceImage);
        resultColor = Color.FromArgb(Clamp((int)(resultColor.R * coeffs[0]), 0, 255),
                                     Clamp((int)(resultColor.G * coeffs[1]), 0, 255),
                                     Clamp((int)(resultColor.B * coeffs[2]), 0, 255));
      }
      else
      {
        resultColor = Color.FromArgb(Clamp((int)(resultColor.R * coeffs[0]), 0, 255),
                                     Clamp((int)(resultColor.G * coeffs[1]), 0, 255),
                                     Clamp((int)(resultColor.B * coeffs[2]), 0, 255));
      }
      return resultColor;
    }

    protected void GetCoeff(Bitmap sourceImage)
    {
      tmpSourceImage = sourceImage;
      Color colorPixel;
      int sizeOfImage = sourceImage.Height * sourceImage.Width;
      for (int idX = 0; idX < sourceImage.Width; idX++)
        for (int idY = 0; idY < sourceImage.Height; idY++)
        {
          colorPixel = sourceImage.GetPixel(idX, idY);
          coeffs[0] += colorPixel.R;
          coeffs[1] += colorPixel.G;
          coeffs[2] += colorPixel.B;
        }
      coeffs[0] /= sizeOfImage;
      coeffs[1] /= sizeOfImage;
      coeffs[2] /= sizeOfImage;
      float avg = (coeffs[0] + coeffs[1] + coeffs[2]) / 3f;
      coeffs[0] = avg / coeffs[0];
      coeffs[1] = avg / coeffs[1];
      coeffs[2] = avg / coeffs[2];
    }
  }
}
