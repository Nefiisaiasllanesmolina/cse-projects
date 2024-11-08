using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        /*This is the way I do*/
        Console.Write("What is your grade percentage? ");
        string letter = Console.ReadLine();
        int number = int.Parse(letter);

        string pass = "You passed the course.";
        string retake = "You need to retake the course.";

        if (number >= 90)
        {
            Console.WriteLine($"Your grade is A. {pass}");
        }
        else if (number >= 80)
        {
            Console.WriteLine($"Your grade is B. {pass}");
        }
        else if (number >= 70)
        {
            Console.WriteLine($"Your grade is C. {pass}");
        }
        else if (number >= 60)
        {
            Console.WriteLine($"Your grade is D. {retake}");
        }
        else
        {
            Console.WriteLine($"Your grade is F. {retake}");
        }

        /*This is the example but I typed it to practice and understandit
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! ");
        }
        else
        {
            Console.WriteLine("You will need to retake the course");
        }
        */
    }
}