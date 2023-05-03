// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class LeapYear
{
    public static void Main(string[] args)
    {
        int[] intArray = { 2, 7, 12 };
        int multiply = intArray[0] * intArray[1];
        int addition = intArray[0] + intArray[1];
        bool isGreater = false;
        if (multiply > intArray[2] || addition > intArray[2])
        {
            isGreater = true;
        }
        Console.WriteLine(isGreater);
    }
}