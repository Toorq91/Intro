using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance of the console

            Console.Title = "Toorq";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // Starting a conversation

            Console.WriteLine("A proud knight named...?");
            string knightName = Console.ReadLine();
            Console.WriteLine($"...walked into a bar. At the counter {knightName} met a...");
            string animalName = Console.ReadLine();
            Console.WriteLine($"{animalName} asked him what he wanted to drink?");
            string drinkName = Console.ReadLine();
            Console.WriteLine($"...{drinkName} shouted {knightName}! \nThe bartender shushed him quickly.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"But it was too late...\nA dragon swooped in and hit {knightName}. \nSo hard in fact that all the {drinkName} spilt on the floor and it also left a cut on {knightName}'s arm.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
            Console.WriteLine("Yes, Finished, FINITO... THE END! :)");
            Console.ReadKey();
        }
    }
}