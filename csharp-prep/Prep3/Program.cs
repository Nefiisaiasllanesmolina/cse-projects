using System;

class Program
{
    static void Main(string[] args)
    {
        int response = 0;
        int counter = 0;
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            counter = 0;
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            while (magicNumber != response)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                int guess = int.Parse(answer);
                counter = counter + 1;

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
                    Console.WriteLine($"You guessed it {counter}");
                }
                response = guess;
            }

        Console.WriteLine("Do you want to play again? ");
        string yesorno = Console.ReadLine();
        response = 0;
        keepPlaying = yesorno;
        }
    }
}