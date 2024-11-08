using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 3;
        int response = 0;

        while (magicNumber != response)
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            int guess = int.Parse(answer);

            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is higher than magic number");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is lower than magic number");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
            response = guess;
        }
    }
}