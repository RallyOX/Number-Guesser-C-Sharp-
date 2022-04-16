using System;

// Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        // Entry point for our app
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Raul Gheba";
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask user's name

            Console.WriteLine("What is your name? ");

            // Get user's name
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game... ", inputName);

            while (true) // If user wants to play again, the program continues
            {

            
       
            // Create a new Random number
            Random random = new Random();

            // Assign the correct number to that random number
            int correctNumber = random.Next(1,10);

            // Init guess var
            int guess=0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10 !");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Make sure the user enters a number
                if (!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Not a number
                    Console.WriteLine("Not a number, please try again! ");

                    // Reset text color
                    Console.ResetColor();

                    //Keep going
                    continue;
                }
                

                // Cast to int and put it in guess
                guess = Convert.ToInt32(input);

                // Match guess to correct number
                if (guess!=correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Not correct guess
                    Console.WriteLine("Wrong number, please try again! ");

                    // Reset text color
                    Console.ResetColor();
                }

                    // If guess is correct

                    if (guess == correctNumber)
                    {

                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        // Output success message
                        Console.WriteLine("Correct! ");

                        // Reset text color
                        Console.ResetColor();

                        // Ask user if he wants to play again
                        Console.WriteLine("Play again? [Y or N] ");

                        // Get answer
                        string answer = Console.ReadLine().ToUpper();

                        if (answer == "Y")
                        {
                            continue;
                        }
                        else if (answer == "N") 
                        {
                            return;
                        }

                    }
                }

            }
        }
            
    }
}


