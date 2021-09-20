using System;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, answer1 = "usain bolt";

            Console.WriteLine("Welcome to this quiz.. test yourself");
            Console.WriteLine("Press any key to begin the quiz");
            Console.ReadLine();

            Console.Write("Who is fastest in the world? ");
            temp = Console.ReadLine();
            temp = temp.ToLower();
            if (temp == answer1)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            string answer2 = "Eddie Hall";
            Console.Write("Who is the strongest man inb the world");
            temp = Console.ReadLine();
            temp = temp.ToLower();
            if (temp == answer2)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
