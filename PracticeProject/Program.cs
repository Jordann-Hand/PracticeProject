using System;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, answer1 = "usain bolt";
            int score = 0;
            Console.WriteLine("Welcome to this quiz.. test yourself");
            Console.WriteLine("Press any key to begin the quiz");
            Console.ReadLine();

            Console.Write("Who is fastest in the world? ");
            temp = Console.ReadLine();
            temp = temp.ToLower();
            if (temp == answer1)
            {
                Console.WriteLine("Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            string answer2 = "Eddie Hall";
            Console.Write("Who is the strongest man in the world");
            temp = Console.ReadLine();
            temp = temp.ToLower();
            if (temp == answer2)
            {
                Console.WriteLine("Correct");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.WriteLine($"Thank you for playing, you got {score}/2");
            if (score == 2)
            {
                Console.WriteLine("You are an expert");
            }
            else if (score == 1)
            {
                Console.WriteLine("You got an average score");
            }
            else
            {
                Console.WriteLine("Your score was dissapointing");
            }
            Console.ReadLine();
        }
    }
}
