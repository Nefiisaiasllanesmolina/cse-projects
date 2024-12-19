using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();

        Running running = new Running(20, 3);
        activitiesList.Add(running);
        Cycling cycling = new Cycling(25, 4);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming(30, 30);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.DisplaySummary();
        }
    }
}