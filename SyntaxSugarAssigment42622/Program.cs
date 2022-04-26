using System;

namespace SyntaxSugarAssigment42622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //The commented out code is the assignment to be changed

            //int answer = 4;
            // string response;
            //if (answer < 9)
            // {
            //     response = answer + " is less than nine";
            // }
            // else
            // {
            //     response = answer + " is greater than or equal to nine";
            // }


            var answer = 4;
            var response = (answer > 9) ? "This is more than 9" : "This is less than 9";

            Console.WriteLine(response);
        }
    }
}
