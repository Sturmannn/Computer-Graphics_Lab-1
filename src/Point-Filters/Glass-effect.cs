using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_graphics_Lab_1
{
  class Glass_effect : MyFilters
  {
    private Random rand = new Random();
    protected override Color CalculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int idX = Clamp((int)(x + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Width - 1);
      int idY = Clamp((int)(y + (rand.NextDouble() - 0.5) * 10), 0, sourceImage.Height - 1);
      return sourceImage.GetPixel(idX, idY);
    }
  }
}
