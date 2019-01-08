using System;

namespace lab1_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("Let's play xia's guessing game!");
            //start question one

            bool answer1 = Q1();
            if (answer1 == false)
            {
                Console.WriteLine("Congrats! I dont like cold");
                score++;
            }
            else Console.WriteLine("Oh NO!I hate cold temperature!");

            //start question two
            int answer2 = Q2();
            if (answer2 == 1)
            {
                Console.WriteLine("Congrats! I only have one ragdoll kitty his name is Blue");
                score++;
            }
            else Console.WriteLine("oops! One kitty is enough for me.");

            //start question three
            bool answer3 = Q3();
            if (answer3 == true) score++;

            else Console.WriteLine("oh,you miss this one");



            Console.WriteLine($"Your final score is {score}");
        }


        static bool Q1()
        {
            Console.WriteLine("Do i like winter time? please choose: yes/no");
            string usertype = Console.ReadLine();
            string userans = usertype.ToLower();
            if (userans == "yes" || userans == "y") return true;
            else return false;
        }
        static int Q2()
        {
            Console.WriteLine("How many cats do i keep?");
            string usertype = Console.ReadLine();
            int userans = Int32.Parse(usertype);
            return userans;

        }

        static bool Q3()
        {
            Console.WriteLine("Now you have three chances to guess my favorite fruit!");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"This is your {i + 1} attempt:");
                string usertype = Console.ReadLine();
                string userans = usertype.ToLower();
                while (userans == "kiwi")
                {
                    Console.WriteLine("Yes,kiwi is my favorite!");
                    return true;

                }
            }

            return false;

        }

    }
}
