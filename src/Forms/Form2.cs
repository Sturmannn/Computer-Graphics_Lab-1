using System;
using System.Windows.Forms;

namespace Computer_graphics_Lab_1
{
  public partial class SetKernel : Form
  {
    public SetKernel()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string[] s = textBox1.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
      int width = s.GetLength(0);
      for (int i = 0; i < width; i++) // Проверка, является ли матрица квадратной
      {
        if (s[i].Length != width)
        {
          MessageBox.Show("Количество элементов в строке должно совпадать с количеством элементов в столбце!");
          return;
        }
        for (int j = 0; j < width; j++) // Проверка на 0 и 1
        {
          if (s[i][j] != '0' && s[i][j] != '1')
          {
            MessageBox.Show("Матрица должна состоять из 0 и 1!");
            return;
          }
        }
      }
      Math_Morphology.CreateMask(s);
      Close();
    }
  }
}
