namespace TreehouseDefense
{
  class PowerfulTower : Tower
  {
    protected override int Power { get; } = 2;

    public PowerfulTower(MapLocation Location) : base(Location)
    {}
  }
}
