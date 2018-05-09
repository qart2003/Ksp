using System.Collections.Generic;
using System.Linq;

using Ksp.BLL;
using Ksp.Common.Algorithms.PairSearcher;

namespace Ksp.SL
{
  /// <summary>
  /// Класс для связи UI - app and BLL/DAL/...
  /// В данном случае алгоритм поиска пар нужной суммы
  /// </summary>
  public class SearchAlgorythmService
  {
    public TaskSearchAlgorythmObj FromStrings(string data, string X)
    {
      var o_data = data.Replace('(', ' ').Replace(')', ' ').Split(',').Select(v => { return int.Parse(v.Trim()); }).ToList();
      var o_X = int.Parse(X.Trim());
      return new TaskSearchAlgorythmObj() { Input = o_data, X = o_X };
    }
    public PairSearchResult Get(List<int> data, int X)
    {
      return PairSearcherAlgorithm.Search(data, X);
    }
    public PairSearchResult Get(TaskSearchAlgorythmObj data)
    {
      return Get(data.Input, data.X);
    }
    public string GetAsString(List<int> data, int X)
    {
      return PairSearcherAlgorithm.Search(data, X).ToString();
    }
    public string GetAsString(TaskSearchAlgorythmObj data)
    {
      return Get(data.Input, data.X).ToString();
    }
  }
}
