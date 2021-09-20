using System;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, answer1 = "usain bolt";

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


        }
    }
}
