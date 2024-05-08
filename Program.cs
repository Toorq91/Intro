using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change the appearance of the console

            Console.Title = "Toorq";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowTop = 0;
            Console.WindowWidth = 130;
            Console.WindowHeight = 30;

            // Starting a conversation

            Console.WriteLine("A proud knight named...?");
            string knightName = Console.ReadLine();
            Console.WriteLine($"...walked into a bar. At the counter {knightName} met a...");
            string animalName = Console.ReadLine();
            Console.WriteLine($"{animalName} asked him what he wanted to drink?");
            string drinkName = Console.ReadLine();
            Console.WriteLine($"...{drinkName} shouted {knightName}!");

            // Random 50% chance outcome

            bool enounterDragon = new Random().Next(0, 2) == 0;

            // Will get a different outcome if writing wine, Wine, WINE or shot, Shot, SHOT as the choice of drink.

            if (drinkName.ToLower() == "wine" || drinkName.ToLower() == "shot")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{knightName} ordered {drinkName}, an interesting choice indeed!");
                Console.WriteLine($"Suddenly, a wizard appeared from a nearby table, intrigued by {knightName}'s choice of drink.");
                Console.WriteLine($"The wizard offered {knightName} a magical potion, and {knightName} accepted, gulping the potion down {knightName} got the feeling of being invincible!");
            }
                else if (enounterDragon)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The {animalName} shushed him quickly.");
                Console.WriteLine($"But it was too late...\nA dragon swooped in and hit {knightName}. \nSo hard in fact that all the {drinkName} spilt on the floor and left a cut on {knightName}'s arm.");
                Console.WriteLine($"{knightName} fought valiantly but alas, it was not enough. The dragon devoured {knightName} and the {animalName}. The end.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{knightName} enjoyed the {drinkName} and had a pleasant conversation with the {animalName}. ");
                Console.WriteLine($"Feeling satisfied, {knightName} left the bar and embarked on a new adventure. The end!");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
            Console.WriteLine("Yes, Finished, FINITO... THE END! :)");
            Console.ReadKey();
        }
    }
}