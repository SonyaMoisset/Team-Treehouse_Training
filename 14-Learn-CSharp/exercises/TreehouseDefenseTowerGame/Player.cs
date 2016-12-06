namespace TreehouseDefense
{
  class Player
  {
    public string Name { get { return _name; } }
    private readonly string _name;

    public int Level { get; private set; }

    public Player(string name)
    {
      _name = name;
    }
  }
}
