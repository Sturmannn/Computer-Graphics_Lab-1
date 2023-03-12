
namespace Computer_graphics_Lab_1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.вперёдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.инверсияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.чёрнобелыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.размытиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.размытиеГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.собельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.повышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.щарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.прюиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.pictureBox1.Location = new System.Drawing.Point(0, 33);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1068, 506);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1068, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.вперёдToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
      // 
      // сохранитьКакToolStripMenuItem
      // 
      this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
      this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
      this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
      this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
      // 
      // назадToolStripMenuItem
      // 
      this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
      this.назадToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
      this.назадToolStripMenuItem.Text = "Назад";
      this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
      // 
      // вперёдToolStripMenuItem
      // 
      this.вперёдToolStripMenuItem.Name = "вперёдToolStripMenuItem";
      this.вперёдToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
      this.вперёдToolStripMenuItem.Text = "Вперёд";
      this.вперёдToolStripMenuItem.Click += new System.EventHandler(this.вперёдToolStripMenuItem_Click);
      // 
      // фильтрыToolStripMenuItem
      // 
      this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
      this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
      this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
      this.фильтрыToolStripMenuItem.Text = "Фильтры";
      // 
      // точечныеToolStripMenuItem
      // 
      this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem1,
            this.чёрнобелыйToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem,
            this.переносToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.серыйМирToolStripMenuItem});
      this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
      this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.точечныеToolStripMenuItem.Text = "Точечные";
      // 
      // инверсияToolStripMenuItem1
      // 
      this.инверсияToolStripMenuItem1.Name = "инверсияToolStripMenuItem1";
      this.инверсияToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
      this.инверсияToolStripMenuItem1.Text = "Инверсия";
      this.инверсияToolStripMenuItem1.Click += new System.EventHandler(this.инверсияToolStripMenuItem1_Click);
      // 
      // чёрнобелыйToolStripMenuItem
      // 
      this.чёрнобелыйToolStripMenuItem.Name = "чёрнобелыйToolStripMenuItem";
      this.чёрнобелыйToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.чёрнобелыйToolStripMenuItem.Text = "Чёрно-белый";
      this.чёрнобелыйToolStripMenuItem.Click += new System.EventHandler(this.чёрнобелыйToolStripMenuItem_Click);
      // 
      // сепияToolStripMenuItem
      // 
      this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
      this.сепияToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.сепияToolStripMenuItem.Text = "Сепия";
      this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
      // 
      // увеличениеЯркостиToolStripMenuItem
      // 
      this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
      this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение Яркости";
      this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
      // 
      // переносToolStripMenuItem
      // 
      this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
      this.переносToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.переносToolStripMenuItem.Text = "Перенос";
      this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click);
      // 
      // поворотToolStripMenuItem
      // 
      this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
      this.поворотToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.поворотToolStripMenuItem.Text = "Поворот";
      this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
      // 
      // матричныеToolStripMenuItem
      // 
      this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem1,
            this.размытиеГауссаToolStripMenuItem,
            this.собельToolStripMenuItem,
            this.повышениеРезкостиToolStripMenuItem,
            this.щарраToolStripMenuItem,
            this.прюиттToolStripMenuItem});
      this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
      this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
      this.матричныеToolStripMenuItem.Text = "Матричные";
      // 
      // размытиеToolStripMenuItem1
      // 
      this.размытиеToolStripMenuItem1.Name = "размытиеToolStripMenuItem1";
      this.размытиеToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
      this.размытиеToolStripMenuItem1.Text = "Размытие";
      this.размытиеToolStripMenuItem1.Click += new System.EventHandler(this.размытиеToolStripMenuItem1_Click);
      // 
      // размытиеГауссаToolStripMenuItem
      // 
      this.размытиеГауссаToolStripMenuItem.Name = "размытиеГауссаToolStripMenuItem";
      this.размытиеГауссаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
      this.размытиеГауссаToolStripMenuItem.Text = "Размытие Гаусса";
      this.размытиеГауссаToolStripMenuItem.Click += new System.EventHandler(this.размытиеГауссаToolStripMenuItem_Click);
      // 
      // собельToolStripMenuItem
      // 
      this.собельToolStripMenuItem.Name = "собельToolStripMenuItem";
      this.собельToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
      this.собельToolStripMenuItem.Text = "Собель";
      this.собельToolStripMenuItem.Click += new System.EventHandler(this.собельToolStripMenuItem_Click);
      // 
      // повышениеРезкостиToolStripMenuItem
      // 
      this.повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
      this.повышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
      this.повышениеРезкостиToolStripMenuItem.Text = "Повышение Резкости";
      this.повышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеРезкостиToolStripMenuItem_Click);
      // 
      // щарраToolStripMenuItem
      // 
      this.щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
      this.щарраToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
      this.щарраToolStripMenuItem.Text = "Щарра";
      this.щарраToolStripMenuItem.Click += new System.EventHandler(this.щарраToolStripMenuItem_Click);
      // 
      // прюиттToolStripMenuItem
      // 
      this.прюиттToolStripMenuItem.Name = "прюиттToolStripMenuItem";
      this.прюиттToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
      this.прюиттToolStripMenuItem.Text = "Прюитт";
      this.прюиттToolStripMenuItem.Click += new System.EventHandler(this.прюиттToolStripMenuItem_Click);
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.WorkerSupportsCancellation = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(903, 546);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(150, 30);
      this.button1.TabIndex = 2;
      this.button1.Text = "Отмена";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.Location = new System.Drawing.Point(12, 545);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(885, 30);
      this.progressBar1.TabIndex = 3;
      // 
      // серыйМирToolStripMenuItem
      // 
      this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
      this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
      this.серыйМирToolStripMenuItem.Text = "Серый мир";
      this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1068, 587);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(350, 350);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Фильтры";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem размытиеГауссаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem чёрнобелыйToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem собельToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem повышениеРезкостиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem вперёдToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem щарраToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem прюиттToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
  }
}

