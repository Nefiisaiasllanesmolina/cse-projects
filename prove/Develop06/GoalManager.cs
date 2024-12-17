using System.Data;

public class GoalManager
{
    List <Goal> _goals = new List<Goal>();
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

        if (choice == "1")
        {
            _goal.CreateGoal();
        }
        else if (choice == "2")
        {
            ListGoalNames();
        }
        else if (choice == "3")
        {
            SaveGoals();
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
        Console.WriteLine();

        foreach (var word in _goals)
        {
            Console.WriteLine($"{word}");
        }
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
            int pointsInt = int.Parse(points);
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, pointsInt);
            _goals.Add(new Goal(goalName, goalDescription, pointsInt));
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
            _goals.Add(new Goal(goalName1, goalDescription1, points1Int));
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
            _goals.Add(new Goal(goalName2, goalDescription2, points2Int));
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
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string path = $@"C:\Users\ssptr\OneDrive\Escritorio\cse-projects\prove\Develop06\{filename}.txt";

         if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                
                foreach (Goal goals in _goals)
                {   
                    sw.WriteLine(goals);
                }
            }	
        }
    }

    public void LoadGoals()
    {
        try
        {
            Console.Write("What is the filename for the goal file? ");
            string file = Console.ReadLine();
            // Open the text file using a stream reader.
            using StreamReader reader = new($@"C:\Users\ssptr\OneDrive\Escritorio\cse-projects\prove\Develop06\{file}.txt");

            // Read the stream as a string.
            string text = reader.ReadToEnd();

            // Write the text to the console.
            Console.WriteLine(text);
        }
        catch (IOException e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}