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
            Console.ReadLine();
            Console.WriteLine("...walked into a bar. At the counter he met a...");
            Console.ReadLine();
            Console.WriteLine("...who asked him what he wanted to drink?");
            Console.ReadLine();
            Console.WriteLine("...shouted the knight! \nThe bartender shushed him quickly.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("But it was too late to apologize... too laaaaaate.... \nA dragon ate them both.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadLine();
            Console.WriteLine("Yes, it is what it is! :)");
            Console.ReadKey();
        }
    }
}