public class ChecklistGoal : Goal
{
    private int _bonusPoints;

    private int _bonusTimes;

    private int _currentStatus = 0;

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int bonusTimes, int status = 0) : base(name,description,points)
    {
        _bonusPoints = bonusPoints;

        _bonusTimes = bonusTimes;

        _currentStatus = status;
    }

    public override void DisplayGoal()
    {
        base.SetStatus();
        Console.WriteLine($"[{_status}] {_name} ({_description}) Completed {_currentStatus}/{_bonusTimes}");
    }

    public override int CompleteGoal()
    {
        if (_currentStatus == _bonusTimes)
        {
            Console.WriteLine("Goal has already been completed!");
            return 0;
        }
        else
        {
            _currentStatus ++;
            if (_currentStatus == _bonusTimes)
            {
                _isCompleted = true;
                return _pointsValue + _bonusPoints;
            }
            return _bonusPoints;
        }
    }

    public override string SaveGoalAsString()
    {
        string type = GetType().ToString();
        string goalAsString = type + "&" + _name + "&" + _description + "&" + _pointsValue + "&" + _bonusPoints + "&" + _bonusTimes + "&" + _currentStatus + "&" + _isCompleted;
        
        return goalAsString;
    }
}