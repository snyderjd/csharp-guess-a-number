using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator = new Random();

            Console.Write("Please select a difficulty level. ('Easy', 'Medium', 'Hard', or 'Cheater')>");
            string difficulty = Console.ReadLine();

            int numGuesses = 8;

            if (difficulty == "Easy")
            {
                numGuesses = 8;
            }
            else if (difficulty == "Medium")
            {
                numGuesses = 6;
            }
            else if (difficulty == "Hard")
            {
                numGuesses = 4;
            }

            int secretNumber = randomNumberGenerator.Next(1, 101);
            int remainingGuesses = numGuesses;

            bool solved = false;

            if (difficulty == "Cheater")
            {
                while(solved == false) {
                    Console.WriteLine("Please guess a number between 1 and 100!");
                    Console.Write("Enter your guesss>");

                    string guess = Console.ReadLine();
                    int intGuess = int.Parse(guess);

                    if (intGuess == secretNumber)
                    {
                        Console.WriteLine("You got it right, you are amazing. You win.");
                        solved = true;
                    }
                    else if (intGuess > secretNumber)
                    {
                        Console.WriteLine("You are wrong. Your guess was too high.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You are wrong. Your guess was too low.");
                        Console.WriteLine();
                    }

                }
            } else 
            {
                for (int i = 0; i < numGuesses; i++)
                {
                    Console.WriteLine("Please guess a number between 1 and 100!");
                    Console.Write($"Enter your guess({remainingGuesses} guesses remaining.)> ");

                    string guess = Console.ReadLine();
                    int intGuess = int.Parse(guess);

                    if (intGuess == secretNumber)
                    {
                        Console.WriteLine("You got it right, you are amazing. You win.");
                        break;
                    }
                    else if (intGuess > secretNumber)
                    {
                        Console.WriteLine("You are wrong. Your guess was too high.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("You are wrong. Your guess was too low.");
                        Console.WriteLine();
                    }

                    remainingGuesses = remainingGuesses - 1;

                    if (remainingGuesses == 0)
                    {
                        Console.WriteLine($"You lose. The number was {secretNumber}.");
                    }
                }
            }

            
        }
    }
}
