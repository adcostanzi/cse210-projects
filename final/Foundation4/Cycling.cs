public class Cycling : Activity
{
    private float _speed;


    public Cycling()
    {
        _name = "Cycling";
        Console.Write("What was the speed (in kph)? ");
        float speed = float.Parse(Console.ReadLine());

        _speed = speed;

    }

    public override float GetDistance()
    {
        float distance = _speed * (_length / 60);
        return distance;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        float pace = _length / GetDistance();
        return pace;
    }
}