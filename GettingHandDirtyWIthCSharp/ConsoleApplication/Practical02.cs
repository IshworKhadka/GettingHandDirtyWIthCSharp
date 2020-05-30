using System;
using System.Collections.Generic;
using System.Text;

namespace GettingHandDirtyWIthCSharp.ConsoleApplication
{
    class Practical02
    {
        public void Assignment()
        {
            // declare variables, assigning values and modications done on values.
            int total = 0;
            int val1, val2;
            val1 = 26;
            val2 = val1 + 1;
            total = val1 + val2;
            Console.WriteLine(val1 + ", " + val2 + ", " + total);
        }

        public void Echo()
        {
            //Modify the program so that it prompts for, and reads, two separate lines of input and outputs
            //the contents of the lines in reverse order, on the same line, separated by a comma.
            Console.WriteLine("Enter a line: ");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter another line: ");
            String s2 = Console.ReadLine();
            Console.WriteLine(s2 + ", " + s1);
        }

        public void Number()
        {
            /* Modify the program so that rather than printing out the two strings which have been read in,
               it treats them as being two halves of a single integer. Your program should print out the value
               of that integer plus 1. */

            Console.WriteLine("Enter a line: ");
            String part1 = Console.ReadLine();
            Console.WriteLine("Enter another line: ");
            String part2 = Console.ReadLine();
            String full = part1 + part2;
            int num = Int32.Parse(full) + 1;         //(METHOD 2 OF CONVERSION).
            Console.WriteLine("Number = " + num);
        }

        public void Division()
        {
            /*1.prompts for and reads in an integer(on the same line)
                2.Outputs:
                i) the value of the number divided by 100 as a floating point value
                ii) the remainder when the number is divided by 100
                iii) the number of times 100 divides the integer
                iv) outputs the digits of the integer in reverse order; i.e., each digit must be extracted
                    arithmetically.    */

            int num;
            int reverse = 0;
            Console.WriteLine("Enter an integer: ");
            bool isParsable = Int32.TryParse(Console.ReadLine(), out num);     //(METHOD 3 OF CONVERSION).
            while (num > 10000)
            {
                Console.WriteLine("Enter an integer less than 10000: ");
                isParsable = Int32.TryParse(Console.ReadLine(), out num);     
            }
            if (isParsable)
            {
                
                float division = (float)num / 100;
                int remainder = num % 100;
                int times = num / 100;
                while (num != 0)
                {
                    int digit = num % 10;
                    reverse = reverse * 10 + digit;
                    num = num / 10;
                }
                Console.WriteLine(division);
                Console.WriteLine(remainder);
                Console.WriteLine(times);
                Console.WriteLine(reverse);
            }
            else
            {
                Console.WriteLine("Could not be parsed");
            }
        }

        public void ChangeDispenser()
        {
            /*Your task is to develop software for a machine which dispenses change. It accepts an amount in
                cents and outputs the ways that amount can be made up from 1, 5 and 20 cent coins (ignoring
                the fact that we no longer have 1 cent coins) using as many of the larger valued coins as
                possible. */

            int amount;
            int twenties = 0, fives = 0, ones = 0;
            Console.WriteLine("Enter an amount of cents in the range 1 to 100: ");
            bool isParsable = Int32.TryParse(Console.ReadLine(), out amount);
            while(amount <= 0 || amount > 100)
            {
                Console.WriteLine("Amount not in range. Enter an amount of cents in the range of 1 to 100 ");
                isParsable = Int32.TryParse(Console.ReadLine(), out amount);
            }
            if (isParsable)
            {
                if (amount >= 20)
                {
                    twenties = amount / 20;
                    amount = amount % 20;
                    if (amount >= 5)
                    {
                        fives = amount / 5;
                        ones = amount % 5;
                    }
                    else
                    {
                        ones = amount % 5;
                    }
                }
                else
                {
                    if (amount >= 5)
                    {
                        fives = amount / 5;
                    }
                    ones = amount % 5;
                }
                Console.WriteLine("Dispensing...");
                Console.WriteLine(twenties + " 20c coin(s)");
                Console.WriteLine(fives + " 5c coin(s)");
                Console.WriteLine(ones + " 1c coin(s)");
            }
        }
    }
}
