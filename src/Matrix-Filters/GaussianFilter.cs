﻿using System;

namespace Computer_graphics_Lab_1
{
  class GaussianFilter : MatrixFilter // Матричный фильтр "Гаусса"
  {
    public GaussianFilter()
    {
      CreateGaussianKernel(3, 2);
    }
    public void CreateGaussianKernel(int radius, int sigma)
    {
      //определяем размер ядра
      int size = 2 * radius + 1;
      //создаём ядро фильтра
      kernel = new float[size, size];
      //коэффициент нормировки ядра
      float norm = 0;
      //рассчитываем ядро линейного фильтра
      for (int i = -radius; i <= radius; i++)
        for (int j = -radius; j <= radius; j++)
        {
          kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (sigma * sigma)));
          norm += kernel[i + radius, j + radius];
        }
      //нормируем ядро
      for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
          kernel[i, j] /= norm;
        }
    }
  }
}
