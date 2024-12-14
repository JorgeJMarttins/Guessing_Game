using System;

class GuessingGame
{
    static void Main()
    {
        Random random = new Random(); // Creates a new instance of the Random class
        int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
        int attempts = 5; // Number of available attempts
        int guess;
        bool correct = false; // Flag to check if the player guessed correctly

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I thought of a number between 1 and 100. You have 5 attempts to guess it.");

        // While there are attempts left and the player hasn't guessed correctly yet
        while (attempts > 0 && !correct)
        {
            Console.WriteLine($"\nRemaining attempts: {attempts}");
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine()); // Reads the player's guess from the console

            // Checks if the guess is higher, lower, or equal to the random number
            if (guess > randomNumber)
            {
                Console.WriteLine("The number is smaller.");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("The number is larger.");
            }
            else
            {
                correct = true; // Sets the flag to true when the guess is correct
            }

            attempts--; // Decreases the number of attempts
        }

        // If the player guessed correctly
        if (correct)
        {
            Console.WriteLine("\nCongratulations! You guessed the number!");
        }
        else
        {
            Console.WriteLine($"\nYou lost! The number was {randomNumber}.");
        }
    }
}
