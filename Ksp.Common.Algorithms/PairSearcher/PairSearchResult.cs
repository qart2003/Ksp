using System.Collections.Generic;

namespace Ksp.Common.Algorithms.PairSearcher
{
  public class PairSearchResult : List<PairItem>
  {
    /// Результат поиска - коллекция именно List, для алгоритма
    public override string ToString()
    {
      return string.Join(", ", this);
    }
  }
}
