using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesingGame
{
    /*
    public class GuessGame
    {
        public static void Play()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 51);


            List<int> TriesBin = new List<int>();
            int triesCount = 1;


            void CheckGuess()
            {
                Console.WriteLine("Enter a number");

                // add a check for input type


                var guess = Console.ReadLine();
                if (Int32.TryParse(guess, out int guessNum))
                {

                    if (guessNum == secretNumber)
                    {
                        Console.WriteLine("correct!");
                        Count();
                        Console.WriteLine("Press 1 to play Again");
                        var value = Console.ReadLine();
                        int Value = int.Parse(value);
                        if (Value == 1)
                        {

                            Reset();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else if (guessNum < secretNumber)
                    {
                        Console.WriteLine("Guess is  too small");
                        Count();
                        Replay();
                    }
                    else
                    {
                        Console.WriteLine("Guess is  too big");
                        Count();
                        Replay();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input Type!!! Enter a number!!!");
                    Replay();
                }


                void Count()
                {

                    if (TriesBin.Count > 0)
                    {
                        int LastTry = TriesBin[TriesBin.Count - 1];
                        if (LastTry == guessNum)
                        {
                            triesCount += 0;
                        }
                        else
                        {
                            triesCount += 1;
                        }
                        Console.Write("You made ");
                        Console.Write(triesCount);
                        Console.WriteLine(" guesses");
                    }
                    else
                    {
                        Console.WriteLine("You made 1 guess");
                    }
                    TriesBin.Add(guessNum);
                }

            }


            void Reset()
            {
                Play();
            }
            void Replay()
            {
                CheckGuess();
            }

            CheckGuess();
        }
    }
    */

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