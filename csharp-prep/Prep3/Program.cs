using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
        } while (guess != number);

        Console.WriteLine("You guessed it!");
    }
}