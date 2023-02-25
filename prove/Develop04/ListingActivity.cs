public class ListingActivity : Activity
{
    private List<string> _promptsToList = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _promptsToListTracker = new List<string>();
    private List<string> _listingItems = new List<string>();

    public ListingActivity(string activityName = "listing activity", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(activityName, description)
    {
        
    } 

    public void DisplayPrompt()
    {
        bool isNew;
        int number;
      
        if (this._promptsToListTracker.Count == this._promptsToList.Count)
        {
            Console.WriteLine("\nAll prompts have been used, they will start to repeat.");
            this._promptsToListTracker.Clear();
        }
        do
        {
            number = this.GenerateRandomNumber(_promptsToList);
            string test = _promptsToList[number];
            isNew = _promptsToListTracker.Contains(test);
            if (isNew == false)
            {
                _promptsToListTracker.Add(test);
            }
        } while (isNew == true);

        string toShow = _promptsToList[number];
        Console.WriteLine("\n" + toShow);
    }

    public void PerformListingActivity()
    {
        DisplayPrompt();
        Countdown(8);
        Console.WriteLine("\nList as many ideas as you can: \n");
        DateTime now = DateTime.Now;
        DateTime futureTime = now.AddSeconds(_activityDuration);
        do
        {
            AddListingItem();
            now = DateTime.Now;
        } while (futureTime > now);
        DisplayListCount();
        
    }

    public void AddListingItem()
    {
        Console.Write("Your idea: ");
        string idea = Console.ReadLine();
        _listingItems.Add(idea);
        Console.WriteLine("Added to list!");
    }

    public void DisplayListCount()
    {
        int listCount = _listingItems.Count;
        Console.WriteLine($"\nYou added {listCount} items to your list!\n");
        _listingItems.Clear();
    }
}