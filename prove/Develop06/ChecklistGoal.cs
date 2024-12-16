using System.ComponentModel;

public class ChecklistGoal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        _target = target;
        _bonus = bonus;

        string _goal = $"{name}, ({description}, {points}) {_target} {_bonus}";
        GoalManager goal = new GoalManager();
        goal.Start();
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