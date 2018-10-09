using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int attempts = 5;
            bool solved = false;
            string input = "";
            int guess = 0;

            // Generate a random number
            Random rand = new Random();
            int answer = rand.Next(1, 30);

            // Game instructions
            Console.WriteLine("I have chosen a random number from 1 to 30.");
            Console.WriteLine("You have 5 chances to guess the answer.");
            Console.WriteLine("What is your first guess?");

            while (attempts > 0 && !solved)
            {
                // Player input
                do
                {
                    try
                    {
                        input = Console.ReadLine();
                        guess = Convert.ToInt16(input);

                        if (guess <= 0 || guess > 30)
                        {
                            Console.WriteLine("Invalid guess, must be a positive integer from 1 to 30.");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid guess, must be a positive integer.");
                        guess = 0;
                    }

                } while (guess <= 0 || guess > 30);

                // Compare guess to the answer
                if (guess == answer)
                {
                    Console.WriteLine("You are correct! " + answer + " is the answer.");
                    solved = true;
                }
                if (guess < answer && attempts > 1)
                {
                    Console.Write("Too Low. ");
                }
                if (guess > answer && attempts > 1)
                {
                    Console.Write("Too High. ");
                }

                // Reduce attempts by 1
                attempts--;

                // Loop end statement
                if (attempts != 0 && !solved)
                {
                    Console.Write("Try again, " + attempts + " left");
                    Console.WriteLine("");
                }
                else if (attempts == 0 && !solved)
                {
                    Console.WriteLine("No more guesses, you have failed.");
                }
            }

            // Keep console open
            Console.ReadLine();
        }
    }
}
