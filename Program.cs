using System;

namespace demo09.doCatDog
{
    class Program
    {
        static void Main(string[] args)

        {
            String input_check = null;

            do
            {
                // แสดง แมว
                Console.WriteLine("Here is a cat.");

                // ถามว่าอยากดูหมาไหม?
                Console.WriteLine("Do you want to see a dog. (y/n) :");
                input_check = Console.ReadLine();

                if (input_check == "y")
                {
                    Console.WriteLine("Here is a dog.");
                }
                else
                {
                    break;
                }
                Console.WriteLine("Do you want to see a cat. (y/n) :");
                input_check = Console.ReadLine();
                
            } while (input_check =="y");
            Console.WriteLine("\nThanks, See you again.");
        }
    }
}
