using System;
using static System.Math;

namespace TreehouseDefense
{
  class Point
  {
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public int DistanceTo(int x, int y)
    {
      return (int)Sqrt(Pow(X - x, 2) + Pow(Y - y, 2));
    }

    public int DistanceTo(Point point)
    {
      return DistanceTo(point.X, point.Y);
    }

    public override bool Equals(Object obj)
    {
      var point = obj as Point;

      if(point == null)
      {
        return false;
      }

      return this.X == point.X && this.Y == point.Y;
    }

    public override int GetHashCode()
    {
      throw new NotImplementedException();
    }

    public override string ToString() => X + "," + Y;
  }
}
