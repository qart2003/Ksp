using System;
using System.Windows.Forms;

using Ksp.SL;

namespace Ksp.UI
{
  public partial class Form1 : Form
  {
    public ManagerService managerService = new ManagerService();
    public Form1()
    {
      InitializeComponent();
      //timer = new System.Threading.Timer(TimerProc, null, 2000, 5000);
    }
    #region Task 1
    //private BlockingQueue<int> q = new BlockingQueue<int>();
    //private System.Threading.Timer timer = null;

    private void PushRandomNumber()
    {
      //q.push((new Random()).Next(11, 99) % 10);
      managerService.QueueService.PushRandomNumber();
    }
    private void TimerProc(object state)
    {
      PushRandomNumber();
    }
    private void bnPush_Click(object sender, EventArgs e)
    {
      //Добавляет число в очередь каждые пять секунд
      PushRandomNumber();
    }

    private void bnPop_Click(object sender, EventArgs e)
    {
      //Все повесит если очередь пуста, но не на долго тк таймер каждые пять секунд в очередь добавляет число
      MessageBox.Show(managerService.QueueService.Pop().ToString());
    }
    #endregion

    #region Task 2

    private void bnRunAlgo_Click(object sender, EventArgs e)
    {
      try
      {
        //var data = eInput.Text.Replace('(', ' ').Replace(')', ' ').Split(',').Select(v => { return int.Parse(v.Trim()); }).ToList();
        //var X = int.Parse(eX.Text.Trim());
        var inputData = managerService.SearchAlgorythmService.FromStrings(eInput.Text, eX.Text);
        //eOutput.Text = PairSearcherAlgorithm.Search(data, X).ToString();
        eOutput.Text = managerService.SearchAlgorythmService.GetAsString(inputData);
      }
      catch (FormatException ex)
      {
        MessageBox.Show("Ошибка в исходных данных! - " + ex.Message);
      }
      catch
      {
        MessageBox.Show("Ошибка в алгоритме!");
      }
    }
    #endregion

  }
}
