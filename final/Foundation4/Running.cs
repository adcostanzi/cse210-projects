  class Running : Activity
{
    private float _distance;



    public Running()
    {
        _name = "Running";
        Console.Write("What was the distance run (in kms)? ");
        float distance = float.Parse(Console.ReadLine());

        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        float speed = (_distance / _length) * 60;
        return speed;
    }

    public override float GetPace()
    {
        float pace = _length / _distance;
        return pace;
    }
}