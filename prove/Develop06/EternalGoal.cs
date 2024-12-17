public class EternalGoal
{
    public EternalGoal(string name, string description, int points)
    {
        string _goal = $"{name}, {description}, {points}";
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

    public string GetStringRepresentation()
    {
        return "";
    }
}