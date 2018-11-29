using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGame();
        }
        static void DisplayGame()
        {
        int min = 1;
            int max = 11;
            int guess;
            string guessString;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);
            do
            {
                Write("Choose a number between 1-10>>> ");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            
                if (guess < max && guess >= min)
                {
                    if (randomNumber == guess)
                    {
                        result = "You win, you guessed " + randomNumber;
                    }
                    else if (guess > randomNumber)
                    {
                        result = "you guessed too high";

                    }
                    else if (guess < randomNumber)
                    {
                        result = "you guessed too low";
                    }

                }
                else
                    result = "Error";
                DisplayString(result);
            } while (randomNumber != guess);
            
        }
        
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}
