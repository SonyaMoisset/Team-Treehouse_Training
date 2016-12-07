namespace TreehouseDefense
{
  class LongeRangeTower : Tower
  {
    protected override int Range { get; } = 3;

    public LongeRangeTower(MapLocation location) : base(location)
    {}
  }
}
