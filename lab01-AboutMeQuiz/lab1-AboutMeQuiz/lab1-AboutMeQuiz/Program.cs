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

            //start question four
            int answer4 = Q4();
            if(answer4 == 4)
            {
                Console.WriteLine("Yes i normally have one more meal than normal people.");
                score++;
            }

            else Console.WriteLine("hmm. nice try.");

            //start question five
            string answer5 = Q5();
            if(answer5=="friday")
            {
                Console.WriteLine("Of course who would not like Friday.");
                score++;
            }
            else Console.WriteLine("No.It is Friday");

               Console.WriteLine();

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


         static int Q4()
        {  
           //you have three times to type the right format if it is not a number after three times just continue to the Q5
           for(int i = 0; i < 3; i++) {
                Console.WriteLine("How many meals i eat every day?");
                string usertype = Console.ReadLine();
                try
                {
                    int useranstest = Int32.Parse(usertype);
                    int userans = Int32.Parse(usertype);
                    return userans;

                }
                catch (FormatException e)
                {
                        Console.WriteLine(e.Message);
             
                  
                }
               
             }
            return 0;
            }

           

        

        static string Q5()
        {
            Console.WriteLine("what is my favoriate day from Monday - Friday?");
            string usertype = Console.ReadLine();
            string userans = usertype.ToLower();
            return userans;
        }


    }
}
