using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 200;
            Console.WriteLine("Guess my favorite number");
            int userGuess = int.Parse(Console.ReadLine());
            if (favNumber == userGuess)
            {
                Console.WriteLine(" You go it!");
            }
            if (favNumber>= userGuess)
            {
                Console.WriteLine($"No {userGuess} is too low.");
                
            }
            if (favNumber <= userGuess)
            {
                Console.WriteLine($"No {userGuess} is too high!");

            }
            else 
            {
                Console.WriteLine("Nevermind!");
            }
            
        }
    }
}
