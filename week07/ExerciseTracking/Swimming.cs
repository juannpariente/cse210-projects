public class Swimming : Activity
{
    private int _swimmingLaps;

    public Swimming(string date, int length, int swimmingLaps) : base(date, length)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double GetDistance()
    {
        return _swimmingLaps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _length) * 60.0;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}