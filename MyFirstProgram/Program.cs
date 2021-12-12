using System;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;                                    // Reset stats when user plays again
                response = "";
                number = random.Next(min, max + 1); // 1-100

                while (guess != number) // Guess does not = random number
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number) // Guess greater than number
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number) // Guess less than number
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++; // Adds 1 to the guess counter. If guess = number then we escape while loop
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing Eden!");







            Console.ReadKey();
        }
    }
}
