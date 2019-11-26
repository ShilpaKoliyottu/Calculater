using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;

            while (control)
            {
                Console.WriteLine("Enter a Number:");

                int number = Convert.ToInt32(Console.ReadLine());

                int temp = number;

                int reminder,sum = 0;

                

                while (number > 0)
                {
                    reminder = number % 10;

                    sum = (sum * 10 )+ reminder;

                    number = number / 10;

                }

                if (temp == number)
                {
                    Console.WriteLine("palindrome");
                }
                else
                {
                    Console.WriteLine("not a palindrome");
                }
                
                Console.WriteLine("Do you want to continue press 1?");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    control = true;
                }
                else
                {
                    control = false;
                }
            }


        }
    }
}
