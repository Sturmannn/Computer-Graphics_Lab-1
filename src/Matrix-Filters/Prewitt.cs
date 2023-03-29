namespace Computer_graphics_Lab_1
{
  class Prewitt : DualKernelMF // Матричный фильтр "Прюитта"
  {
    public Prewitt()
    {

      kernel = new float[3, 3];
      kernel2 = new float[3, 3];
      SetKernelX();
      SetKernelY();
    }

    protected void SetKernelX()
    {
      kernel[0, 0] = -1f; kernel[0, 1] = 0f; kernel[0, 2] = -1f;
      kernel[1, 0] = -1f; kernel[1, 1] = 0f; kernel[1, 2] = -1f;
      kernel[2, 0] = -1f; kernel[2, 1] = 0f; kernel[2, 2] = -1f;
    }
    protected void SetKernelY()
    {
      kernel2[0, 0] = -1f; kernel2[0, 1] = -1f;  kernel2[0, 2] = -1f;
      kernel2[1, 0] = 0f;  kernel2[1, 1] = 0f;   kernel2[1, 2] = 0f;
      kernel2[2, 0] = 1f;  kernel2[2, 1] = 1f;   kernel2[2, 2] = 1f;
    }
  }
}
