public class ReflectionActivity : Activity
{

    private List<string> _promptTracker = new List<string>();

    private List<string> _questionTracker = new List<string>();
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    
    private List<string> _questions = new List<string> 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public ReflectionActivity(string activityName = "reflection activity", string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(activityName, description)
    {
        
    }

    public void LoadRandomPrompt()
    {
        bool isNew;
        int number;
      
        if (this._promptTracker.Count == this._prompts.Count)
        {
            Console.WriteLine("All prompts have been used, they will start to repeat.\n");
            this._promptTracker.Clear();
        }
        do
        {
            number = this.GenerateRandomNumber(this._prompts);
            string test = _prompts[number];
            isNew = _promptTracker.Contains(test);
            if (isNew == false)
            {
                _promptTracker.Add(test);
            }
        } while (isNew == true);

        string prompt = _prompts[number];
        Console.WriteLine("\n" + prompt +"\n");
        this.DisplaySpinner(7);
    }

    public void LoadRandomQuestion()
    {
        bool isNew;
        int number;
      
        if (this._questionTracker.Count == this._questions.Count)
        {
            Console.WriteLine("All questions have been used, they will start to repeat.");
            this._questionTracker.Clear();
        }
        do
        {
            number = this.GenerateRandomNumber(_questions);
            string test = _questions[number];
            isNew = _questionTracker.Contains(test);
            if (isNew == false)
            {
                _questionTracker.Add(test);
            }
        } while (isNew == true);
        
        string question = _questions[number];
        Console.WriteLine(question+"\n");
        this.DisplaySpinner(7);
    }

    

    public void PerformReflectionActivity()
    {
        LoadRandomPrompt();
        DateTime now = DateTime.Now;
        DateTime futureTime = now.AddSeconds(_activityDuration);
        do
        {
            LoadRandomQuestion();
            now = DateTime.Now;

        } while (futureTime > now);
        

    }
} 