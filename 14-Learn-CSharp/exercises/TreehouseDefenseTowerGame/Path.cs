using System;

namespace TreehouseDefense
{
  class Path
  {
    private readonly MapLocation[] _path;
    public int Length => _path.Length;

    public Path(MapLocation[] path)
    {
      _path = path;
      ValidatePath();
    }

    private void ValidatePath()
    {
      for(int i = 0; i < Length; ++i)
      {
        var loc = _path[i];
        if(Array.IndexOf(_path, loc, 0, i) != -1 ||
           Array.IndexOf(_path, loc, i+1, Length-i-1) != -1)
           {
             throw new PathInvalidException(loc + " is on the path twice.");
           }
      }

      for (int i = 0; i < Length-1; i++)
      {
        var curPos = _path[i];
        var nextPos = _path[i+1];
        if (!(Math.Abs(curPos.X - nextPos.X) == 1 ^ Math.Abs(curPos.Y - nextPos.Y) == 1))
        {
          throw new PathInvalidException(curPos + " -> " + nextPos + " i snot a valid transition.");
        }
      }
    }

    public MapLocation this[int pathStep]
    {
      get { return GetLocationAt(pathStep); }
    }

    public bool OnPath(MapLocation location)
    {
      foreach (MapLocation pathLocation in _path)
      {
        if(location.X == pathLocation.X && location.Y == pathLocation.Y)
        {
          return true;
        }
      }

      return false;
    }
  }
}
