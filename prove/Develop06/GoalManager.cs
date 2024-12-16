public class GoalManager
{
    List <Goal> _goals;
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine($"\nYou have (aqui va el puntaje) points");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create a New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();

        GoalManager _goal = new GoalManager();
        _goal.CreateGoal();

        if (choice == "1")
        {
            _goal.CreateGoal();
        }
        else if (choice == "2")
        {
            _goal.ListGoalNames();
        }
        else if (choice == "3")
        {
            _goal.SaveGoals();
        }
        else if (choice == "4")
        {
            _goal.LoadGoals();
        }
        else if (choice == "5")
        {
            _goal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Please select a valid option");
        };           
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
            int points1Int = int.Parse(points1);
            EternalGoal simpleGoal1 = new EternalGoal(goalName1, goalDescription1, points1Int);
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
            int points2Int = int.Parse(points2);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            int targetInt = int.Parse(target);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonus = Console.ReadLine();
            int bonusInt = int.Parse(bonus);
            ChecklistGoal simpleGoal2 = new ChecklistGoal(goalName2, goalDescription2, points2Int, targetInt, bonusInt);
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