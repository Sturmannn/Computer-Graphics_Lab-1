using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Computer_graphics_Lab_1
{
  public partial class Form1 : Form
  {
    //Bitmap image; // Создание объект Bitmap, который в будущем будет нашей картинкой
    static string path; // Для перезаписи того же файла
    static int size = 5;
    static int count = 0; // Вспомогательный счётчик изображений для реализации "Вперёд" 
    Bitmap[] images = new Bitmap[size];
    int indOfPict = -1; // Индекс массива картин (текущее состояние в массиве images)
    public Form1()
    {
      InitializeComponent();
    }

    private void открытьToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      using (OpenFileDialog dialog = new OpenFileDialog()) // Создание диалогового окна для открытия файла
      {
        dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All files (*.*) | *.*";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          indOfPict++;
          count++;
          images[indOfPict] = new Bitmap(dialog.FileName);

          path = Path.GetFullPath(dialog.FileName);
          pictureBox1.Image = images[indOfPict];
          pictureBox1.Refresh();
        }
      }
    }

    private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {

      Bitmap newImage = ((MyFilters)e.Argument).ProcessImage(images[indOfPict], backgroundWorker1);

      if (backgroundWorker1.CancellationPending != true)
      {
        if (indOfPict == size - 1)  Repacking();
        count = indOfPict + 1;
        indOfPict++;
        images[indOfPict] = newImage;
      }
    }

    private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage; // Изменение цвета полосы
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
    {
      if (!e.Cancelled)
      {
        pictureBox1.Image = images[indOfPict];
        pictureBox1.Refresh();
      }
      progressBar1.Value = 0;
      for (int i = count; i > indOfPict; i--)
        images[i] = null;
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
      backgroundWorker1.CancelAsync(); // остановка выполнения фильтра
    }

    private void инверсияToolStripMenuItem1_Click(object sender, System.EventArgs e)
    {
      /*=============== Реализация без BackgroundWorker =====================

      InvertFilter filter = new InvertFilter();
      Bitmap resultImage = filter.ProcessImage(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
      */
      if (indOfPict > -1)
      {
        MyFilters filter = new InvertFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void размытиеToolStripMenuItem1_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new BlurFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void размытиеГауссаToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new GaussianFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void чёрнобелыйToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new GrayScaleFilter();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void сепияToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Sepia();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void увеличениеЯркостиToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Brightness();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void собельToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Sobel();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void повышениеРезкостиToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new SharpenMore();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    //private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    //{
    //  //File.Delete(path);
    //  if (indOfPict > -1)
    //  {

    //    Image saveImage = (Image)images[indOfPict];
    //    pictureBox1.Image.Dispose();
    //    pictureBox1.Image = null;
    //    File.Delete(path);
    //    //saveImage.Save(path);
    //    //using (FileStream fs = new FileStream(path, FileMode.Create))
    //    {
    //      //saveImage.Save(fs, ImageFormat.Jpeg);
    //      //saveImage.Save()
    //      //saveImage.Save(fs, ImageFormat.Jpeg);
    //      //pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
    //    };
    //  }
    //}

    private void сохранитьКакToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (pictureBox1 != null)
      {
        using (SaveFileDialog dialog = new SaveFileDialog())
        {
          dialog.Filter = "JPEG-файл|*.jpg|PNG-файл|*.png";
          dialog.Title = "Сохранить изображение как";
          dialog.OverwritePrompt = true;
          dialog.CheckPathExists = true;
          
          if (dialog.ShowDialog() == DialogResult.OK)
            if (dialog.FileName != "")
            {
              //string path = Path.GetFullPath(dialog.FileName);
              //if (dialog.OverwritePrompt == true)
              //{
              //  File.Save
              //  using (FileStream fs = new FileStream(path, FileMode.Create)) return;
              //}
              //using(FileStream fs = new FileStream(path, FileMode.CreateNew))
              using (FileStream fs = (FileStream)dialog.OpenFile())
              {
                if (dialog.FilterIndex == 1) pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
                else if (dialog.FilterIndex == 2) pictureBox1.Image.Save(fs, ImageFormat.Png);
                //else if (dialog.OverwritePrompt == true)
                //{
                //  Image saveImage = images[indOfPict];
                //  pictureBox1.Image.Dispose();
                //  pictureBox1.Image = null;
                //  saveImage.Save(fs, ImageFormat.Jpeg);

                //  //pictureBox1.Image.Save(dialog.FileName);
                //}
                else MessageBox.Show("Вы что-то делаете не так! Попробуйте заново!");
              };
            }
        }
      }
    }

    private void назадToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict > 0)
      {
        indOfPict--;
        pictureBox1.Image = images[indOfPict];
        pictureBox1.Refresh();
      }
    }

    private void вперёдToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      if (indOfPict < count && indOfPict > -1)
      {
        indOfPict++;
        pictureBox1.Image = images[indOfPict];
        pictureBox1.Refresh();
      }
    }

    protected void Repacking()
    {
      size *= 2;
      Bitmap[] result = new Bitmap[size];
      images.CopyTo(result, 0);
      images = null;
      GC.Collect();
      images = result;
    }


    private void переносToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Transfer();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Rotate();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void щарраToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Щарра();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void прюиттToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Prewitt();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void серыйМирToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new GreyWorld();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
     /* Этот блок кода для горячих клавиш CTRL + Z и CTRL+SHIFT + Z РАБОТАЕТ, но криво :(
      if (e.KeyValue == (char)Keys.ControlKey)
        KeyDown += (s, a) =>
        {
          if (a.KeyValue == (char)Keys.ShiftKey)
            KeyDown += (o, p) =>
            {
              {
                if (p.KeyValue == (char)Keys.Z)
                  //вперёдToolStripMenuItem.PerformClick();
                вперёдToolStripMenuItem_Click(вперёдToolStripMenuItem, null);
              }
            };
        };

      if (e.KeyValue == (char)Keys.ControlKey)
        KeyDown += (s, a) =>
        {
          if (a.KeyValue == (char)Keys.Z)
            //назадToolStripMenuItem.PerformClick();
            назадToolStripMenuItem_Click(назадToolStripMenuItem, null);
        };
     */
      if(e.KeyValue == (char)Keys.Z) назадToolStripMenuItem_Click(назадToolStripMenuItem, null);
      if (e.KeyValue == (char)Keys.X) вперёдToolStripMenuItem_Click(вперёдToolStripMenuItem, null);
      if (e.KeyValue == (char)Keys.S) сохранитьКакToolStripMenuItem_Click(сохранитьКакToolStripMenuItem, null);
    }

    private void волныToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Waves();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Glass_effect();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void расширениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Dilation();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }

    private void сужениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (indOfPict > -1)
      {
        MyFilters filter = new Erosion();
        backgroundWorker1.RunWorkerAsync(filter);
      }
    }
  }
}
