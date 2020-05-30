using GettingHandDirtyWIthCSharp.ConsoleApplication;
using System;

namespace GettingHandDirtyWIthCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Practical05 myFrog = new Practical05("Fred", 1000, 22);  /* create a Frog object. Add code to the main method to assign the                                                 instance variable age, in the object referred to in my myFrog, to 22. */
            myFrog.print();
            myFrog.printAgeGroup();
            Practical05 myFrog2 = new Practical05("Fran", 1001, 75);
            myFrog2.print();
            myFrog2.printAgeGroup();
            myFrog.reversedName();
            myFrog2.reversedName();

            Practical05 f = myFrog.greaterAge(myFrog2);
            f.print();

            //pr2.ChangeDispenser();

            //DrillExercises08 de = new DrillExercises08();
            //test git push
            //int[] array = { 1, 9, 9, 3, 9 };
            //Console.Write(de.ConvertToDecimal("01101011"));
            //Console.WriteLine(de.arrayOneTwoThree(array));
            //Console.WriteLine(de.arrayCountNines(array));
            //de.Product();
        }
    }
}
