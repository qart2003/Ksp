using System;
using System.Collections.Generic;
using System.Threading;

namespace Ksp.Common.Collections.Concurrent
{
  /// <summary>
  /// Очередь безопасная для потоков, внутри использует SemaphoreSlim - делает эффективнм использование Monitor через lock
  /// Имена методов названы в регистре и в соответствии как указано в условии задачи
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class BlockingQueue<T>
  {
    #region Private
    private Queue<T> _queue = new Queue<T>();
    private SemaphoreSlim _sem = new SemaphoreSlim(0, Int32.MaxValue);
    #endregion
    public void push(T item)
    {
      lock (_queue)
      {
        _queue.Enqueue(item);
      }
      _sem.Release();
    }

    public T pop()
    {
      _sem.Wait();
      lock (_queue)
      {
        return _queue.Dequeue();
      }
    }
  }
}
