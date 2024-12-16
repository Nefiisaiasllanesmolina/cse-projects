using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while(true)
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

            switch (choice)
            {
                case "1":
                    _goal.CreateGoal();
                    break;
                case "2":
                    _goal.ListGoalNames();
                    break;
                case "3":
                    _goal.SaveGoals();
                    break;
                case "4":
                    _goal.LoadGoals();
                    break;
                case "5":
                    _goal.RecordEvent();
                    break;
                case "6":
                    break;
                
            }
        };
    }

    /*static void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create: ");

        string goalType = Console.ReadLine();

        switch (goalType)
        {
            case "1":
                CreateSimpleGoal(user);
                break;
            case "2":
                CreateEternalGoal(user);
                break;
            case "3":
                CreateChecklistGoal(user);
                break;
            default:
                Console.WriteLine("Select a valid goal type");
                break;
        }
    }*/
}