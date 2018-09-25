using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellotest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numToGuess = rnd.Next(1, 10);
            int numTries = 0;
            Console.WriteLine("Number Guessing Game!");
            bool found = false;
            while(found == false)
            {
                Console.Write("Please guess a number 1 through 10: ");
                string userInput = Console.ReadLine();
                int userNum = Int32.Parse(userInput);
                if(userNum == numToGuess)
                {
                    numTries++;
                    found = true;
                    Console.WriteLine("You guessed correctly in "+numTries+" attempts.");
                    Console.ReadLine();
                }
                else
                {
                    numTries++;
                    Console.WriteLine("Incorrect, try again!");
                    if(userNum > numToGuess)
                    {
                        Console.WriteLine("Your number was too high.");
                    }
                    else
                    {
                        Console.WriteLine("Your number was too low.");
                    }
                }
            }
        }
    }
}
