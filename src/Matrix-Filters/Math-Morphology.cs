namespace Computer_graphics_Lab_1
{
  abstract class Math_Morphology : MyFilters
  {
    protected byte[,] mask;
    protected int radiusW;
    protected int radiusH;
    protected abstract void SetKernel();
  }
}
