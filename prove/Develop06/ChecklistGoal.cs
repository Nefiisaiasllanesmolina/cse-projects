using System.ComponentModel;

public class ChecklistGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus)
    {
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return "";
    }

    public string GetStringRepresentation()
    {
        return "";
    }
}