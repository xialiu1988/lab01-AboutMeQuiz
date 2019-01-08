using System;

namespace lab1_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {   //initialize the score
            int score = 0;
            Console.WriteLine("Let's play xia's guessing game!");
            //start question one,call Q1 method and return the answer

            bool answer1 = Q1();
            // check if the answer matches mine,if matches socre will be added one point
            if (answer1 == false)
            {
                Console.WriteLine("Congrats! I dont like cold");
                score++;
            }
            else Console.WriteLine("Oh NO!I hate cold temperature!");

            //start question two,call Q2 method and return answer from there
            int answer2 = Q2();
            //if the answer matches, add 1 point to the score and continue,otherwise continue without adding point 
            if (answer2 == 1)
            {
                Console.WriteLine("Congrats! I only have one ragdoll kitty his name is Blue");
                score++;
            }
            else Console.WriteLine("oops! One kitty is enough for me.");

            //start question three,call Q3 method here and return answer
            bool answer3 = Q3();
            if (answer3 == true) score++;

            else Console.WriteLine("oh,you miss this one");

            //start question four,call Q4 method
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

            //display your final score here
               Console.WriteLine();

               Console.WriteLine($"Your final score is {score}");
        }


        static bool Q1()
        {
            Console.WriteLine("Do i like winter time? please choose: yes/no");
            string usertype = Console.ReadLine();
            //makesure all the string to lowercase 
            string userans = usertype.ToLower();
            if (userans == "yes" || userans == "y") return true;
            else return false;
        }
        static int Q2()
        {
            Console.WriteLine("How many cats do i keep?");
            string usertype = Console.ReadLine();
            //convert string type to int
            int userans = Int32.Parse(usertype);
            return userans;

        }

        static bool Q3()
        {
            Console.WriteLine("Now you have three chances to guess my favorite fruit!");
            //it starts the for loop for maxium 3 times let users guess
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"This is your {i + 1} attempt:");
                string usertype = Console.ReadLine();
                //convert to int type
                string userans = usertype.ToLower();
                //if get the correct answer,loop stops here and return true
                while (userans == "kiwi")
                { 
                    Console.WriteLine("Yes,kiwi is my favorite!");
                    return true;

                }
            }
            //after all three times attemps, no more chance!
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
                    return userans;//if nothing wrong with the format,will return number 

                }
                catch (FormatException e)
                {
                        Console.WriteLine(e.Message);
             
                  
                }
               
             }
           //if still wrong format after three times,return 0 and this will be wrong answer
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
