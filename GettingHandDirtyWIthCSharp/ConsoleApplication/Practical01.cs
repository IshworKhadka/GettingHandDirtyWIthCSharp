using System;
using System.Collections.Generic;
using System.Text;

namespace GettingHandDirtyWIthCSharp.ConsoleApplication
{
    class Practical01
    {
        public void OutputFormat()
        {
            //*********Output************
            //42 = 7 * 6 (answer 1)
            //3 + 5 = 8 (answer 2)
            //The ideas of "state" and "sequence"
            //are fundamental to most programming.

            Console.WriteLine(42 + " = " + 7 + " * " + 6);
            Console.WriteLine(3 + " + " + 5 + " = " + 8);
            Console.WriteLine("The ideas of \"state\" and \"sequence\"");
            Console.WriteLine("are funadmental to most programming.");
        }

        public void SyntaxError()
        {
            //*********Solving these syntax errors************
            //Console.WriteLine("If you are reading this output ")
            //Console.WriteLine(in the execution "window then you have) ;
            //Console.WriteLine(successfully removed all the syntax errors)

            Console.WriteLine("If you are reading this output");
            Console.WriteLine("in the execution window then you have");
            Console.WriteLine("successfully removed all the syntax errors");
        }

        public void SemanticError()
        {
            //*********Solving these semantic errors************
            //Console.WriteLine(6 + 4 + "equals 10,") ;
            //Console.WriteLine("4" - 3 + "equals 1.") ;
            //Console.WriteLine("Well" * " done") ;

            Console.WriteLine(6 + " + " + 4 + " equals " + 10);
            Console.WriteLine(4 + " - " + 3 + " equals " + 1 + ".");
            Console.WriteLine("Well" + " done");

        }

    }
}
