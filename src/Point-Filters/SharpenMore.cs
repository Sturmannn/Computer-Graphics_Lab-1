using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class SharpenMore : MatrixFilter // Матричный фильтр резкости
  {
    public SharpenMore()
    {
      SetKernel();
    }

    protected void SetKernel()
    {
      kernel = new float[3, 3] { { 0, -1, 0 },
                                 { -1, 5, -1 },
                                 { 0, -1, 0 } };
    }
  }
}
