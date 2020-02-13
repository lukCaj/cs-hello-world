using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt1_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool properly_read, liar, stupid; // I need to understand how to properly combine them to reduce lines.
            stupid = false;
            properly_read = false;
            liar = false;

            string[] positive_array = {"yes","yep","sure","okay","yeah","fine","totally"};
            string[] negative_array = {"no","nah","nope","no way"};

            string response, deep_response;
            int deepest_response;

            Console.WriteLine("Hello World!");

            while (properly_read == false)
            {
                Console.Write("Were you able to read the text above? "); // Console.Write() would write on the same line.
                response = Console.ReadLine();

                if (positive_array.Contains(response.ToLower()))
                {
                    properly_read = true;
                    Console.WriteLine("Thank you for responding!");
                    System.Threading.Thread.Sleep(2000); // This pauses time.
                }

                else if (negative_array.Contains(response.ToLower()))
                {
                    
                    Console.WriteLine("Okay? But like, can you think of a number?");
                    deep_response = Console.ReadLine();

                    if (positive_array.Contains(deep_response.ToLower()))
                    {
                        liar = true;
                        properly_read = true;
                        Console.WriteLine("Then you can read, you liar!");
                        System.Threading.Thread.Sleep(2000);
                    }

                    else
                    {
                        Console.Write("What is 2+2? ");
                        string val = Console.ReadLine();
                        deepest_response = Convert.ToInt32(val);

                        if (deepest_response == 4)
                        {
                            liar = true;
                            properly_read = true;
                            Console.WriteLine("Alright, so you can read now? Liar!");
                            System.Threading.Thread.Sleep(1000);
                        }

                        else
                        {
                            properly_read = true;
                            stupid = true;
                            Console.WriteLine("Okay... so you're not so bright then...");
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                    
                }

                else
                {
                    Console.WriteLine("Sorry, I read you wrong... I just want a clear yes or no from you.");
                    System.Threading.Thread.Sleep(2000);
                }
            }

            if (liar == true)
            {
                Console.WriteLine("Congrats, you liar.");
            }

            else if (stupid == true)
                Console.WriteLine("I feel sorry for you.");
                System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Alright, press any key to close the program, then.");

            System.Console.ReadKey(true); // This prevents the debug window from closing (or moving along the program/method) until you press any key. 
                                          // Adding true prevents the echo.
            Console.WriteLine("Bye!");
            System.Threading.Thread.Sleep(1000);
        }
    }
}