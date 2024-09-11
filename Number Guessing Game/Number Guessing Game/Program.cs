using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isGuess = false;
            Random rand = new Random();

            int RandomNum= rand.Next(1,11);
            Console.WriteLine("Welcome to a Number Guessing Game");
            Console.WriteLine("A random number between 1 and 10 will be generated");
            Console.WriteLine("If you guess the correct number , You Win!");
            //Console.WriteLine(RandomNum);
            while (!isGuess) {
                 Console.WriteLine("Please eneter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());
                if(guess > RandomNum)
                {
                    Console.WriteLine("Your Guess is too high");
                }
                else if (guess < RandomNum)
                {
                    Console.WriteLine("Your Guess is too Low");
                }
                else
                {
                    Console.WriteLine("Correct Guess!");
                    isGuess = true;
                }
            }
            Console.WriteLine("Congratulations!,You have won the game");
            Console.ReadLine();
        }
    }
}
