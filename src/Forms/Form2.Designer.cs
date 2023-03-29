
namespace Computer_graphics_Lab_1
{
  partial class SetKernel
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.BackColor = System.Drawing.SystemColors.Info;
      this.button1.Location = new System.Drawing.Point(280, 304);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(90, 37);
      this.button1.TabIndex = 0;
      this.button1.Text = "Отмена";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button2.BackColor = System.Drawing.SystemColors.Info;
      this.button2.Location = new System.Drawing.Point(184, 304);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(90, 37);
      this.button2.TabIndex = 1;
      this.button2.Text = "Ок";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
      this.textBox1.Location = new System.Drawing.Point(35, 92);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(312, 204);
      this.textBox1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(31, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(321, 24);
      this.label1.TabIndex = 4;
      this.label1.Text = "Введите структурный элемент:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // SetKernel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlLight;
      this.ClientSize = new System.Drawing.Size(382, 353);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(550, 450);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(400, 400);
      this.Name = "SetKernel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Задать структурный элемент";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
  }
}