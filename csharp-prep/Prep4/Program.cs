using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();

        int counter = 0;
        float sum = 0;
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

            counter++;
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum} ");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }

        Console.WriteLine($"The greatest number is {max}");
    }
}