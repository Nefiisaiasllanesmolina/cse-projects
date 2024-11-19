using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

class Journal{
    
    public const string WRITE = "Write";
    public const string DISPLAY = "Display";
    public const string LOAD = "Load";
    public const string SAVE = "Save";
    public const string QUIT = "Quit";


    private List<string> _commands = new List<string>()
    {
        WRITE,
        DISPLAY,
        LOAD,
        SAVE,
        QUIT
    };

        public List<string> _entries = new List<string>()
    {
        
    };

    private string getCommand()
    {
        int index = 1;
        Console.WriteLine("Please select one of the following choices: ");
        foreach (var command in _commands)
        {
            Console.WriteLine($"{index}. {command}");
            ++index;
        }
        Console.Write("What would you like to do? ");
        string response = Console.ReadLine();
        int value = 0;
        string retval = "None";
        if (int.TryParse (response, out value))
        {
            if (value > 0 && value <= _commands.Count)
            {
                retval = _commands[value - 1];
            }
        }
        return retval;
    }

    public void run()
    {
        while(true)
        {
            string command = getCommand();
            if (command == QUIT)
            {
                break;
            }
            else if (command == WRITE)
            {
                PromptGenerator prompt = new PromptGenerator();
                string prom = prompt.GetRandomPrompt();
                Console.WriteLine($"{prom}");
                string newEntry = Console.ReadLine();
                Entry siu = new Entry();
                AddEntry(siu.Display(prom, newEntry));
            }
            else if (command == DISPLAY)
            {
                DisplayAll();
            }
            else if (command == LOAD)
            {
                Console.WriteLine("What is the file name? ");
                string file = Console.ReadLine();
                LoadFromFile(file);
            }
            else if (command == SAVE)
            {
                Console.WriteLine("What is the file name? ");
                string filename = Console.ReadLine();
                SaveToFile(filename);
            }
            else 
            {
                Console.WriteLine("Please enter a valid command");
            }
        }
    }

    private void AddEntry(string entry)
    {
        _entries.Add(entry);
    }

    private void DisplayAll()
    {
        foreach (string hola in _entries)
        {
            string entry1 = hola;
            Console.WriteLine(hola);
            Console.WriteLine();
        }
    }

    private void LoadFromFile(string file)
    {
        try
        {
            // Open the text file using a stream reader.
            using StreamReader reader = new($@"C:\Users\ssptr\OneDrive\Escritorio\cse-projects\prove\Develop02\{file}.txt");

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

    private void SaveToFile(string filename)
    {
        string path = $@"C:\Users\ssptr\OneDrive\Escritorio\cse-projects\prove\Develop02\{filename}.txt";

         if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                
                foreach (string save in _entries)
            {   
                 sw.WriteLine(save);
            }
            }	
        }
    }
}

    


/*
public class Journal {
    public List<Entry> _entries = new List<Entry>()
    {
        
    };
    
    public void AddEntry(string newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {   
            Console.WriteLine($"{entry}");
        }
    }

    public void SaveToFile(string file)
    {
        string filename = $"{file}.txt";
        string path = $@"C:\Users\ssptr\OneDrive\Escritorio\cse-projects\prove\Develop02\{filename}";

         if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                foreach (Entry entry in _entries)
            {   
                sw.WriteLine($"{entry}");
            }
            }	
        }
    }

    public void LoadFromFile(string file)
    {
        string filename = $"{file}.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}*/

    

