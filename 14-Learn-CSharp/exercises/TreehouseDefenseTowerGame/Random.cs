namespace TreehouseDefense
{
  static class Random
  {
    private static readonly System.Random _random = new System.Random();

    public static double NextDouble() => _random.NextDouble();
  }
}
