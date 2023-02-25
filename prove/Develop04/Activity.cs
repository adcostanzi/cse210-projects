

public class Activity
{
    protected string _activityName;
    protected string _startingMessage;

    protected int _activityDuration;


    public Activity(string activityName, string startingMessage)
    {
        _activityName = activityName;
        _startingMessage = startingMessage;
    }

    protected void GetActivityDuration()
    {
        int duration;
        Console.Write("How long should this activity last (in seconds)? ");
        duration = int.Parse(Console.ReadLine());
        _activityDuration = duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_activityName}!");
        Console.WriteLine($"\n{_startingMessage}\n");
    }

    protected void PreSetActivity()
    {
        this.DisplaySpinner(2);
        Console.WriteLine("\nPrepare to begin the activity...");
        this.Countdown(3);
    }

    protected void DisplaySpinner(int duration)
    {
        DateTime now = DateTime.Now;
        DateTime futureTime = now.AddSeconds(duration);
        do
        {
            Console.Write("|");
            Thread.Sleep(700);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(700);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(700);
            Console.Write("\b \b");
            now = DateTime.Now;
        } while (futureTime > now);
        
    }

    public void LoadActivity()
    {
        DisplayStartingMessage();
        GetActivityDuration();
        PreSetActivity();

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job!!\n");
        this.DisplaySpinner(3);
        Console.WriteLine($"You have done the {_activityName} for {_activityDuration} seconds!\n");
        this.DisplaySpinner(5);
    }

    protected void Countdown(int duration)
    {
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration --;
        }
    }

    protected int GenerateRandomNumber(List<string> list)
    {
        int limit = list.Count;
        Random random = new Random();
        int number = random.Next(0, limit);
        return number;
    }
}