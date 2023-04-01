public class Swimming : Activity
{
    private int _laps;

    public Swimming()
    {
        _name = "Swimming";
        Console.Write("How many laps did you complete? ");
        int laps = int.Parse(Console.ReadLine());

        _laps = laps;
    }

    public override float GetDistance()
    {
        float distance = (_laps * 50) / 1000f;
        return distance;
    }

    public override float GetSpeed()
    {
        float distance = GetDistance();
        float speed = (distance / _length) * 60;
        return speed;
    }

    public override float GetPace()
    {
        float distance = GetDistance();
        float pace = _length / distance;
        return pace;
    }
}