namespace Treehouse.FitnessFrog.Models
{
  /// <summary>
  /// Represents a physical activity.
  /// </summary>
  public class Activity
  {
    /// <summary>
    /// The list of activity types.
    /// </summary>
    public enum ActivityType
    {
      Basketball = 1,
      Biking = 2,
      Hiking = 3,
      Kayaking = 4,
      PokemonGo = 5,
      Running = 6,
      Skiing = 7,
      Swimming = 8,
      Walking = 9,
      WeightLifting = 10
    }

  /// <summary>
  /// Constructors an activity for the provided activity type and name.
  /// </summary>
  /// <param name="activityType">The activity type for the activity.</param>
  /// <param name="name">The name for the activity.</param>
    public Activity(ActivityType activityType, string name = null)
    {
      Id = (int)activityType;

      Name = name ?? activityType.ToString();
    }

    /// <summary>
    /// The ID of the activity.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name of the activity.
    /// </summary>
    public string Name { get; set; }
  }
}
