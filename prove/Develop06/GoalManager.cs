public class GoalManager
{
    List <Goal> _goals;
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");

        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
            simpleGoal.RecordEvent();
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string goalName1 = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription1 = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points1 = Console.ReadLine();
            SimpleGoal simpleGoal1 = new SimpleGoal(goalName1, goalDescription1, points1);
            simpleGoal1.RecordEvent();
        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string goalName2 = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription2 = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points2 = Console.ReadLine();
            SimpleGoal simpleGoal2 = new SimpleGoal(goalName2, goalDescription2, points2);
            simpleGoal2.RecordEvent();
        }
        else
        {
            Console.WriteLine("Please select a valid goal type");
        }
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}