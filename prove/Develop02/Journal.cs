using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Journal {
    public List<Entry> _entries = new List<Entry>()
    {
        
    };
    
    

    public void AddEntry(string newEntry)
    {
        
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

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
    
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Entry entry in _entries)
            {   
                outputFile.WriteLine($"{entry}");
            }

            Console.WriteLine();
            
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
}

    

