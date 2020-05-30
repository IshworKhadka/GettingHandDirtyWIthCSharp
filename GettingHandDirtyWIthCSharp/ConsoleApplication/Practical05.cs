using System;
using System.Collections.Generic;
using System.Text;

namespace GettingHandDirtyWIthCSharp.ConsoleApplication
{
    class Practical05
    {
        /*Declare another instance variable in the class to store a Frog’s age in days. Its initial
            value should be 0. */
        private int age = 0;
        private String name = "Name_not_set";
        private int id = -1; // -1 used to indicate the value has not been set


        // Constructor
        /* Modify the constructor in the class so that it has three formal parameters, theName, theId and theAge, and assigns the corresponding instance variables, name, id and age to the formal parameters. */
        public Practical05(String theName, int theId, int theAge)
        {
            name = theName;
            id = theId;
            age = theAge;
        }

        public void print()
        {
            Console.WriteLine("**** Start of print method ******");
            Console.WriteLine("Frog's name is " + name);
            Console.WriteLine("Id  is " + id);
        }

        public void printAgeGroup()
        {
            /*Define a method called printAgeGroup which has no formal parameters and which prints
                out the age group of the frog according to the following table:
                Age Age Group
                0 to 20 days young
                21 to 50 days juvenile
                more than 50 days adult */
            if (age <= 20 && age >= 0)
            {
                Console.WriteLine("Age group is young");
            }
            else if (age <= 50 && age >= 21)
            {
                Console.WriteLine("Age group is juvenile");
            }
            else
            {
                Console.WriteLine("Age group is adult");
            }
        }


        public void reversedName()
        {
            /*1. Add a definition of a method called reversedName to the class Frog which prints the name
                    using the following translation table:
                    Letter Letter printed in its place
                    a i
                    n i
                    r o
                    F o
              2. Make use of a for loop and a switch statement to control the printing of letters.   */

            StringBuilder newName = new StringBuilder(name);
            for (int i = 0; i < newName.Length; i++)
            {
                switch (name[i])
                {
                    case 'a':
                    case 'n':
                        newName[i] = 'i';
                        break;
                    case 'r':
                    case 'F':
                        newName[i] = 'o';
                        break;
                    //default:
                    //    newName.setCharAt(i, newName.charAt(i));
                    //    break;
                }
            }
            Console.WriteLine(newName);
        }


        public Practical05 greaterAge(Practical05 myFrog2)
        {
            /*  Add a definition of a method called greaterAge to the class Frog (Practical05) which takes another Frog (Practical05)
                    as a formal parameter and returns the frog (object reference) with the greatest age. For
                    example,
                    Frog f = myFrog.greaterAge(myFrog2);
                    f.print();
                    should cause the following lines to be printed:
                    **** Start of print method ******
                    Frog’s name is Fran
                    Id is 1001      */

            if (this.age > myFrog2.age)
            {
                return this;
            }
            else
            {
                return myFrog2;
            }
        }
    }
}
