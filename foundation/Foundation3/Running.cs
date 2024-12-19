using System;

public class Running : Activity
{
    private double _distance { get; set; }

    public Running(double length, double distance) : base(length)
    {
        _distance = distance;
    }
}