using System;

using Ksp.Common.Collections.Concurrent;

namespace Ksp.BLL
{
  /// <summary>
  /// Будем считать объектом бизнес логики для первой задачи про очередь
  /// </summary>
  public class TaskQueueObj
  {
    private BlockingQueue<int> q = new BlockingQueue<int>();
    private System.Threading.Timer timer = null;

    public void PushRandomNumber()
    {
      q.push((new Random()).Next(11, 99) % 10);
    }
    public int Pop()
    {
      return q.pop();
    }
    private void TimerProc(object state)
    {
      PushRandomNumber();
    }
    #region Constructors
    /// <summary>
    /// Каждые пять секунд push число в очередь - поведение по умолчанию для примера
    /// </summary>
    public TaskQueueObj()
    {
      timer = new System.Threading.Timer(TimerProc, null, 2000, 5000);
    }
    #endregion
  }
}
