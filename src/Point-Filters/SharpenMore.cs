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
