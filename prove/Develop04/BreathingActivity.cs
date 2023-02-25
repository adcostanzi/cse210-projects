public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName = "breathing activity", string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") : base(activityName, description)
    {
        
    }

    public void PerformBreathingActivity()
    {
        DateTime now = DateTime.Now;
        DateTime futureTime = now.AddSeconds(_activityDuration);
        do
        {
            Console.Write("\nBreath in... ");
            this.Countdown(5);
            now = DateTime.Now;
            if (futureTime <= now)
            {
                break;
            }
            Console.Write("\nBreath out... ");
            this.Countdown(7);
            now = DateTime.Now;

        } while (futureTime > now);
        
        Console.WriteLine("\n");
    }

    
}