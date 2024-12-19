using System;

public abstract class Activity
{
    private string _date { get; set; }
    private double _length { get; set; }

    public Activity(double length)
    {
        _length = length;
    }

    public string GetDate()
    {
        return "";
    }

    public double GetLength()
    {
        return 2.3;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract void DisplaySummary();
}