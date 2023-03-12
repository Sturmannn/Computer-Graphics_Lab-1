using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Dilation : MatrixFilter
  {
    public Dilation()
    {
    }

    protected void SetKernel()
    {
      kernel = new float[3, 3] { {0f, 1f, 0f},
                                 {1f, 1f, 1f },
                                 {0f, 1f, 0f }};
    }
  }
}
