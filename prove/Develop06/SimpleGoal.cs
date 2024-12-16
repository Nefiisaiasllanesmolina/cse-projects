public class SimpleGoal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
    {
        string _goal = $"{name}, ({description}, {points})";
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