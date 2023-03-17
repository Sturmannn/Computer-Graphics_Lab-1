using System;
using System.Drawing;


namespace Computer_graphics_Lab_1
{
  class Dilation : Math_Morphology // Расширение (морфология)
  {
    //protected byte[,] mask;
    //protected int radiusW;
    //protected int radiusH;
    public Dilation()
    {
      SetKernel();
      radiusW = mask.GetLength(0) / 2;
      radiusH = mask.GetLength(1) / 2; // Сделал статичным
    }

    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int maxR = 0;
      int maxG = 0;
      int maxB = 0;

      for (int j = -radiusH; j <= radiusH; j++)
        for (int i = -radiusW; i <= radiusW; i++)
        {
          int idX = Clamp(x + i, 0, sourceImage.Width - 1);
          int idY = Clamp(y + j, 0, sourceImage.Height - 1);

          if (mask[i + radiusW, j + radiusH] == 1)
          {
            Color color = sourceImage.GetPixel(idX, idY);
            maxR = Math.Max(maxR, color.R);
            maxG = Math.Max(maxG, color.G);
            maxB = Math.Max(maxB, color.B);
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
