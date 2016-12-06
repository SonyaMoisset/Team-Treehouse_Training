namespace TreehouseDefense
{
  class MapLocation : Point
  {
    protected MapLocation(int x, int y) : base(x, y)
    {}

      public MapLocation(int x, int y, Map map) : this(x, y)
      {
        if (!map.OnMap(this))
        {
          throw new OutOfBoundsException(x + "," + y + " is out of bounds of the map.");
        }
      }

      public bool InRangeOf(MapLocation locationm int range)
      {
        return DistanceTo(location) <= range;
      }
  }
}
