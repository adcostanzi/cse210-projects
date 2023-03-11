public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }


    protected override void SetStatus()
    {
        _status = "\u221E";
    }
    public override int CompleteGoal()
    {
        return _pointsValue;
    }
}