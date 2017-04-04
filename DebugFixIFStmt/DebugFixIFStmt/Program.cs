using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //runs the program
            (new Program()).run();
        }


        void run()
        {
            //declares the variables
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;
            //show author name
            System.Console.WriteLine("Program by Tom Tague");
            //first choice with all values of 0
            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
            //second choice showing 2 as only choice
            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
            //Third choice showing 2 and 5 as the choices
            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
            //Fourth choice showing 2, 5, and 7
            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            //If else statements showing the choices that are available. 
            if (firstChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);
            else if (secondChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice, firstChoice);
            else if (thirdChoice == 0)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);
            else if (thirdChoice == 7)
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice);

        }
    }
}
