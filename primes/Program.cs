// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //int[] Array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int nums = 100;
        for (int i = 2; i < nums; i++)
        {
            //Console.WriteLine(i);

            bool isprime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isprime = false; 
                    //Console.WriteLine(i);
                    break;
                }

            }
            if (isprime) 
            {
                Console.WriteLine(i);


             }

        }
    }
}