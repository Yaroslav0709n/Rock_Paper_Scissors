using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start our game \n");

            Console.WriteLine("So far, these are all the elements that are in our game: \n");

            string[] variant = { "Paper", "Rock", "Scissors" };
            foreach(var i in variant)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Random rand = new Random();
            var bot = variant[rand.Next(0, variant.Length)];
            Console.Write("Your - ");
            string your = Console.ReadLine();

            while (true)
            {
                if (bot != your)
                {

                    if (your == "Paper" && bot == "Rock" || your == "Rock" && bot == "Scissors" || your == "Scissors" && bot == "Paper")
                    {
                        Console.WriteLine($"Bot - {bot}");
                        Console.WriteLine("You winner");
                    }
                    else if (your == "Rock" && bot == "Paper" || your == "Scissors" && bot == "Rock" || your == "Paper" && bot == "Scissors")
                    {
                        Console.WriteLine($"Bot - {bot}");
                        Console.WriteLine("You loser");
                    }
                    else
                    {
                        Console.WriteLine("No such option");
                    }

                    Console.WriteLine("\n");
                    Console.Write("Your - ");
                    your = Console.ReadLine();
                }
                else if (bot == your)
                {
                    Console.WriteLine($"Bot - {bot}");
                    Console.WriteLine("Oooopppsss!!!");
                    Console.WriteLine("\n");
                    Console.Write("Your - ");
                    your = Console.ReadLine();
                }
            }
        }
    }
}
