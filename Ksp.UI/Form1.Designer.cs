namespace Ksp.UI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.bnPush = new System.Windows.Forms.Button();
      this.bnPop = new System.Windows.Forms.Button();
      this.lTask1 = new System.Windows.Forms.Label();
      this.eInput = new System.Windows.Forms.TextBox();
      this.eOutput = new System.Windows.Forms.TextBox();
      this.lInput = new System.Windows.Forms.Label();
      this.lOutput = new System.Windows.Forms.Label();
      this.bnRunAlgo = new System.Windows.Forms.Button();
      this.eX = new System.Windows.Forms.TextBox();
      this.lX = new System.Windows.Forms.Label();
      this.eTask1 = new System.Windows.Forms.TextBox();
      this.lSeparatorTasks = new System.Windows.Forms.Label();
      this.eTask2 = new System.Windows.Forms.TextBox();
      this.eTask1TimerComment = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // bnPush
      // 
      this.bnPush.Location = new System.Drawing.Point(24, 167);
      this.bnPush.Name = "bnPush";
      this.bnPush.Size = new System.Drawing.Size(333, 23);
      this.bnPush.TabIndex = 0;
      this.bnPush.Text = "Push ( random int value < 10 into q )";
      this.bnPush.UseVisualStyleBackColor = true;
      this.bnPush.Click += new System.EventHandler(this.bnPush_Click);
      // 
      // bnPop
      // 
      this.bnPop.Location = new System.Drawing.Point(362, 167);
      this.bnPop.Name = "bnPop";
      this.bnPop.Size = new System.Drawing.Size(424, 23);
      this.bnPop.TabIndex = 1;
      this.bnPop.Text = "Pop and Show (first value from q) or waiting (click faster) if q is empty";
      this.bnPop.UseVisualStyleBackColor = true;
      this.bnPop.Click += new System.EventHandler(this.bnPop_Click);
      // 
      // lTask1
      // 
      this.lTask1.AutoSize = true;
      this.lTask1.Location = new System.Drawing.Point(24, 98);
      this.lTask1.Name = "lTask1";
      this.lTask1.Size = new System.Drawing.Size(567, 13);
      this.lTask1.TabIndex = 2;
      this.lTask1.Text = "\'q\' is BlockingQueue<T> from Ksp.Common.Collections.Concurrent. Internal are Sema" +
    "phoreSlim and lock for Queue<T>";
      // 
      // eInput
      // 
      this.eInput.Location = new System.Drawing.Point(21, 307);
      this.eInput.Name = "eInput";
      this.eInput.Size = new System.Drawing.Size(760, 20);
      this.eInput.TabIndex = 4;
      this.eInput.Text = "(1,1,2,1,1,0,1)";
      // 
      // eOutput
      // 
      this.eOutput.Location = new System.Drawing.Point(18, 418);
      this.eOutput.Name = "eOutput";
      this.eOutput.Size = new System.Drawing.Size(760, 20);
      this.eOutput.TabIndex = 5;
      // 
      // lInput
      // 
      this.lInput.AutoSize = true;
      this.lInput.Location = new System.Drawing.Point(21, 292);
      this.lInput.Name = "lInput";
      this.lInput.Size = new System.Drawing.Size(31, 13);
      this.lInput.TabIndex = 6;
      this.lInput.Text = "Input";
      // 
      // lOutput
      // 
      this.lOutput.AutoSize = true;
      this.lOutput.Location = new System.Drawing.Point(19, 402);
      this.lOutput.Name = "lOutput";
      this.lOutput.Size = new System.Drawing.Size(39, 13);
      this.lOutput.TabIndex = 7;
      this.lOutput.Text = "Output";
      // 
      // bnRunAlgo
      // 
      this.bnRunAlgo.Location = new System.Drawing.Point(18, 361);
      this.bnRunAlgo.Name = "bnRunAlgo";
      this.bnRunAlgo.Size = new System.Drawing.Size(762, 32);
      this.bnRunAlgo.TabIndex = 8;
      this.bnRunAlgo.Text = "Algo run!";
      this.bnRunAlgo.UseVisualStyleBackColor = true;
      this.bnRunAlgo.Click += new System.EventHandler(this.bnRunAlgo_Click);
      // 
      // eX
      // 
      this.eX.Location = new System.Drawing.Point(50, 335);
      this.eX.Name = "eX";
      this.eX.Size = new System.Drawing.Size(100, 20);
      this.eX.TabIndex = 9;
      this.eX.Text = "2";
      // 
      // lX
      // 
      this.lX.AutoSize = true;
      this.lX.Location = new System.Drawing.Point(18, 338);
      this.lX.Name = "lX";
      this.lX.Size = new System.Drawing.Size(26, 13);
      this.lX.TabIndex = 10;
      this.lX.Text = "X = ";
      // 
      // eTask1
      // 
      this.eTask1.Location = new System.Drawing.Point(27, 12);
      this.eTask1.Multiline = true;
      this.eTask1.Name = "eTask1";
      this.eTask1.ReadOnly = true;
      this.eTask1.Size = new System.Drawing.Size(762, 69);
      this.eTask1.TabIndex = 11;
      this.eTask1.Text = resources.GetString("eTask1.Text");
      // 
      // lSeparatorTasks
      // 
      this.lSeparatorTasks.AutoSize = true;
      this.lSeparatorTasks.Location = new System.Drawing.Point(24, 193);
      this.lSeparatorTasks.Name = "lSeparatorTasks";
      this.lSeparatorTasks.Size = new System.Drawing.Size(763, 13);
      this.lSeparatorTasks.TabIndex = 12;
      this.lSeparatorTasks.Text = "_________________________________________________________________________________" +
    "_____________________________________________";
      // 
      // eTask2
      // 
      this.eTask2.Location = new System.Drawing.Point(24, 220);
      this.eTask2.Multiline = true;
      this.eTask2.Name = "eTask2";
      this.eTask2.ReadOnly = true;
      this.eTask2.Size = new System.Drawing.Size(762, 69);
      this.eTask2.TabIndex = 13;
      this.eTask2.Text = resources.GetString("eTask2.Text");
      // 
      // eTask1TimerComment
      // 
      this.eTask1TimerComment.Location = new System.Drawing.Point(27, 115);
      this.eTask1TimerComment.Multiline = true;
      this.eTask1TimerComment.Name = "eTask1TimerComment";
      this.eTask1TimerComment.ReadOnly = true;
      this.eTask1TimerComment.Size = new System.Drawing.Size(759, 46);
      this.eTask1TimerComment.TabIndex = 14;
      this.eTask1TimerComment.Text = "По таймеру [timer = new System.Threading.Timer(TimerProc, null, 2000, 5000);] \r\nК" +
    "аждые пять секунд в очередь добавляется число, Pop кнопку для теста нужно нажима" +
    "ть быстрее :)";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(820, 451);
      this.Controls.Add(this.eTask1TimerComment);
      this.Controls.Add(this.eTask2);
      this.Controls.Add(this.lSeparatorTasks);
      this.Controls.Add(this.eTask1);
      this.Controls.Add(this.lX);
      this.Controls.Add(this.eX);
      this.Controls.Add(this.bnRunAlgo);
      this.Controls.Add(this.lOutput);
      this.Controls.Add(this.lInput);
      this.Controls.Add(this.eOutput);
      this.Controls.Add(this.eInput);
      this.Controls.Add(this.lTask1);
      this.Controls.Add(this.bnPop);
      this.Controls.Add(this.bnPush);
      this.Name = "Form1";
      this.Text = "Ksp (отрефакторил под 3-х уровневую архитектуру +-, хотя тут это лишнее)";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button bnPush;
    private System.Windows.Forms.Button bnPop;
    private System.Windows.Forms.Label lTask1;
    private System.Windows.Forms.TextBox eInput;
    private System.Windows.Forms.TextBox eOutput;
    private System.Windows.Forms.Label lInput;
    private System.Windows.Forms.Label lOutput;
    private System.Windows.Forms.Button bnRunAlgo;
    private System.Windows.Forms.TextBox eX;
    private System.Windows.Forms.Label lX;
    private System.Windows.Forms.TextBox eTask1;
    private System.Windows.Forms.Label lSeparatorTasks;
    private System.Windows.Forms.TextBox eTask2;
    private System.Windows.Forms.TextBox eTask1TimerComment;
  }
}

