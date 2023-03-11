public class Goal
{
    protected string _name;

    protected string _description;

    protected int _pointsValue;

    protected bool _isCompleted = false;

    protected string _status;


    public Goal(string name, string description, int points)
    {
        _name = name;

        _description = description;

        _pointsValue = points;
    }

    protected virtual void SetStatus()
    {
        if (_isCompleted == true)
        {
            _status = "X";
        }
        else
        {
            _status = " ";
        }

    }
    public virtual void DisplayGoal()
    {
        SetStatus();
        Console.WriteLine($"[{_status}] {_name} ({_description})");
    }

    public void ChangeToCompleteStatus()
    {
        _isCompleted = true;
    }
    public virtual int CompleteGoal()
    {
        if (_isCompleted == false)
        {
            _isCompleted = true;
            return _pointsValue;
        }
        else 
        {
            Console.WriteLine("\nGoal has already been completed!");
            return 0;
        }
        
    }

    public bool IsGoalComplete()
    {
        return _isCompleted;
    }

    public virtual string SaveGoalAsString()
    {
        string type = GetType().ToString();
        string goalAsString = type + "&" + _name + "&" + _description + "&" + _pointsValue + "&" + _isCompleted;
        
        return goalAsString;
    }
}