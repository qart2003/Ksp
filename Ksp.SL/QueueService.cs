
using Ksp.BLL;

namespace Ksp.SL
{
  /// <summary>
  /// Класс для связи UI - app and BLL/DAL/...
  /// В данном случае потокобезопасная очередь
  /// </summary>
  public class QueueService
  {
    private TaskQueueObj q { get; set; }
    public QueueService()
    {
      q = new TaskQueueObj();
    }
    public void PushRandomNumber()
    {
      q.PushRandomNumber();
    }
    public int Pop()
    {
      return q.Pop();
    }
  }
}
