using System;
using System.ComponentModel;
using System.Drawing;

namespace Computer_graphics_Lab_1
{
  abstract class Math_Morphology : MyFilters
  {
    static protected byte[,] mask;
    static protected int radiusW;
    static protected int radiusH;

    static protected bool flag = false; // Проверяем, задали ли структурное множество или использовать по умолчанию
    static public void CreateMask(string[] kernel)
    {

      int size = kernel.GetLength(0);
      mask = new byte[size, size];
      for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
          mask[i, j] = (byte)(kernel[i][j] - 48);
        }

      radiusW = mask.GetLength(0) / 2;
      radiusH = mask.GetLength(1) / 2;
      flag = true;
    }
    protected virtual void SetKernel()
    {
      if (!flag)
      {
        mask = new byte[3, 3] { {0, 1, 0},
                              {1, 1, 1},
                              {0, 1, 0}};

        radiusW = mask.GetLength(0) / 2;
        radiusH = mask.GetLength(1) / 2;

        //mask = new byte[,] { // Структурное множество 5х5
        //          { 1, 1, 1, 1, 1 },
        //          { 1, 1, 1, 1, 1 },
        //          { 1, 1, 1, 1, 1 },
        //          { 1, 1, 1, 1, 1 },
        //          { 1, 1, 1, 1, 1 }};
      }
    }
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      return Color.Black;
    }
    public virtual Bitmap ProcessMultipleFilters(Bitmap sourceImage, BackgroundWorker worker, int _count = 1, int num_of_calc = 1)
    {
      if (_count < num_of_calc) num_of_calc = _count;
      float invForProgressBar = 100f / _count;
      float invForSeveralFilters;
      if (num_of_calc > 1) invForSeveralFilters = invForProgressBar;
      else invForSeveralFilters = 0;
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
      for (int x = 0; x < sourceImage.Width; x++)
      {
        worker.ReportProgress((int)((float)x / resultImage.Width * (invForProgressBar) + invForSeveralFilters));
        if (worker.CancellationPending) return null;
        for (int y = 0; y < sourceImage.Height; y++)
        {
          resultImage.SetPixel(x, y, CalculateNewPixelColor(sourceImage, x, y));
        }
      }
      return resultImage;
    }
    protected Bitmap SubtractionOfImages(Bitmap firstImage, Bitmap secondImage)
    {
      int width = Math.Min(firstImage.Width, secondImage.Width);
      int height = Math.Min(firstImage.Height, secondImage.Height);
      Bitmap resultImage = firstImage;
      for (int x = 0; x < width; x++)
        for (int y = 0; y < height; y++)
          resultImage.SetPixel(x, y, Color.FromArgb(
            Clamp((int)firstImage.GetPixel(x, y).R - (int)secondImage.GetPixel(x, y).R, 0, 255),
            Clamp((int)firstImage.GetPixel(x, y).G - (int)secondImage.GetPixel(x, y).G, 0, 255),
            Clamp((int)firstImage.GetPixel(x, y).B - (int)secondImage.GetPixel(x, y).B, 0, 255)));
      return resultImage;
    }
  }
  class Erosion : Math_Morphology // Сужение (морфология)
  {
    public Erosion()
    {
      SetKernel();
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
  } // Сужение

  class Dilation : Math_Morphology // Расширение (морфология)
  {
    public Dilation()
    {
      SetKernel();
    }

    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int maxR = 0;
      int maxG = 0;
      int maxB = 0;

      for (int k = -radiusW; k <= radiusW; k++)
      {
        for (int l = -radiusH; l <= radiusH; l++)
        {
          int idX = Clamp(x + k, 0, sourceImage.Width - 1);
          int idY = Clamp(y + l, 0, sourceImage.Height - 1);

          if (mask[k + radiusW, l + radiusH] == 1)
          {
            Color color = sourceImage.GetPixel(idX, idY);
            maxR = Math.Max(maxR, color.R);
            maxG = Math.Max(maxG, color.G);
            maxB = Math.Max(maxB, color.B);
          }
        }
      }
      return Color.FromArgb(maxR, maxG, maxB);
    }
  } // Расширение

  class Opening : Math_Morphology
  {
    public Opening()
    {
      SetKernel();
    }

    public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Math_Morphology erosion = new Erosion(); // сужение
      Math_Morphology dilation = new Dilation(); // расширение
      Bitmap resultImage = sourceImage;
      return dilation.ProcessMultipleFilters(erosion.ProcessMultipleFilters(resultImage, worker, 2, 1), worker, 2, 2);

      //===============ПОДРОБНЫЙ ВАРИАНТ КОДА===============

      //int countOfFilters = 2; // Количество применений фильтров на изображение
      //int numOfFilter = 1; // Номер обработки изображения
      //resultImage = erosion.ProcessMultipleFilters(resultImage, worker, countOfFilters, numOfFilter);
      //numOfFilter++;
      //resultImage = dilation.ProcessMultipleFilters(resultImage, worker, countOfFilters, numOfFilter);
      //return resultImage;
    }
    protected override void SetKernel()
    {
      mask = new byte[7, 7] { {0, 0, 1, 1, 1, 0, 0},
                              {0, 1, 1, 1, 1, 1, 0},
                              {1, 1, 1, 1, 1, 1, 1},
                              {1, 1, 1, 1, 1, 1, 1},
                              {1, 1, 1, 1, 1, 1, 1},
                              {0, 1, 1, 1, 1, 1, 0},
                              {0, 0, 1, 1, 1, 0, 0}};

      //mask = new byte[5, 5] { {1, 1, 1, 1, 1},
      //                        {1, 1, 1, 1, 1},
      //                        {1, 1, 1, 1, 1},
      //                        {1, 1, 1, 1, 1},
      //                        {1, 1, 1, 1, 1}};

      //mask = new byte[5, 5] {
      //          { 1, 1, 1, 1, 1 },
      //          { 1, 1, 1, 1, 1 },
      //          { 1, 1, 1, 1, 1 },
      //          { 1, 1, 1, 1, 1 },
      //          { 1, 1, 1, 1, 1 }};

    }
} // Открытие

  class Closing : Math_Morphology // Закрытие
  {
    public Closing()
    {
      SetKernel();
    }

    public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Math_Morphology dilation = new Dilation(); // расширение
      Math_Morphology erosion = new Erosion(); // сужение
      Bitmap resultImage = sourceImage;
      return erosion.ProcessMultipleFilters(dilation.ProcessMultipleFilters(resultImage, worker, 2, 1), worker, 2, 2);
    }
    //protected override void SetKernel()
    //{
    //  mask = new byte[7, 7] { {0, 0, 1, 1, 1, 0, 0},
    //                          {0, 1, 1, 1, 1, 1, 0},
    //                          {1, 1, 1, 1, 1, 1, 1},
    //                          {1, 1, 1, 1, 1, 1, 1},
    //                          {1, 1, 1, 1, 1, 1, 1},
    //                          {0, 1, 1, 1, 1, 1, 0},
    //                          {0, 0, 1, 1, 1, 0, 0}};
    //}
  } // Закрытие

  class Grad : Math_Morphology
  {
    public Grad()
    {
      SetKernel();
    }
    public override Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Math_Morphology dilation = new Dilation(); // расширение
      Math_Morphology erosion = new Erosion(); // сужение
      return SubtractionOfImages(dilation.ProcessMultipleFilters(sourceImage, worker, 2, 1), erosion.ProcessMultipleFilters(sourceImage, worker, 2, 2));
    }
  }
}
