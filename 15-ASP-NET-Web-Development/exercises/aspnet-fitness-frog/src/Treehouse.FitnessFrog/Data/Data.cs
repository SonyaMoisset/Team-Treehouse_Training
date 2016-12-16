using System.Collections.Generic;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Data
{
  /// <summary>
  /// Provides an in-memory data store.
  /// 
  /// Note: The code in this class is not to be considered a "best practice" 
  /// example of how to do data persistence, but rather as workaround for
  /// not having a database to persist data to.
  /// </summary>
  public static class Data
  {
    /// <summary>
    /// The collection of activities.
    /// </summary>
    public static List<Activity> Activities { get; set; }

    /// <summary>
    /// The collection of entries.
    /// </summary>
    public static List<Entry> Entries { get; set; }

    /// <summary>
    /// Static constructor used to initialize the data.
    /// </summary>
    static Data()
    {
        InitData();
    }

    private static void InitData()
    {
      var activities = new List<Activity>()
      {
          new Activity(Activity.ActivityType.Basketball),
          new Activity(Activity.ActivityType.Biking),
          new Activity(Activity.ActivityType.Hiking),
          new Activity(Activity.ActivityType.Kayaking),
          new Activity(Activity.ActivityType.PokemonGo, "Pokemon Go"),
          new Activity(Activity.ActivityType.Running),
          new Activity(Activity.ActivityType.Skiing),
          new Activity(Activity.ActivityType.Swimming),
          new Activity(Activity.ActivityType.Walking),
          new Activity(Activity.ActivityType.WeightLifting, "Weight Lifting")
      };

      var entries = new List<Entry>()
      {
          new Entry(1, 2016, 7, 8, Activity.ActivityType.Biking, 10.0),
          new Entry(2, 2016, 7, 9, Activity.ActivityType.Biking, 12.2),
          new Entry(3, 2016, 7, 10, Activity.ActivityType.Hiking, 123.0),
          new Entry(4, 2016, 7, 12, Activity.ActivityType.Biking, 10.0),
          new Entry(5, 2016, 7, 13, Activity.ActivityType.Walking, 32.2),
          new Entry(6, 2016, 7, 13, Activity.ActivityType.Biking, 13.3),
          new Entry(7, 2016, 7, 14, Activity.ActivityType.Biking, 10.0),
          new Entry(8, 2016, 7, 15, Activity.ActivityType.Walking, 28.6),
          new Entry(9, 2016, 7, 16, Activity.ActivityType.Biking, 12.7),
          new Entry(10, 2016, 7, 16, Activity.ActivityType.PokemonGo, 23.4)
      };

      Activities = activities;
      Entries = entries;
    }
  }
}
