using System.ComponentModel;

public class Goal
{
    private string _shortName { get; }
    private string _description { get; }
    private int _points { get; }
    

    public Goal(string name, string description)
    {
        _shortName = name;
        _description = description;
        GoalManager newGoalManager = new GoalManager();
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return false;
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