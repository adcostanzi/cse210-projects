public class Achievement
{
    private int _level;
    private string _description;
    private int _limit;
    private int _bonus;
    private bool _isComplete;

    public Achievement(int level, string description, int limit, int bonus, bool status = false)
    {
        _level = level;
        _description = description;
        _limit = limit;
        _bonus = bonus;
        _isComplete = status;
    }
    public bool IsComplete()
    {
        return _isComplete;
    }

    public void CompleteStatus()
    {
        _isComplete = true;
    }
    public bool CheckLimit(int points)
    {
        if (_limit <= points)
        {
            _isComplete = true;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAchievement()
    {
        Console.WriteLine($"Level {_level}: {_description}");
    }

    public bool DisplayAchievementOption7()
    {
        if (_isComplete == true)
        {
            Console.WriteLine($"Level {_level}: Completed");
            return true;
        }
        else
        {
            Console.WriteLine($"Level {_level}: In progress");
            return false;
        }
        
    }

    public int GetLimit()
    {
        return _limit;
    }
    public int GetBonusPoints()
    {
        return _bonus;
    }

    public string GetLevel()
    {
        string level = _level.ToString();
        return level;
    }

    public string SaveAchievementAsString()
    {
        string type = GetType().ToString();
        string achievementAsString = type + "&" + _level + "&" + _description + "&" + _limit + "&" + _bonus + "&" +_isComplete;   
        return achievementAsString;     
    }
}
