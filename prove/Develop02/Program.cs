using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        while(option != 5)
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
                string newEntry1 = Console.ReadLine();
                Journal journal1 = new Journal();
                journal1.AddEntry(newEntry1);
                option = 1;
            }

            else if (number == 2)
            {
                /*Display all elements*/
                
            }
            
            else if (number == 3)
            {
                Console.WriteLine("What is the file name? ");
                string newFile = Console.ReadLine();
                Journal file = new Journal();
                file.LoadFromFile(newFile);
                
            }

            if (number == 4)
            {
                Console.WriteLine("What is the file name? ");
                string newFile = Console.ReadLine();
                Journal file = new Journal ();
                file.SaveToFile(newFile);
                
            }

            else if (number == 5)
            {
                option = 5;
            }

            else if(number > 5 | number < 1)
            {
                Console.WriteLine("Please enter a valid command ");
                Console.WriteLine();
                option = 0;
            }
        }
        
    }
}