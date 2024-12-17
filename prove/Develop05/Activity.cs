using System;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    //private int _duration;
    private string _startingMessage;
    private string _endingMessage;
    private int _spinnerCounter;
    private int _userSessionLengthInput;

    public Activity()
    {
        _spinnerCounter = _userSessionLengthInput = 0;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public void SetActivityDecription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }

    public void DisplayStartingMessage()
    {
        _startingMessage = $"Welcome to the {_activityName}";
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        _endingMessage = $"You have complete {_userSessionLengthInput} seconds of the {_activityName}";

        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine(_endingMessage);
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < seconds)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i>= 1; i--)
        {
            Console.Write($"You may begin in {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);
        }
    }

    public void DisplayGetSessionLenght()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }

    public void DisplayGetReady()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void RunActivityParentStart()
    {
        DisplayStartingMessage();
        DisplayDescription();
        DisplayGetSessionLenght();
        DisplayGetReady();
        Console.Clear();
    }

    public void RunActivityParentEnd()
    {
        DisplayEndingMessage();
    }
    
    /*public void ShowSpinner(int seconds)
    {
        
    }

    public void ShowCountDown(int seconds)
    {

    }*/
}