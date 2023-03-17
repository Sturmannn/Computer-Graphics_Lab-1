using System.Drawing;
using System.ComponentModel;


namespace Computer_graphics_Lab_1
{
  abstract class MyFilters
  {
    protected abstract Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y); // Вычисление нового цвета пикселя результирующего изображения

    public virtual Bitmap ProcessImage(Bitmap sourceImage, BackgroundWorker worker) // Попиксельная замена цвета для каждого фильтра
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
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

    public int Clamp(int value, int min, int max)
    {
      if (value > max) return max;
      if (value < min) return min;
      return value;
    }
  }
}
