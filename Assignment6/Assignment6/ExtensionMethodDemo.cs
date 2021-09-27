using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
    class ExtensionMethodDemo
    {
        static void Main()
        {
            int num1 = 10;
            Console.WriteLine(num1.IsGreaterThan(5) ? "Current value is Greater than param. value" : "Current value is Smaller than param. value");
            Console.ReadLine();
        }
    }

    static class IntExtension
    {
        public static bool IsGreaterThan(this int CurrentInt, int intToCompare)
        {
            return CurrentInt > intToCompare;
        }
    }

}
