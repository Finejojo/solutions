// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Leap
{
    public class LeapYear
    {
        public static void Main(string[] args)
        {
            //int[] intArray = { 2, 7, 12 };
            //int multiply = intArray[0] * intArray[1];
            //int addition = intArray[0] + intArray[1];
            //bool isGreater = false;
            //if (multiply > intArray[2] || addition > intArray[2])
            //{
            //    isGreater = true;
            //}
            //Console.WriteLine(isGreater);
            // new project
            Console.WriteLine("what is the height of the building");
            string input = Console.ReadLine();
            double height = Convert.ToDouble(input);
            if (height > 7) { Console.WriteLine("special fire safety measures required"); }
            else { Console.WriteLine("No special safety measures required"); }

            Console.ReadKey();
        }
        
    }
   
}