using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class AnonyMethod
    {
        public delegate void Print(int value);
        static void Main()
        {
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            Print printDel = delegate (int value)
            {
                if (value > 1)
                {
                    Console.WriteLine("number is Positive");
                }
                else
                {
                    Console.WriteLine("number is Negative");
                }
            };
            printDel(100);
        }
    }
}
