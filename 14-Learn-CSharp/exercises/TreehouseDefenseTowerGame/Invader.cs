namespace TreehouseDefense
{
  abstract class Invader
  {
    private readonly Path _path;
    private int _pathStep = 0;

    public Invader(Path path)
    {
      _path = path;
    }

    public MapLocation Location => _path.GetLocationAt(_pathStep)l;

    public bool IsActive => Health > 0 && !HasScored;
    public bool HasScored => _pathStep >= _path.Length;

    protected abstract int Health { get; set; }

    protected virtual void DecreaseHealth(int factor)
    {
      Health -= factor;
    }

    public void Move()
    {
      _pathStep += StepSize;
    }

    sealed class ShieldedInvader: Invader
    {
      public ShieldedInvader(Path path) : base(path)
      {}

      protected override int Health { get; set; } = 10;

      protected override int StepSize { get { return 1; } }

      public override void DecreaseHealth(int factor)
      {
        if (Random.NextDouble() < .5)
        {
          base.DecreaseHealth(factor);
        }
      }
    }

    class StandardInvader: Invader
    {
      public StandardInvader(Path path) : base(path)
      {}

      protected override int Health { get; set; } = 1;

      protected override int StepSize { get { return _StepSize; } }

      private const int _StepSize = 1;
    }

    class CustomerInvader: Invader
    {
      public CustomerInvader(Path part, int healt, int StepSize) : base(path)
      {
        Healt = health;
        _StepSize = stepSize;
      }

      protected override int Health { get; set; }

      protected override int StepSize { get; private set; }
      private readonly int _StepSize;
    }

    class StrongInvader: Invader
    {
      public StrongInvader(Path path) : base(path)
      {}

      protected override int Health { get; set; } = 10;

      protected override int StepSize { get { return 1; } }
    }

    class FastInvader: Invader
    {
      public FastInvader(Path path) : base(path)
      {}

      protected override int Health { get; set; } = 1;

      protected override int StepSize { get { return _StepSize; } }
      private const int _StepSize = 2;
    }
}
