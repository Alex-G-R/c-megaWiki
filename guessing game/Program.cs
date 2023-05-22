using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15___Guessing_Game_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Alex";
            string guess = "";
            int guessLimit = 5;

            while ( guess != secretWord && guessLimit > 0)
            {
                Console.Write($"{guessLimit} Guesses left - Enter your guess: ");
                guess = Console.ReadLine();
                guessLimit--;

            }
            if (guess == secretWord)
            {
                Console.Write("Brawo, wygrałeś geniuszu!");
            }
            else if (guessLimit == 0)
            {
                Console.Write("Przegrałeś");
            }
            


            Console.ReadLine();
        }


    }
}
