using System;

public class Cycling : Activity
{
    private double _speed { get; set; }

    public Cycling (double length, double speed) : base (length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        double distance = Math.Round(GetLength() * CalculateSpeed() / 60, 1);
        return distance;
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 1);
    }


}