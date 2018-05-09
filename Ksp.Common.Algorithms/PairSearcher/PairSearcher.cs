using System.Collections.Generic;

namespace Ksp.Common.Algorithms.PairSearcher
{
  static public class PairSearcherAlgorithm
  {
    /// <summary>
    /// Оптимизировано на скорость, для больших коллекций ест память
    /// </summary>
    /// <param name="data"></param>
    /// <param name="X"></param>
    /// <returns></returns>
    static public PairSearchResult Search(List<int> data, int X)
    {
      PairSearchResult Result = new PairSearchResult();
      //data.Sort(); 
      //for long collection, SortedList is for short
      Dictionary<int, bool> used = new Dictionary<int, bool>();
      for (int i = 0; i < data.Count - 1; i++)
      {
        if (used.ContainsKey(i))
          continue;
        if (data[i] > X)
        {
          used.Add(i, true);
          continue;
        }

        for (int j = i + 1; j < data.Count; j++)
        {
          if (used.ContainsKey(j))
            continue;
          if (data[j] > X)
          {
            used.Add(j, true);
            continue;
          }

          if (data[i] + data[j] == X)
          {
            Result.Add(new PairItem() { A = data[i], B = data[j] });
            used.Add(i, true);
            used.Add(j, true);
            break;
          }
        }
      }
      return Result;
    }

  }
}
