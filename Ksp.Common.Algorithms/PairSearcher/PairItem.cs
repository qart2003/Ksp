namespace Ksp.Common.Algorithms.PairSearcher
{
  public class PairItem
  {
    /// <summary>
    /// Элемент результата работы алгоритма
    /// </summary>
    public int A { get; set; }
    public int B { get; set; }
    public override string ToString()
    {
      return $"({A}, {B})";
    }
  }
}