using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load ");
        Console.WriteLine("4. Save ");
        Console.WriteLine("5. Quit ");
        Console.Write("What would you like to do? ");
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
        PromptGenerator prompt1 = new PromptGenerator();
        Console.WriteLine($"{prompt1.GetRandomPrompt()}");
        string entry = Console.ReadLine();
        }
        
        /*Entry entry1 = new Entry();
        entry1.Display();

        Journal journal1 = new Journal();*/
    }
}