using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int nums = 100;
            for (int i = 0; i < nums; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
    

}
