using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int secretNumber, guess, guesses;
            string reply;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                secretNumber = random.Next(1, 51);
                reply = "";


                while (guess != secretNumber)
                {
                    Console.Write("Enter a number between 1 and 50: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your guess: {guess}");

                    if (!(guess > 50 || guess < 1))
                    {


                        if (guess > secretNumber)
                        {
                            Console.WriteLine($"{guess} is too big");
                        }
                        else if (guess < secretNumber)
                        {
                            Console.WriteLine($"{guess} is too small");
                        }
                        guesses++;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a number within the specified range");
                    }
                    
                }

                Console.WriteLine($"Your guess: {guess}");
                Console.WriteLine($"Secret number: {secretNumber}");
                Console.WriteLine("Congratulations! You win!");
                Console.WriteLine($"It took {guesses} {((guesses == 1) ? "guess" : "guesses")}");

                Console.Write("Would you like to play again (Y/N)? ");
                reply = Console.ReadLine().ToUpper();


                if (reply == "Y")
                {
                    playAgain = true;
                }
                else if (reply == "N")
                {
                    playAgain= false;
                }
                else
                {
                    Console.WriteLine("Invalid input format.");
                }

            }

            Console.WriteLine("Thanks for playing. You are now exiting the game...");
        }
    }
}
