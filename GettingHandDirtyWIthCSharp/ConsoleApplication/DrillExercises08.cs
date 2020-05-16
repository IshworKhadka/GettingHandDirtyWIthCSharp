using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GettingHandDirtyWIthCSharp.ConsoleApplication
{
    class DrillExercises08
    {
        public void Product()
        {
            //            Write code that reads in 6 numbers and that outputs the product of
            //all numbers greater than or equal to zero and the product of all numbers less than zero.
            // TODO your code goes here
            int[] nums = new int[6];
            int productOfPostive = 1;
            int productOfNegative = 1;
            int CountPositive = 0;
            int CountNegative = 0;
            Console.WriteLine("Enter 6 integers ");
            var str = Console.ReadLine();
            for (int i = 0; i < nums.Length; i++)
            {
                //nums[i] = Console.ReadLine();
                //var ch = str.Split(' ');
                nums[i] = Convert.ToInt32(str.Split(' ')[i]);
                if (nums[i] >= 0)
                {
                    productOfPostive *= nums[i];
                    CountPositive++;
                }
                else
                {
                    productOfNegative *= nums[i];
                    CountNegative++;
                }
            }

            if (CountPositive != 0)
            {
                Console.WriteLine("Product of non-negatives = " + productOfPostive);
            }
            else
            {
                Console.WriteLine("Product of non-negatives = 0");
            }

            if (CountNegative != 0)
            {
                Console.WriteLine("Product of negatives = " + productOfNegative);
            }
            else
            {
                Console.WriteLine("Product of negatives = 0");
            }


        }

        public int arrayCountNines(int[] nums)
        {
            //        Given an array of ints, return the number of 9's in the array.
            //        arrayCountNines([1, 2, 9])  \small \rightarrow 1
            //        arrayCountNines([1, 9, 9])  \small \rightarrow 2
            //        arrayCountNines([1, 9, 9, 3, 9])  \small  \rightarrow 3
            // TODO your code goes here
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    count++;
                }
            }
            return count;
        }

        public Boolean arrayOneTwoThree(int[] nums)
        {
            //        Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the arraysomewhere.
            //
            //                arrayOneTwoThree([1, 1, 2, 3, 1])  \small \rightarrow true
            //        arrayOneTwoThree([1, 1, 2, 4, 1])  \small \rightarrow false
            //        arrayOneTwoThree([1, 1, 2, 1, 2, 3])  \small \rightarrow true
            // TODO your code goes here
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 1)
                {
                    if (nums[i + 1] == 2)
                    {
                        if (nums[i + 2] == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int ConvertToDecimal(String binary)
        {
            //    Write a method that will convert the supplied binary digit (as a string) to a decimal number.
            //    convertToDecimal("01101011")  \small \rightarrow 107
            //    convertToDecimal("00001011")  \small  \rightarrow 11
            // TODO your code goes here
            int index = 7;
            int sum = 0;
            while (index >= 0)
            {
                if (binary.ElementAt(index) != '0')
                {
                    sum += (int)Math.Pow(2, 7 - index);
                }
                index--;
            }
            return sum;
        }
    }
}
