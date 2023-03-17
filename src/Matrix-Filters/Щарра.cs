using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Щарра : DualKernelMF // Матричный фильтр "Щарра"
  {
    public Щарра()
    {
      kernel = new float[3, 3];
      kernel2 = new float[3, 3];
      SetKernelX();
      SetKernelY();
    }

    protected void SetKernelX()
    {
      kernel[0, 0] = 3f; kernel[0, 1] = 0f; kernel[0, 2] = -3f;
      kernel[1, 0] = 10f; kernel[1, 1] = 0f; kernel[1, 2] = -10f;
      kernel[2, 0] = 3f; kernel[2, 1] = 0f; kernel[2, 2] = -3f;
    }
    protected void SetKernelY()
    {
      kernel2[0, 0] = 3f; kernel2[0, 1] = 10f; kernel2[0, 2] = 3f;
      kernel2[1, 0] = 0f; kernel2[1, 1] = 0f; kernel2[1, 2] = 0f;
      kernel2[2, 0] = -3f; kernel2[2, 1] = -10f; kernel2[2, 2] = -3f;
    }
  }
}
