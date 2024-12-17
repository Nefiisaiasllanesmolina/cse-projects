public class SimpleGoal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    {
        string _goal = $"{name}, {description}, {points}";
        GoalManager goal = new GoalManager();
        goal.Start();
    }

    public void RecordEvent()
    {
        Console.WriteLine($"");
    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetStringRepresentation()
    {
        return "";
    }
}