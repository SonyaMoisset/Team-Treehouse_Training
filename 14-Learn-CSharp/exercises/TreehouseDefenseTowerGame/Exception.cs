namespace TreehouseDefense
{
  class TreehouseDefenseException : System.Exception
  {
    public TreehouseDefenseException()
    {}

    public TreehouseDefenseException(string message) : base(message)
    {}
  }

  class OutOfBoundsException : TreehouseDefenseException
  {
    public OutOfBoundsException()
    {}

    public OutOfBoundsException(string message) : base(message)
  }

  class TowerOnPathException : TreehouseDefenseException
  {
    public TowerOnPathException(Point location) : base(location.ToString())
    {}
  }

  class PathInvalidException : TreehouseDefenseException
  {
    public PathInvalidException(string message) : base(message)
    {}
  }
}
