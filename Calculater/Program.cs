using System;
using Add;

namespace Calculater
{
    class Program
    {
        static void Main1(string[] args)
        {
            bool control = true;
            while (control)
            {
                try
                {
                    Console.WriteLine("Select Option:");
                    Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.stop");
                    decimal option = Convert.ToDecimal(Console.ReadLine());
                    if (option == 5)
                    {
                        break;
                    }
                    Console.Write("Enter Number1:");
                    decimal number1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter Number2:");
                    decimal number2 = Convert.ToDecimal(Console.ReadLine());

                    if (option == 1)
                    {
                        Addition addition = new Addition();

                        // addition.Age = -5;
                        //addition.
                        //Console.WriteLine(addition.Age);
                        addition.Add(number1, number2);

                    }
                    else if (option == 2)
                    {
                        Subtraction subtraction = new Subtraction();
                        subtraction.Subtract(number1, number2);

                    }
                    else if (option == 3)
                    {
                        Multiplication multiplication = new Multiplication();
                        multiplication.Multiply(number1, number2);

                    }
                    else if (option == 4)
                    {
                        Division division = new Division();
                        division.Divide(number1, number2);

                    }

                    else
                    {
                        Console.WriteLine("Enter right option");
                        Console.WriteLine("\n");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally {
                    Console.WriteLine("Hi!");
                }
            }

        }

    }


}
