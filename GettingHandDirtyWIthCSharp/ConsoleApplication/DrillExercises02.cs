using System;
using System.Collections.Generic;
using System.Text;

namespace GettingHandDirtyWIthCSharp.ConsoleApplication
{
    class DrillExercises02
    {
        public void ReadAndMultipyBy22()
        {
            //Write code that reads in an integer and that outputs number multiplied by 22
            Console.WriteLine("Enter an integer: ");
            //int num = Console.Read() - 48;   //Reads only a single character and returns its ASCII value
            int num = Convert.ToInt32(Console.ReadLine());
            int product = num * 22;
            Console.WriteLine(num + " * 22 = " + product);
        }

        public void ReadAndSubtractBy27()
        {
            //Write code that reads in an integer and that outputs the difference between number and 27.
            Console.WriteLine("Enter an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int difference = num - 27;
            Console.WriteLine(num + " - 27 = " + difference);
        }

        public void ReadAndAddByMinusThree()
        {
            //Write code that reads in an integer and that outputs the addition of number and -3.
            Console.WriteLine("Enter an integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = num + (-3);
            Console.WriteLine(num + " + -3 = " + sum);
        }

        public void MultipleLineWords()
        {
            //Write code that prints the phrase "C# is Good" on three lines, one word per line, with each word justified to the left
            Console.WriteLine("C#\nis\nGood");
        }


    }
}
