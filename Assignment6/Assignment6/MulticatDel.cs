using System;

namespace Assignment6
{
    class MulticatDel
    {
        //  This program demo. how to create multi-cast delegate.
     
            //  1.TO declare delegate.
            public delegate void Operation(int num1, int num2);

            public void Add(int num1, int num2)
            {
                Console.WriteLine($"The add is:{num1 +num2}");
            }
            public void Sub(int num1, int num2)
            {
                Console.WriteLine($"The sub is:{num1 - num2}");
            }
             public void Mult(int num1, int num2)
             {
            Console.WriteLine($"The sub is:{num1 * num2}");
              }
            public void Div(int num1, int num2)
            {
            Console.WriteLine($"The sub is:{num1 / num2}");
            }
        static void Main(string[] args)
        {
            MulticatDel multicatDel = new MulticatDel();
            //  2.To init. delegate
            Operation operation = new Operation(multicatDel.Add);
            operation += multicatDel.Sub;
            operation += multicatDel.Mult;
            operation += multicatDel.Div;
            //  3.To invoke delegate
            operation(10, 2);

            
            Console.ReadLine();
        }
    }
}
