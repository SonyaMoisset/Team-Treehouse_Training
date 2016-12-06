namespace TreehouseDefense
{
  class Level
  {
    protected Map Map { get; }
    protected Path Path { get; }
    protected Invader[] Enemies { get; }
    public Tower[] Towers { get; set; }

    public Level(Map map, Path path, Invader[] enemies)
    {
      Map = map;
      Path = path;
      Enemies = enemies;
    }

    public virtual bool Play()
    {
      int remainingEnemies = Enemies.Length;

      while(remainingEnemies > 0)
      {
        foreach( var tower in Towers)
        {
          tower.FireOnEnemies(Enemies);
        }

        remainingEnemies = 0;

        foreach(var enemy in Enemies)
        {
          if(enemy.IsActive)
          {
            enemy.Move();
            if(enemy.HasScore)
            {
              return true;
            }

            ++remainingEnemies;
          }
        }
      }
      return false;
    }
  }
}
