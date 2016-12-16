using System.Collections.Generic;
using System.Linq;
using Treehouse.FitnessFrog.Models;

namespace Treehouse.FitnessFrog.Data
{
  /// <summary>
  /// Repository for activities.
  /// 
  /// Note: The code in this class is not to be considered a "best practice" 
  /// example of how to do data persistence, but rather as workaround for
  /// not having a database to persist data to.
  /// </summary>
  public class ActivitiesRepository
  {
    /// <summary>
    /// Returns a collection of activities.
    /// </summary>
    /// <returns>A list of activities.</returns>
    public List<Activity> GetActivities()
    {
      return Data.Activities
          .OrderBy(a => a.Name)
          .ToList();
    }
  }
}
