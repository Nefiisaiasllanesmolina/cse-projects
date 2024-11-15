using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        while (number != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            Console.Write("What would you like to do? ");
            int number = int.Parse(Console.ReadLine());
        }
        

        PromptGenerator prompt1 = new PromptGenerator();
        prompt1.GetRandomPrompt();
        
        Entry entry1 = new Entry();
        entry1.Display();

        Journal journal1 = new Journal();
    }
}