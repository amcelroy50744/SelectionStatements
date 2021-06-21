using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var Subject = Console.ReadLine();
            switch (Subject) 
            {
                case ("Math"):
                    Console.WriteLine("Wow you must be really smart!");
            break;
                case ("Science"):
                    Console.WriteLine("Wow you must like math too?");
                    break;

                case ("History"):
                    Console.WriteLine(" Wow that's boring!");
                    break;
                case ("Drama"):
                    Console.WriteLine("Well that's dramatic!");
                    break;
                case ("English"):
                    Console.WriteLine(" Okay that's cool");
                    break;
                default:
                    Console.WriteLine("Never heard of that one.");
                    break;


             
            }
            {
               
            }

        }
    }
}

