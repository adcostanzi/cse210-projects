public class ActivityHandler
{
    private List<Activity> _activities = new List<Activity>();


    public ActivityHandler()
    {

    }

    public void AddActivity(Activity newActivity)
    {
        _activities.Add(newActivity);
    }

    public void DisplayActivities()
    {
        foreach (Activity activity in _activities)
        {
            string summary = activity.GetSummary();
            Console.Write($"\n{summary}\n");
        }
    }
}